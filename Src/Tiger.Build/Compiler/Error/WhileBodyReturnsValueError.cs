using System;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class WhileBodyReturnsValueError : TypeMismatchedError
    {
        public WhileBodyReturnsValueError(Type returnedType, SourceLocation location)
            : base(typeof (void), returnedType, location)
        {
        }

        protected override string GetMessage()
        {
            return "The body of a while expression must not return any value";
        }
    }
}