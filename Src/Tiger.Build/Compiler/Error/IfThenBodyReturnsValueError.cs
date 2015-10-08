using System;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class IfThenBodyReturnsValueError : TypeMismatchedError
    {
        public IfThenBodyReturnsValueError(Type returnedType, SourceLocation location)
            : base(typeof (void), returnedType, location)
        {
        }

        protected override string GetMessage()
        {
            return "The body of a if-then expression must not return any value";
        }
    }
}