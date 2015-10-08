using System;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    /// <summary>
    /// represents a type that should be defined in the scope, the type can be accesed throught 
    /// the property <see cref="HasType"/>
    /// </summary>
    public class TypeReferenceNode : Node
    {
        #region Ast members

        public string TypeName { get; set; }

        #endregion

        // in the future this class could make references to any CLR type

        public TypeReferenceNode()
        {
            ReferencedType = typeof (void);
        }

        public TypeReferenceNode(Type existingType) : this()
        {
            TypeName = existingType.Name;

            ReferencedType = existingType;
        }

        public bool HasType
        {
            get { return !string.IsNullOrEmpty(TypeName); }
        }

        public Type ReferencedType { get; private set; }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            // if the type is not defined or is already a direct reference to it
            if (!HasType || ReferencedType != typeof (void)) return;

            if (!astHelper.Errors.Check(new MissingTypeError(TypeName, astHelper.Types, Start)))
                ReferencedType = astHelper.Types[TypeName];
        }
    }
}