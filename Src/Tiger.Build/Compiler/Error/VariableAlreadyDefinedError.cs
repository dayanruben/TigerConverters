using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class VariableAlreadyDefinedError : MemberWithSameNameAlreadyDefinedError
    {
        public VariableAlreadyDefinedError(string variableName, AstHelper helper, SourceLocation location)
            : base(variableName, helper, location)
        {
        }

        public override bool IsActive
        {
            get { return Helper.Variables.ContainsLocal(MemberName); }
        }
    }
}