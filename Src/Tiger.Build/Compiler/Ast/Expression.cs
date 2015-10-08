using System;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    /// <summary>
    ///   Represents expressions. Statements are considered special cases of expressions in AST class hierarchy.
    ///   Unlike syntactic expression a syntactic statement cannot be assigned to a left value.
    ///   However certain Ruby constructs (e.g. block-expression) allow to read the value of a statement. 
    ///   Usually such value is null (e.g. undef, alias, while/until statements), 
    ///   although some syntactic statements evaluate to a non-null value (e.g. if/unless-statements).
    /// </summary>
    public abstract class Expression : Node
    {
        public abstract Type Type { get; }

        /// <summary>
        ///   Transform as expression (value is read).
        /// </summary>
        protected internal abstract MAst Transform();

        /// <summary>
        /// Comverts the expression into the corresponding 
        /// <see cref="System.Linq.Expressions.Expression"/>
        /// </summary>
        /// <param name="runtime"></param>
        /// <returns></returns>
        /// <exception cref="SemanticException">if there is some semantic error in the tree</exception>
        public MAst Compile(AstHelper runtime)
        {
            AstHelper helper = runtime.CreateChild(function: true, variables: true, types: true);
            CheckSemantics(helper);

            if (helper.Errors.HasErrors)
            {
                throw new SemanticException(helper.Errors);
            }

            return Transform();
        }
    }
}