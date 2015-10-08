using System;

namespace Tiger.Build.Compiler.Ast
{
    /// <summary>
    /// This class contains an expression that is used more than once in the
    /// tree, it makes sure that <see cref="Node.CheckSemantics"/> is called
    /// only once in the semantic phase.
    /// </summary>
    public class CheckSemanticOnlyOnceExpression : Expression
    {
        private bool _checkSemanticsCalled;
        public Expression Expression { get; set; }

        public override Type Type
        {
            get { return Expression.Type; }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            if (_checkSemanticsCalled) return;
            _checkSemanticsCalled = true;

            base.CheckSemantics(astHelper);
            Expression.CheckSemantics(astHelper);
        }

        protected internal override System.Linq.Expressions.Expression Transform()
        {
            return Expression.Transform();
        }
    }

    public static class CheckSemanticOnlyOnceExtensor
    {
        public static Expression ProtectSemantics(this Expression expression)
        {
            return new CheckSemanticOnlyOnceExpression() {Expression = expression, Start = expression.Start};
        }
    }
}