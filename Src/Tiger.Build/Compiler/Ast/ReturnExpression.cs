using System.Linq.Expressions;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class ReturnExpression : Statement
    {
        private LabelTarget _returnLabel;

        public Expression Value { get; set; }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            Value.CheckSemantics(astHelper);

            // todo checkSemantics for the return expression class, similar to the continue/break with the assignments

            _returnLabel = astHelper.ReturnScope.ReturnLabel;
        }

        protected internal override MAst Transform()
        {
            return MAst.Return(_returnLabel, Value.Transform());
        }
    }
}