using System;
using System.Collections.Generic;
using System.Linq;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Common
{
    /// <summary>
    ///   This scope should store the functions defined in a let statement, those
    ///   that are available in the current scope.
    /// </summary>
    /// <remarks>
    ///   This class should handle method overloading
    /// </remarks>
    public class FunctionScope : ScopeCollection<IEnumerable<FunctionReference>>
    {
        public FunctionReference this[string key, params Type[] argTypes]
        {
            get { return this[key, (IEnumerable<Type>) argTypes]; }
        }

        public FunctionReference this[string key, IEnumerable<Type> argTypes]
        {
            get { return ResolveFunction(key, argTypes).First(); }
        }

        private IEnumerable<FunctionReference> ResolveFunction(string functionName, IEnumerable<Type> argTypes)
        {
            if (!Contains(functionName))
                return Enumerable.Empty<FunctionReference>();

            IEnumerable<FunctionReference> functions = base[functionName];

            return ResolveFunction(functions, argTypes);
        }

        private IEnumerable<FunctionReference> ResolveLocalFunction(string functionName, IEnumerable<Type> argTypes)
        {
            if (!Contains(functionName))
                return Enumerable.Empty<FunctionReference>();

            IEnumerable<FunctionReference> functions = GetLocal(functionName);

            return ResolveFunction(functions, argTypes);
        }

        /// <summary>
        /// Filters the <paramref name="functions"/> and returns only those wich it's signature
        /// match the specified <paramref name="argTypes"/>
        /// </summary>
        /// <param name="functions"></param>
        /// <param name="argTypes"></param>
        /// <returns></returns>
        private static IEnumerable<FunctionReference> ResolveFunction(IEnumerable<FunctionReference> functions,
                                                                      IEnumerable<Type> argTypes)
        {
            return from function in functions
                   where function.ArgTypes.Count() == argTypes.Count()
                   let isAsignable =
                       function.ArgTypes.Zip(argTypes, (FunctionType, InvokeType) => new {FunctionType, InvokeType})
                       .All(arg => IsAsignable(arg.FunctionType, arg.InvokeType))
                   where isAsignable
                   select function;
        }

        private static bool IsAsignable(Type functionType, Type invokeType)
        {
            var error = new NotAssignableError(functionType, invokeType, SourceLocation.Invalid);
            return !error.IsActive;
        }

        public bool Contains(string functionName, IEnumerable<Type> argTypes)
        {
            return ResolveFunction(functionName, argTypes).FirstOrDefault() != null;
        }

        public bool ContainsLocal(string functionName, IEnumerable<Type> argTypes)
        {
            return ResolveLocalFunction(functionName, argTypes).FirstOrDefault() != null;
        }

        public void Add(string functionName, FunctionReference function)
        {
            if (Contains(functionName))
                ((List<FunctionReference>) base[functionName]).Add(function);
            else
                Add(functionName, new List<FunctionReference> {function});
        }

        protected override ScopeBase<IEnumerable<FunctionReference>> Create()
        {
            return new FunctionScope();
        }
    }
}