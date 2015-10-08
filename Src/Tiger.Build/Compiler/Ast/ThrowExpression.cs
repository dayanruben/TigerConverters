namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class ThrowExpression : Statement
    {
        public Expression Expression { get; set; }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            Expression.CheckSemantics(astHelper);
        }

        protected internal override MAst Transform()
        {
            return MAst.Throw(Expression.Transform());
        }
    }
}