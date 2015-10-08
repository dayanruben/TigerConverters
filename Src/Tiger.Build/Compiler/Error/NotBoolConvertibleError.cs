using System;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class NotBoolConvertibleError : TypeMatchedError
    {
        public NotBoolConvertibleError(Type type, SourceLocation location) : base(type, typeof (void), location)
        {
        }

        protected override string GetMessage()
        {
            return string.Format("The type {0} is not convertible to bool", Type);
        }
    }
}