namespace Tiger.Build.Compiler.Ast
{
    /// <summary>
    /// represents a node that has some information that should be added to
    /// the scope before calling Check semantic. Is used for recursive type
    /// definitions and recursive function calls.
    /// </summary>
    public interface IAddToScope
    {
        void AddToScope(AstHelper astHelper);
    }
}