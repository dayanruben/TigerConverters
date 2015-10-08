using System.Linq.Expressions;

namespace Tiger.Build.Compiler.Common
{
    public class LoopScope
    {
        public LoopScope(LabelTarget breakLabel, LabelTarget continueLabel)
        {
            BreakLabel = breakLabel;
            ContinueLabel = continueLabel;
        }

        public LabelTarget BreakLabel { get; private set; }
        public LabelTarget ContinueLabel { get; private set; }
    }
}