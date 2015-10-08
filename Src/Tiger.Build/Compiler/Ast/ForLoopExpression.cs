using System.Collections.Generic;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;
using Tiger.Build.Compiler.Ast;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class ForLoopExpression : Statement
    {
        #region Ast members

        public IdentifierNode VariableName { get; set; }

        public Expression From { get; set; }

        public Expression To { get; set; }

        public Expression Body { get; set; }

        #endregion

        private LetInExpression _implementation;


        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            var from = From.ProtectSemantics();
            var to =To.ProtectSemantics();

            from.CheckSemantics(astHelper);
            to.CheckSemantics(astHelper);

            bool error = false;
            error |= astHelper.Errors.Check(new NotAssignableError(typeof (int), from.Type, VariableName.Start));
            error |= astHelper.Errors.Check(new NotAssignableError(typeof (int), to.Type, VariableName.Start));

            if (error) return;

            _implementation = new LetInExpression
                {
                    VariableDeclarations = new List<VariableDeclarationBase>
                        {
                            new VariableDeclarationExpression
                                {
                                    VariableName =
                                        new MemberIdentifierNode
                                            {Name = VariableName.Name},
                                    Value = from
                                }
                        },
                    Body = new ListSemiExpression
                        {
                            new WhileExpression
                                {
                                    Test = new LogicalBinaryOperationExpression
                                        {
                                            Left = new VariableAccessExpression
                                                {
                                                    VariableName =
                                                        VariableName.Name
                                                },
                                            Right = to,
                                            Operator = TigerOperator.LessThanOrEqual
                                        },
                                    Body = new ListSemiExpression
                                        {
                                            Body,
                                            new UnaryOperationExpression
                                                {
                                                    Expression =
                                                        new VariableAccessExpression
                                                            {
                                                                VariableName =
                                                                    VariableName.Name
                                                            },
                                                    Operator =
                                                        TigerOperator.PreIncrementAssign
                                                },
                                            new EmptyExpression()
                                        }
                                }
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