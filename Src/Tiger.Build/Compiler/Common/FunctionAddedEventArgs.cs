using System;
using System.Linq.Expressions;

namespace Tiger.Build.Compiler.Ast
{
    public class FunctionAddedEventArgs : EventArgs
    {
        public string FunctionName { get; private set; }

        public LambdaExpression Function { get; private set; }

        public FunctionAddedEventArgs(string functionName, LambdaExpression function)
        {
            FunctionName = functionName;
            Function = function;
        }
    }
}