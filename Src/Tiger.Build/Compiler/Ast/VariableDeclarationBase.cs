using System;
using System.Linq.Expressions;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    /// <summary>
    /// Represents a variable declaration without default value
    /// </summary>
    public class VariableDeclarationBase : Expression
    {
        public MemberIdentifierNode VariableName { get; set; }
        public TypeReferenceNode VariableTypeName { get; set; }

        public ParameterExpression Pointer { get; set; }

        public override Type Type
        {
            get { return VariableTypeName.ReferencedType; }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            VariableName.CheckSemantics(astHelper);
            VariableTypeName.CheckSemantics(astHelper);

            bool memberDeclared = astHelper.Errors.Check(new MemberWithSameNameAlreadyDefinedError(VariableName.Name, astHelper, Start));

            if (!memberDeclared)
            {
                Pointer = System.Linq.Expressions.Expression.Parameter(Type, VariableName.Name);

                astHelper.Variables.Add(VariableName.Name, Pointer);
            }
        }

        protected internal override System.Linq.Expressions.Expression Transform()
        {
            return System.Linq.Expressions.Expression.Empty();
        }
    }
}