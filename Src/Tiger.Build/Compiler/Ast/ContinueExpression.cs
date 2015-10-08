using System.Linq.Expressions;
using Tiger.Build.Compiler.Error;
using MAst = System.Linq.Expressions.Expression;


namespace Tiger.Build.Compiler.Ast
{
    internal class ContinueExpression : Statement
    {
        private LabelTarget _target;

        #region Overrides of Expression

        /// <summary>
        ///   Transform as expression (value is read).
        /// </summary>
        protected internal override MAst Transform()
        {
            return MAst.Continue(_target);
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            //Debug.Assert(!astHelper.Expecting.IsExpectingType,"Continue is not allowed when we're expecting some type");
            astHelper.Errors.Check(new ExpectingTypeError(Start, astHelper.Expecting));
            if (!astHelper.Errors.Check(new ContinueOutOfLoopScopeError(Start, astHelper.LoopScope)))
            {
                _target = astHelper.LoopScope.ContinueLabel;
            }
        }

        #endregion
    }
}