using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class AssignExpression : Statement
    {
        #region Ast members

        public Expression Left { get; set; }

        public Expression Right { get; set; }

        #endregion

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            Left.CheckSemantics(astHelper);

            AstHelper helper = astHelper.CreateChild(expecting: true, expectedType: Left.Type);

            Right.CheckSemantics(helper);

            astHelper.Errors.Check(new NotAssignableError(Left.Type, Right.Type, Start));
        }

        protected internal override MAst Transform()
        {
            return MAst.Assign(Left.Transform(), Right.Transform());
        }
    }
}