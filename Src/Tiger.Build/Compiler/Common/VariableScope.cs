using System.Linq.Expressions;

namespace Tiger.Build.Compiler.Common
{
    public class VariableScope : ScopeCollection<ParameterExpression>
    {
        protected override ScopeBase<ParameterExpression> Create()
        {
            return new VariableScope();
        }
    }
}