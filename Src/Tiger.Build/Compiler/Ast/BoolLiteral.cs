using System;

namespace Tiger.Build.Compiler.Ast
{
    public class BoolLiteral : Expression
    {
        private readonly bool _value;

        public BoolLiteral(bool value)
        {
            _value = value;
        }

        public override Type Type
        {
            get { return typeof (bool); }
        }

        protected internal override System.Linq.Expressions.Expression Transform()
        {
            return System.Linq.Expressions.Expression.Constant(_value);
        }
    }
}