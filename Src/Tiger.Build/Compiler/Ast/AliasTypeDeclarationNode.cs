namespace Tiger.Build.Compiler.Ast
{
    public class AliasTypeDeclarationNode : TypeDeclarationNode, IReferenceType
    {
        #region IReferenceType Members

        public TypeReferenceNode ExistingType { get; set; }

        #endregion

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);
            ExistingType.CheckSemantics(astHelper);

            // if there's no error add the type
            if (ExistingType.HasType)
                astHelper.Types.Add(Name.Name, ExistingType.ReferencedType);
        }

        public override string ToString()
        {
            return string.Format("Name:{0}, ExistingType: {1}", Name.Name, ExistingType);
        }
    }
}