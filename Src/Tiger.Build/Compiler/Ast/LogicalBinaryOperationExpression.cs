using System;
using System.Linq.Expressions;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class LogicalBinaryOperationExpression : BinaryOperationExpression
    {
        private static readonly Expression<Func<object, object, bool>> EqualsExpression =
            (a, b) => Equals(a, b);

        private static readonly Expression<Func<object, object, bool>> NotEqualsExpression =
            (a, b) => !Equals(a, b);

        public override Type Type
        {
            get { return typeof (bool); }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            // SPEC: The comparison operators do not associate, e.g., a=b=c is erroneous, but a=(b=c) is legal.
            if (!Operator.IsComparison()) throw new InvalidOperationException();

            AstHelper helper = astHelper.CreateChild(expecting: true);

            Left.CheckSemantics(helper);
            Right.CheckSemantics(helper);

            // SPEC: Nil must be used in a context were its actual record type can be determined
            // SPEC: Thus the following are ilegal: var a := nil, if nil = nil then ...
            astHelper.Errors.Check(new CanNotInferTypeError(Left.Type, Right.Type, Start));

            astHelper.Errors.Check(new OperatorNotDefinedError(Left.Type, Right.Type, Operator, Start));
        }

        protected internal override MAst Transform()
        {
            MAst left = Left.Transform();
            MAst right = Right.Transform();

            switch (Operator)
            {
                case TigerOperator.AndAlso:
                    return MAst.AndAlso(left, right);
                case TigerOperator.OrElse:
                    return MAst.OrElse(left, right);
                case TigerOperator.ExclusiveOr:
                    return MAst.ExclusiveOr(left, right);
                case TigerOperator.LessThan:
                    return MAst.LessThan(left, right);
                case TigerOperator.LessThanOrEqual:
                    return MAst.LessThanOrEqual(left, right);
                case TigerOperator.GreaterThan:
                    return MAst.GreaterThan(left, right);
                case TigerOperator.GreaterThanOrEqual:
                    return MAst.GreaterThanOrEqual(left, right);

                case TigerOperator.Equal:
                    return MAst.Invoke(EqualsExpression, left.Convert<object>(), right.Convert<object>());
                case TigerOperator.NotEqual:
                    return MAst.Invoke(NotEqualsExpression, left.Convert<object>(), right.Convert<object>());
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}