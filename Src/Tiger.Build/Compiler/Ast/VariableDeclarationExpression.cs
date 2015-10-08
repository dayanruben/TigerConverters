using System;
using Tiger.Build.Compiler.Error;
using MAst = System.Linq.Expressions.Expression;

namespace Tiger.Build.Compiler.Ast
{
    public class VariableDeclarationExpression : VariableDeclarationBase
    {
        #region Ast members

        public Expression Value { get; set; }

        #endregion

        public VariableDeclarationExpression()
        {
            VariableTypeName = new TypeReferenceNode();
        }

        public override Type Type
        {
            get
            {
                // if there's a type defined, but the type isn't in the scope for some reason
                if (VariableTypeName.HasType && VariableTypeName.ReferencedType == null)
                    return Value.Type;

                return VariableTypeName.HasType
                           ? VariableTypeName.ReferencedType
                           : Value.Type;
            }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            VariableName.CheckSemantics(astHelper);
            VariableTypeName.CheckSemantics(astHelper);

            AstHelper childScope = VariableTypeName.HasType
                                       ? astHelper.CreateChild(expecting: true,
                                                               expectedType: VariableTypeName.ReferencedType)
                                       : astHelper.CreateChild(expecting: true);

            Value.CheckSemantics(childScope);

            bool cantInferType = astHelper.Errors.Check(new CanNotInferTypeError(Type, Value.Type, Start));
            astHelper.Errors.Check(new NotAssignableError(Type, Value.Type, Start));
            bool memberDeclared = astHelper.Errors.Check(
                new MemberWithSameNameAlreadyDefinedError(VariableName.Name, astHelper, Start));

            if (!memberDeclared)
            {
                if (!cantInferType)
                {
                    Pointer = MAst.Parameter(Type, VariableName.Name);
                }
                else
                {
                    // if the type can't be inferred then register the variable with null type
                    Pointer = MAst.Parameter(typeof (Null), VariableName.Name);
                }

                astHelper.Variables.Add(VariableName.Name, Pointer);
            }
        }

        /// <summary>
        ///   returns the assignation expression that should be executed before this variable is used
        /// </summary>
        /// <returns></returns>
        protected internal override MAst Transform()
        {
            // return an assignment expression to the parameter that should be called
            // before any uses of the variable

            MAst valueExpression = Value.Transform();
            return MAst.Assign(Pointer, valueExpression);
        }
    }
}