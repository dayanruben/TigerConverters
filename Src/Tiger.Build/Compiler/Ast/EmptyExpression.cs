namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class EmptyExpression : Statement
    {
        protected internal override MAst Transform()
        {
            return MAst.Empty();
        }
    }
}