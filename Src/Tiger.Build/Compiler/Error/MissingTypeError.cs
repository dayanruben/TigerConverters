using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    /// <summary>
    /// when a type reference can't be resolved
    /// </summary>
    public class MissingTypeError : ErrorBase
    {
        private readonly TypeScope _scope;
        private readonly string _typeName;

        public MissingTypeError(string typeName, TypeScope scope, SourceLocation location)
            : base(location)
        {
            _typeName = typeName;
            _scope = scope;
        }

        public override bool IsActive
        {
            get { return !_scope.Contains(_typeName); }
        }

        protected override string GetMessage()
        {
            return string.Format("The type '{0}' can't be found in the current scope", _typeName);
        }
    }
}