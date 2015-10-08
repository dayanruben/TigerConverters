using System;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class FieldAccessExpression : MemberAccessExpression
    {
        #region Ast members

        public IdentifierNode FieldName { get; set; }

        #endregion

        private Type _type;

        public override Type Type
        {
            get { return _type; }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);
            FieldName.CheckSemantics(astHelper);

            var error = new FieldNotFoundError(Target.Type, FieldName.Name, Start);
            _type = !astHelper.Errors.Check(error)
                        ? error.PropertyType
                        : typeof (Null);
        }

        protected internal override MAst Transform()
        {
            return MAst.PropertyOrField(Target.Transform(), FieldName.Name);
        }
    }
}