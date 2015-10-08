using System;

namespace Tiger.Build.Compiler.Ast
{
    public class IntLiteralExpression : Expression
    {
        private readonly int _value;

        public IntLiteralExpression(int value)
        {
            _value = value;
        }

        public IntLiteralExpression(string value) : this(int.Parse(value))
        {
        }

        public override Type Type
        {
            get { return typeof (int); }
        }

        protected internal override System.Linq.Expressions.Expression Transform()
        {
            return System.Linq.Expressions.Expression.Constant(_value);
        }
    }
}