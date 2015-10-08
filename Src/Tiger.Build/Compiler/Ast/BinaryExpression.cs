namespace Tiger.Build.Compiler.Ast
{
    public abstract class BinaryExpression : Expression
    {
        #region Ast members

        public Expression Left { get; set; }

        public Expression Right { get; set; }

        #endregion

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            Left.CheckSemantics(astHelper);
            Right.CheckSemantics(astHelper);
        }
    }
}