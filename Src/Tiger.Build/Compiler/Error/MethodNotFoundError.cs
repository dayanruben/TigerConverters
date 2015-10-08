using System;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    /// <summary>
    /// true when the specified type doesn't contains a method with the specified name
    /// </summary>
    public class MethodNotFoundError : ErrorBase
    {
        private readonly Type[] _argTypes;
        private readonly string _methodName;
        private readonly Type _targetType;

        public MethodNotFoundError(Type targetType, string methodName, Type[] argTypes, SourceLocation location)
            : base(location)
        {
            _targetType = targetType;
            _methodName = methodName;
            _argTypes = argTypes;
        }

        public override bool IsActive
        {
            get
            {
                // how to check if the specified type contains a method with the given name without calling GetMethod
                return _targetType.GetMethod(_methodName, _argTypes) == null;
            }
        }

        protected override string GetMessage()
        {
            return string.Format("Can not resolve method '{0}'", _methodName);
        }
    }
}