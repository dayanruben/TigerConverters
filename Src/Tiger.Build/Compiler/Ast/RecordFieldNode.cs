namespace Tiger.Build.Compiler.Ast
{
    public class RecordFieldNode : Node
    {
        public IdentifierNode FieldName { get; set; }

        public TypeReferenceNode TypeName { get; set; }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            FieldName.CheckSemantics(astHelper);
            TypeName.CheckSemantics(astHelper);
        }
    }
}