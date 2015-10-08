namespace Tiger.Build.Compiler.Ast
{
    public class ArrayTypeDeclarationNode : TypeDeclarationNode, IReferenceType
    {
        #region IReferenceType Members

        public TypeReferenceNode ExistingType { get; set; }

        #endregion

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);
            ExistingType.CheckSemantics(astHelper);
            if (ExistingType.HasType)
                astHelper.Types.Add(Name.Name, ExistingType.ReferencedType.MakeArrayType());
        }
    }
}