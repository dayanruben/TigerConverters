using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Ast
{
    public abstract class Node
    {
        private SourceLocation _start = SourceLocation.Invalid;

        public virtual SourceLocation Start
        {
            get { return _start; }
            set { _start = value; }
        }

        /// <summary>
        ///   this method is executed before the generation, should
        ///   resolve all variable references and populate the scopes.
        ///   If some error is found the error should be added to the
        ///   collection.
        /// </summary>
        /// <param name = "astHelper"></param>
        protected internal virtual void CheckSemantics(AstHelper astHelper)
        {
            // todo refactor the ModuleBuilder and the ErrorSet as parameters of CheckSemantic
        }
    }
}