using System;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    /// <summary>
    /// returns the default value for the given type
    /// </summary>
    public class DefaultValueExpression : Expression
    {
        private readonly Type _targetType;

        public DefaultValueExpression(Type targetType)
        {
            _targetType = targetType;
        }

        public override Type Type
        {
            get { return _targetType; }
        }

        protected internal override MAst Transform()
        {
            return MAst.Default(Type);
        }
    }
}