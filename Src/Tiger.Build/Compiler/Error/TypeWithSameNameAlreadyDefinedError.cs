using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class TypeWithSameNameAlreadyDefinedError : ErrorBase
    {
        private readonly TypeScope _scope;
        private readonly string _typeName;

        public TypeWithSameNameAlreadyDefinedError(string typeName, TypeScope scope, SourceLocation location)
            : base(location)
        {
            _typeName = typeName;
            _scope = scope;
        }

        public override bool IsActive
        {
            get { return _scope.ContainsLocal(_typeName); }
        }

        protected override string GetMessage()
        {
            return "Other type with the same name already exist in the same scope";
        }
    }
}