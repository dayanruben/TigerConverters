using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class StringLiteralExpression : Expression
    {
        private static readonly Expression<Func<string, object[], string>> _stringFormatExpression = (str, args) => string.Format(str, args);
        private readonly string _value;

        public StringLiteralExpression()
        {
            Args = Enumerable.Empty<Expression>();
        }

        public StringLiteralExpression(string value) : this()
        {
            _value = value.Substring(1, value.Length - 2);
        }

        public IEnumerable<Expression> Args { get; set; }

        public string Value
        {
            get { return _value; }
        }

        public override sealed Type Type
        {
            get { return typeof (string); }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            foreach (Expression arg in Args)
                arg.CheckSemantics(astHelper);
        }

        protected internal override MAst Transform()
        {
            ConstantExpression constant = MAst.Constant(_value, typeof (string));

            return Args.Count() == 0
                       ? (MAst) constant
                       : MAst.Invoke(_stringFormatExpression,
                                     constant,
                                     MAst.NewArrayInit(typeof (object), from arg in Args select arg.Transform().Convert<object>()));
        }
    }
}