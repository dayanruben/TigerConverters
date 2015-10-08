using System;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class TypeCastExpression : Expression
    {
        public Expression Expression { get; set; }

        public Type TargetType { get; set; }

        public override Type Type
        {
            get { return TargetType; }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            Expression.CheckSemantics(astHelper);
        }

        protected internal override MAst Transform()
        {
            return MAst.Convert(Expression.Transform(), TargetType);
        }
    }
}