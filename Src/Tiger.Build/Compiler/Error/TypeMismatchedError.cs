using System;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    /// <summary>
    /// when a type is expected and other is found
    /// </summary>
    public class TypeMismatchedError : ErrorBase
    {
        private readonly Type _actualType;
        private readonly Type _expectedType;

        public TypeMismatchedError(Type expectedType, Type actualType, SourceLocation location) : base(location)
        {
            _expectedType = expectedType;
            _actualType = actualType;
        }

        public Type ActualType
        {
            get { return _actualType; }
        }

        public Type ExpectedType
        {
            get { return _expectedType; }
        }

        public override bool IsActive
        {
            get { return !TypeUtils.AreEquivalent(_expectedType, _actualType); }
        }

        protected override string GetMessage()
        {
            return string.Format("Types doesn't match: expected {0} but {1} was found", _expectedType, _actualType);
        }
    }
}