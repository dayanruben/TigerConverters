using System;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public abstract class MemberNotFoundError : ErrorBase
    {
        protected MemberNotFoundError(Type targetType, string memberName, SourceLocation location) : base(location)
        {
            TargetType = targetType;
            MemberName = memberName;
        }

        public Type TargetType { get; private set; }
        public string MemberName { get; private set; }
    }
}