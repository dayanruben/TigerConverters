using System;
using System.Collections.Generic;
using System.Linq;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class RecordInitExpression : Expression
    {
        #region Ast members

        public TypeReferenceNode TypeName { get; set; }

        public IEnumerable<FieldInitializationNode> Fields { get; set; }

        #endregion

        private LetInExpression _inner;

        public override Type Type
        {
            get { return TypeName.ReferencedType; }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            TypeName.CheckSemantics(astHelper);

            string result = "#result";
            _inner = new LetInExpression
                {
                    VariableDeclarations = new List<VariableDeclarationBase>
                        {
                            new VariableDeclarationExpression
                                {
                                    VariableName = new MemberIdentifierNode {Name = result},
                                    Value = new NewExpression(TypeName.ReferencedType)
                                }
                        },
                    Body = new ListSemiExpression(from field in Fields
                                                  select new AssignExpression
                                                      {
                                                          Left = new FieldAccessExpression
                                                              {
                                                                  FieldName = field.FieldName,
                                                                  Target = new VariableAccessExpression
                                                                      {
                                                                          VariableName = result
                                                                      }
                                                              },
                                                          Right = field.Value,
                                                          Start = field.Start
                                                      })
                        {
                            new VariableAccessExpression
                                {
                                    VariableName = result
                                }
                        }
                };

            _inner.CheckSemantics(astHelper);
        }

        protected internal override MAst Transform()
        {
            return _inner.Transform();
        }
    }
}