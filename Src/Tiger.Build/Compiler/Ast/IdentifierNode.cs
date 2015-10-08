using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    /// <summary>
    /// variable names, function parameters, 
    /// </summary>
    public class IdentifierNode : Node
    {
        #region Ast members

        public string Name { get; set; }

        #endregion

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            // the identifier shouldn't be a keyword
            astHelper.Errors.Check(new IdentifierExpectedError(Name, Start));
        }
    }

    /// <summary>
    /// used to represent a variable name or a function name, checks that no other
    /// members are declared with the same name.
    /// </summary>
    public class MemberIdentifierNode : IdentifierNode
    {
        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            astHelper.Errors.Check(new MemberWithSameNameAlreadyDefinedError(Name, astHelper, Start));
        }
    }

    /// <summary>
    /// represents a type name, checks that there aren't other types with 
    /// the same name in the local scope
    /// </summary>
    public class TypeIdentifierNode : IdentifierNode
    {
        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            astHelper.Errors.Check(new TypeWithSameNameAlreadyDefinedError(Name, astHelper.Types, Start));
        }
    }
}