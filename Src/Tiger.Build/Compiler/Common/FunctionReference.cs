using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Tiger.Build.Compiler.Common
{
    public class FunctionReference
    {
        public FunctionReference(Expression function, Type returnType, params Type[] argTypes)
            : this(function, returnType, (IEnumerable<Type>) argTypes)
        {
        }

        public FunctionReference(Expression function, Type returnType, IEnumerable<Type> argTypes)
        {
            ReturnType = returnType;
            ArgTypes = argTypes;
            Function = function;
        }


        public Expression Function { get; private set; }

        public Type ReturnType { get; private set; }

        public IEnumerable<Type> ArgTypes { get; private set; }
    }
}