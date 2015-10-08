using System;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class BinaryOperationExpression : Expression
    {
        #region Ast members

        public Expression Left { get; set; }

        public Expression Right { get; set; }

        public TigerOperator Operator { get; set; }

        #endregion

        public override Type Type
        {
            get
            {
                // todo check the type of the result of a binary operation
                return Left.Type == typeof (Null)
                           ? Right.Type
                           : Left.Type;
            }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            Left.CheckSemantics(astHelper);
            Right.CheckSemantics(astHelper);

            // SPEC: Nil must be used in a context were its actual record type can be determined
            // SPEC: Thus the following are ilegal: var a := nil, if nil = nil then ...
            astHelper.Errors.Check(new CanNotInferTypeError(Left.Type, Right.Type, Start));
        }

        protected internal override MAst Transform()
        {
            MAst left = Left.Transform();
            MAst right = Right.Transform();

            switch (Operator)
            {
                case TigerOperator.Add:
                    return MAst.Add(left, right);
                case TigerOperator.Subtract:
                    return MAst.Subtract(left, right);
                case TigerOperator.Multiply:
                    return MAst.Multiply(left, right);
                case TigerOperator.Divide:
                    return MAst.Divide(left, right);
                case TigerOperator.Mod:
                    return MAst.Modulo(left, right);
                case TigerOperator.Power:
                    // todo handle doubles in operations
                    return
                        MAst.Convert(
                            MAst.Power(MAst.Convert(left, typeof (double)), MAst.Convert(right, typeof (double))),
                            typeof (int));
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}