using System;
using System.Collections.Generic;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class FunctionNotDefinedError : ErrorBase
    {
        private readonly IEnumerable<Type> _argTypes;
        private readonly string _functionName;
        private readonly FunctionScope _scope;

        public FunctionNotDefinedError(string functionName, IEnumerable<Type> argTypes, FunctionScope scope,
                                       SourceLocation location)
            : base(location)
        {
            _functionName = functionName;
            _argTypes = argTypes;
            _scope = scope;
        }

        public IEnumerable<Type> ArgTypes
        {
            get { return _argTypes; }
        }

        public string FunctionName
        {
            get { return _functionName; }
        }

        public override bool IsActive
        {
            get { return !_scope.Contains(_functionName, _argTypes); }
        }

        protected override string GetMessage()
        {
            return string.Format("The function '{0}' is not defined in the current context", _functionName);
        }
    }
}