using System;
using System.Linq.Expressions;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    public class VariableAccessExpression : Expression
    {
        #region Ast members

        public string VariableName { get; set; }

        #endregion

        private ParameterExpression _pointer;
        private Type _type;

        public override Type Type
        {
            get { return _type; }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            if (!astHelper.Errors.Check(new IdentifierNotDefinedError(VariableName, astHelper.Variables, Start)))
            {
                _pointer = astHelper.Variables[VariableName];
                _type = _pointer.Type;
            }
            else
            {
                // if the variable isn't defined, apply the null type that can be assigned
                // to all the record types
                _type = astHelper.Expecting.IsExpectingType ? astHelper.Expecting.Type : typeof (Null);
            }
        }

        protected internal override System.Linq.Expressions.Expression Transform()
        {
            return _pointer;
        }
    }
}