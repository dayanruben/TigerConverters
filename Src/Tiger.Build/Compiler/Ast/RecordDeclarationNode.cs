using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    public class RecordDeclarationNode : TypeDeclarationNode, IAddToScope
    {
        /// <summary>
        /// Two types with the same name can't be defined in the same assembly,
        /// when this happens to the type name we append this variable.
        /// </summary>
        protected static int TypeUniqueId = 1;

        private TypeBuilder _builder;

        public RecordDeclarationNode()
        {
            Fields = Enumerable.Empty<RecordFieldNode>();
        }

        public IEnumerable<RecordFieldNode> Fields { get; set; }

        #region IAddToScope Members

        public void AddToScope(AstHelper astHelper)
        {
            string typeName = astHelper.Types.Contains(Name.Name) ? Name.Name + TypeUniqueId++ : Name.Name;
            astHelper.Errors.Check(new TypeWithSameNameAlreadyDefinedError(Name.Name, astHelper.Types, Start));

            _builder = astHelper.ModuleBuilder.DefineType(typeName, TypeAttributes.NotPublic);

            // the type is added to the scope with it's name
            astHelper.Types.Add(Name.Name, _builder);
        }

        #endregion

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            foreach (RecordFieldNode fieldNode in Fields)
            {
                fieldNode.CheckSemantics(astHelper);

                if (fieldNode.TypeName.HasType)
                    _builder.DefineField(fieldNode.FieldName.Name, fieldNode.TypeName.ReferencedType,
                                         FieldAttributes.Public);
            }

            astHelper.Types.CreateType(Name.Name);
        }
    }
}