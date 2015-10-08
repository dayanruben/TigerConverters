using System;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class CastExpression : Expression
    {
        #region Ast members

        public TypeReferenceNode TargetType { get; set; }

        public Expression Expression { get; set; }

        #endregion

        public override Type Type
        {
            get { return TargetType.ReferencedType; }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            TargetType.CheckSemantics(astHelper);
            Expression.CheckSemantics(astHelper);
        }

        protected internal override MAst Transform()
        {
            return MAst.Convert(Expression.Transform(), Type);
        }
    }
}