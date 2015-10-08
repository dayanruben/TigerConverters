using System.Linq.Expressions;
using Tiger.Build.Compiler.Error;
using MAst = System.Linq.Expressions.Expression;


namespace Tiger.Build.Compiler.Ast
{
    internal class BreakExpression : Statement
    {
        private LabelTarget _target;

        #region Overrides of Expression

        /// <summary>
        ///   Transform as expression (value is read).
        /// </summary>
        protected internal override MAst Transform()
        {
            return MAst.Break(_target);
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            //Debug.Assert(!astHelper.Expecting.IsExpectingType,"A break is not allowed when we are expecting a type");
            astHelper.Errors.Check(new ExpectingTypeError(Start, astHelper.Expecting));
            if (! astHelper.Errors.Check(new BreakOutOfLoopScopeError(Start, astHelper.LoopScope)))
            {
                _target = astHelper.LoopScope.BreakLabel;
            }
        }

        #endregion
    }
}