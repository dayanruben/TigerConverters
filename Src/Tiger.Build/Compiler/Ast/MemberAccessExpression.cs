namespace Tiger.Build.Compiler.Ast
{
    public abstract class MemberAccessExpression : Expression
    {
        public Expression Target { get; set; }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            Target.CheckSemantics(astHelper);
        }
    }
}