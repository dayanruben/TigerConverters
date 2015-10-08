using System;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class NotAnArrayTypeError : ErrorBase
    {
        private readonly Type _type;

        public NotAnArrayTypeError(Type type, SourceLocation location) : base(location)
        {
            _type = type;
        }

        public override bool IsActive
        {
            get { return !_type.IsArray; }
        }

        protected override string GetMessage()
        {
            return string.Format("The type {0} must be an array", _type);
        }
    }
}