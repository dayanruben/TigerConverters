namespace Tiger.Build.Compiler.Ast
{
    /// <summary>
    /// used in the type declaration nodes when a type declaration references other types
    /// and circular references must be checked.
    /// </summary>
    public interface IReferenceType
    {
        TypeReferenceNode ExistingType { get; set; }
    }
}