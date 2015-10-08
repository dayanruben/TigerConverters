namespace Tiger.Build.Compiler.Ast
{
    public class FieldInitializationNode : Node
    {
        #region Ast members

        public IdentifierNode FieldName { get; set; }
        public Expression Value { get; set; }

        #endregion

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            FieldName.CheckSemantics(astHelper);
            Value.CheckSemantics(astHelper);
        }
    }
}