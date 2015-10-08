using System.Collections.Generic;

namespace Tiger.Build.Compiler.Common
{
    /// <summary>
    ///   Base class for all scopes, contains the properties and methods necesary
    ///   to create the trees.
    /// </summary>
    /// <typeparam name = "T"></typeparam>
    public abstract class ScopeBase<T>
    {
        private readonly List<ScopeBase<T>> _childs = new List<ScopeBase<T>>();

        protected IEnumerable<ScopeBase<T>> Childs
        {
            get { return _childs; }
        }

        public ScopeBase<T> Parent { get; private set; }

        /// <summary>
        /// returns a child of the current scope. The method <see cref="Create"/>
        /// must be ovewritten.
        /// </summary>
        /// <returns></returns>
        public ScopeBase<T> GetChild()
        {
            ScopeBase<T> child = Create();

            // set the child parent
            child.Parent = this;

            _childs.Add(child);

            return child;
        }

        /// <summary>
        ///   returns a new instance of the current scope
        /// </summary>
        /// <returns></returns>
        protected abstract ScopeBase<T> Create();
    }
}