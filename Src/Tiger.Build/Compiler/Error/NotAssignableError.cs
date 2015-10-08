using System;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class NotAssignableError : ErrorBase
    {
        private readonly Type _valueType;
        private readonly Type _variableType;

        public NotAssignableError(Type variableType, Type valueType, SourceLocation location) : base(location)
        {
            _variableType = variableType;
            _valueType = valueType;
        }

        public Type ValueType
        {
            get { return _valueType; }
        }

        public Type VariableType
        {
            get { return _variableType; }
        }

        public override bool IsActive
        {
            get
            {
                // the null type can be assigned to every type
                if (!_variableType.IsValueType && _valueType == typeof (Null))
                    return false;

                return !TypeUtils.IsImplicitlyConvertible(_valueType, _variableType);
            }
        }

        protected override string GetMessage()
        {
            return string.Format("Can't convert from type {1} to type {0}", _variableType, _valueType);
        }
    }
}