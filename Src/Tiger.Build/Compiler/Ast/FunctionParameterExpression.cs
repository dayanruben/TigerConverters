using System;
using System.Linq.Expressions;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class FunctionParameterExpression : Expression, IAddToScope
    {
        private ParameterExpression _parameter;

        #region Ast members

        public IdentifierNode Name { get; set; }

        public TypeReferenceNode TypeName { get; set; }

        #endregion

        public override Type Type
        {
            get { return TypeName.ReferencedType; }
        }

        #region IAddToScope Members

        public void AddToScope(AstHelper astHelper)
        {
            if (!astHelper.Errors.Check(new MemberWithSameNameAlreadyDefinedError(Name.Name, astHelper, Start)))
                astHelper.Variables.Add(Name.Name, _parameter);
        }

        #endregion

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            TypeName.CheckSemantics(astHelper);
            Name.CheckSemantics(astHelper);

            _parameter = MAst.Parameter(Type);
        }

        /// <summary>
        ///   returns the parameter expression that this function represents
        /// </summary>
        /// <returns></returns>
        protected internal override MAst Transform()
        {
            return _parameter;
        }
    }
}