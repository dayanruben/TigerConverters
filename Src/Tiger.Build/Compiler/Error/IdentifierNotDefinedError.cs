using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    /// <summary>
    /// when a variable access is not defined in the current scope
    /// </summary>
    public class IdentifierNotDefinedError : ErrorBase
    {
        private readonly VariableScope _scope;
        private readonly string _variableName;

        public IdentifierNotDefinedError(string variableName, VariableScope scope, SourceLocation location)
            : base(location)
        {
            _variableName = variableName;
            _scope = scope;
        }

        public string VariableName
        {
            get { return _variableName; }
        }

        public override bool IsActive
        {
            get { return !_scope.Contains(VariableName); }
        }

        protected override string GetMessage()
        {
            return string.Format("The variable '{0}' is not defined in the current context", _variableName);
        }
    }
}