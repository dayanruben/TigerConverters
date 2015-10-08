using System;
using System.Collections.Generic;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    public class ForInExpression : Statement
    {
        #region Ast members

        public IdentifierNode Identifier { get; set; }

        public Expression Collection { get; set; }

        public Expression Body { get; set; }

        #endregion

        private static int _uniqueId = 1;
        private LetInExpression _implementation;

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);
            var collectionWrapper =  Collection.ProtectSemantics();
            collectionWrapper.CheckSemantics(astHelper);

            if (!astHelper.Errors.Check(new NotEnumerableError(collectionWrapper.Type, Collection.Start)))
            {
                Type collectionType = TypeUtils.GetCollectionType(collectionWrapper.Type);

                string enumerator = "#enumerator" + _uniqueId++;
                _implementation = new LetInExpression
                    {
                        VariableDeclarations = new List<VariableDeclarationBase>
                            {
                                new VariableDeclarationExpression
                                    {
                                        VariableName = new MemberIdentifierNode
                                            {
                                                Name = enumerator
                                            },
                                        Value = new MethodCallExpression
                                            {
                                                MethodName = new IdentifierNode
                                                    {
                                                        Name = "GetEnumerator"
                                                    },
                                                Target = collectionWrapper
                                            }
                                    },
                                new VariableDeclarationBase
                                    {
                                        VariableName = new MemberIdentifierNode
                                            {
                                                Name = Identifier.Name
                                            },
                                        VariableTypeName = new TypeReferenceNode(collectionType)
                                    }
                            },
                        Body = new ListSemiExpression
                            {
                                new WhileExpression
                                    {
                                        Test = new MethodCallExpression
                                            {
                                                Target = new VariableAccessExpression
                                                    {
                                                        VariableName = enumerator
                                                    },
                                                MethodName = new IdentifierNode
                                                    {
                                                        Name = "MoveNext"
                                                    }
                                            },
                                        Body = new ListSemiExpression
                                            {
                                                new AssignExpression
                                                    {
                                                        Left = new VariableAccessExpression
                                                            {
                                                                VariableName = Identifier.Name
                                                            },
                                                        Right = new TypeCastExpression
                                                            {
                                                                Expression = new FieldAccessExpression
                                                                    {
                                                                        Target = new VariableAccessExpression
                                                                            {
                                                                                VariableName = enumerator
                                                                            },
                                                                        FieldName = new IdentifierNode
                                                                            {
                                                                                Name = "Current"
                                                                            }
                                                                    },
                                                                TargetType = collectionType
                                                            }
                                                    },
                                                Body
                                            }
                                    }
                            }
                    };
                _implementation.CheckSemantics(astHelper);
            }
        }

        protected internal override System.Linq.Expressions.Expression Transform()
        {
            return _implementation.Transform();
        }
    }
}