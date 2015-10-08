using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class MemberWithSameNameAlreadyDefinedError : ErrorBase
    {
        public MemberWithSameNameAlreadyDefinedError(string memberName, AstHelper helper, SourceLocation location)
            : base(location)
        {
            MemberName = memberName;
            Helper = helper;
        }

        protected AstHelper Helper { get; set; }

        public string MemberName { get; private set; }

        public override bool IsActive
        {
            get { return Helper.Functions.ContainsLocal(MemberName) || Helper.Variables.ContainsLocal(MemberName); }
        }

        protected override string GetMessage()
        {
            return string.Format("Another member with the same name ('{0}') is already defined", MemberName);
        }
    }
}