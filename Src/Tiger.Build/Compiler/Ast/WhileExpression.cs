using System.Linq.Expressions;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class WhileExpression : Statement
    {
        private LabelTarget _breakLabel;
        private LabelTarget _continueLabel;

        #region Ast members

        public Expression Test { get; set; }

        public Expression Body { get; set; }

        #endregion

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            _breakLabel = MAst.Label();
            _continueLabel = MAst.Label();

            Test.CheckSemantics(astHelper);

            AstHelper child = astHelper.CreateChild(loop: true, breakLabel: _breakLabel, continueLabel: _continueLabel);
            Body.CheckSemantics(child);

            astHelper.Errors.Check(new WhileBodyReturnsValueError(Body.Type, Start));
        }

        protected internal override MAst Transform()
        {
            MAst test = Test.Transform();
            MAst body = Body.Transform();

            return MAst.Loop(MAst.IfThenElse(test, body, MAst.Break(_breakLabel)), _breakLabel, _continueLabel);
        }
    }
}