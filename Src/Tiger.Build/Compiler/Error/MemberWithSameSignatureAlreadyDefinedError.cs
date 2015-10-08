using System;
using System.Collections.Generic;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class MemberWithSameSignatureAlreadyDefinedError : MemberWithSameNameAlreadyDefinedError
    {
        public MemberWithSameSignatureAlreadyDefinedError(string memberName, IEnumerable<Type> argTypes,
                                                          AstHelper helper, SourceLocation location)
            : base(memberName, helper, location)
        {
            ArgTypes = argTypes;
        }

        public IEnumerable<Type> ArgTypes { get; private set; }

        public override bool IsActive
        {
            get { return Helper.Functions.ContainsLocal(MemberName, ArgTypes); }
        }

        protected override string GetMessage()
        {
            return "Member with same signature is already declared";
        }
    }
}