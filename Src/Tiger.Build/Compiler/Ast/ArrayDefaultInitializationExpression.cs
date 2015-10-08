using System;
using System.Collections.Generic;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class ArrayDefaultInitializationExpression : ArrayInitializationExpression
    {
        private static int uniqueId = 1;
        private LetInExpression _implementation;

        #region Ast members

        public Expression InitialValue { get; set; }

        #endregion

        public override Type Type
        {
            get { return _implementation.Type; }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            string lenght = "#length" + uniqueId++;
            string result = "#result" + uniqueId++;
            string forVarName = "#i" + uniqueId++;

            var valueEnclosed = InitialValue.ProtectSemantics();

            _implementation = new LetInExpression
                {
                    VariableDeclarations = new List<VariableDeclarationBase>
                        {
                            new VariableDeclarationExpression
                                {
                                    VariableName =
                                        new MemberIdentifierNode
                                            {Name = lenght},
                                    Value = Lenght
                                },
                            new VariableDeclarationExpression
                                {
                                    VariableName =
                                        new MemberIdentifierNode
                                            {Name = result},
                                    Value = new ArrayInitializationExpression
                                        {
                                            ArrayTypeName =
                                                ArrayTypeName,
                                            Lenght =
                                                new VariableAccessExpression
                                                    {
                                                        VariableName =
                                                            lenght
                                                    }
                                        }
                                }
                        },
                    Body = new ListSemiExpression
                        {
                            new ForLoopExpression
                                {
                                    VariableName = new IdentifierNode {Name = forVarName},
                                    From = new IntLiteralExpression(0),
                                    To = new BinaryOperationExpression
                                        {
                                            Operator = TigerOperator.Subtract,
                                            Left = new VariableAccessExpression
                                                {
                                                    VariableName = lenght
                                                },
                                            Right = new IntLiteralExpression(1)
                                        },
                                    Body = new AssignExpression
                                        {
                                            Left = new ArrayIndexExpression
                                                {
                                                    Indexes = new[]
                                                        {
                                                            new VariableAccessExpression
                                                                {
                                                                    VariableName
                                                                        =
                                                                        forVarName
                                                                }
                                                        },
                                                    Target =
                                                        new VariableAccessExpression
                                                            {
                                                                VariableName =
                                                                    result
                                                            }
                                                },
                                            Right = valueEnclosed
                                        }
                                },
                            new VariableAccessExpression {VariableName = result}
                        }
                };

            _implementation.CheckSemantics(astHelper);
        }

        protected internal override MAst Transform()
        {
            return _implementation.Transform();
        }
    }
}