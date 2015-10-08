using System;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class UnaryOperationExpression : Expression
    {
        public Expression Expression { get; set; }

        public TigerOperator Operator { get; set; }

        public override Type Type
        {
            get
            {
                // todo return the type based on the specified operator
                return Expression.Type;
            }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            Expression.CheckSemantics(astHelper);
        }

        protected internal override MAst Transform()
        {
            MAst target = Expression.Transform();
            switch (Operator)
            {
                case TigerOperator.Not:
                    return target.Not();

                case TigerOperator.Negate:
                    return MAst.Negate(target);

                case TigerOperator.PreIncrementAssign:
                    return MAst.PreIncrementAssign(target);
                case TigerOperator.PreDecrementAssign:
                    return MAst.PreDecrementAssign(target);

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}