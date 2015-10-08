using System;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class ConditionalNotEquivalentTypes : TypeMismatchedError
    {
        public ConditionalNotEquivalentTypes(Type thenType, Type elseType, SourceLocation location)
            : base(thenType, elseType, location)
        {
        }

        public override bool IsActive
        {
            get
            {
                if (ActualType == typeof (Null) || ExpectedType == typeof (Null))
                    return false;

                return base.IsActive;
            }
        }

        protected override string GetMessage()
        {
            return
                string.Format(
                    "Type of conditional expression can't be determined because types {0} and {1} aren't equivalent",
                    ExpectedType.Name, ActualType.Name);
        }
    }
}