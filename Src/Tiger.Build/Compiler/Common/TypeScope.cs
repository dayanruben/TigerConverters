using System;
using System.Reflection.Emit;

namespace Tiger.Build.Compiler.Common
{
    public class TypeScope : ScopeCollection<Type>
    {
        protected override ScopeBase<Type> Create()
        {
            return new TypeScope();
        }

        public void CreateType(string name)
        {
            if (!ContainsLocal(name)) return;

            var typeBuilder = this[name] as TypeBuilder;
            if (typeBuilder == null) return;

            SetValue(name, typeBuilder.CreateType());
        }
    }
}