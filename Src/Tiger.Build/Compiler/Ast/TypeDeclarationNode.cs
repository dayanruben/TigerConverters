namespace Tiger.Build.Compiler.Ast
{
    public abstract class TypeDeclarationNode : Node
    {
        public TypeIdentifierNode Name { get; set; }


        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            Name.CheckSemantics(astHelper);
        }
    }
}