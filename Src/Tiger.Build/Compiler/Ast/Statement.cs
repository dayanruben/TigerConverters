using System;

namespace Tiger.Build.Compiler.Ast
{
    public abstract class Statement : Expression
    {
        public override sealed Type Type
        {
            get { return typeof (void); }
        }
    }
}