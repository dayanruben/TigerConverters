using System;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class IfThenExpression : Expression
    {
        #region Ast members

        public Expression Test { get; set; }

        public Expression Then { get; set; }

        #endregion

        public override Type Type
        {
            get { return typeof (void); }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            Test.CheckSemantics(astHelper);
            Then.CheckSemantics(astHelper);

            astHelper.Errors.Check(new IfThenBodyReturnsValueError(Then.Type, Then.Start));
        }

        protected internal override MAst Transform()
        {
            return MAst.IfThen(Test.Transform(), Then.Transform());
        }
    }
}