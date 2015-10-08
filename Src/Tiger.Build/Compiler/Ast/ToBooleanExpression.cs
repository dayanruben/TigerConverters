using System;
using System.Linq.Expressions;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;
using MAst = System.Linq.Expressions.Expression;

namespace Tiger.Build.Compiler.Ast
{
    public class ToBooleanExpression : Expression
    {
        private readonly Expression _innerExpression;

        public ToBooleanExpression(Expression innerExpression)
        {
            _innerExpression = innerExpression;
        }

        public ToBooleanExpression()
        {
        }

        public override SourceLocation Start
        {
            get { return _innerExpression.Start; }
            set { throw new NotSupportedException(); }
        }

        public Expression InnerExpression
        {
            get { return _innerExpression; }
        }

        #region Overrides of Expression

        public override Type Type
        {
            get { return typeof (bool); }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            AstHelper helper = astHelper.CreateChild(expecting: true, expectedType: typeof (bool));
            _innerExpression.CheckSemantics(helper);

            // only void expressions can't be converted to bool
            astHelper.Errors.Check(new NotBoolConvertibleError(_innerExpression.Type, Start));
        }

        /// <summary>
        ///   Transform as expression (value is read).
        /// </summary>
        protected internal override MAst Transform()
        {
            if (_innerExpression.Type == typeof (string))
            {
                Expression<Func<string, bool>> result = str => !string.IsNullOrEmpty(str);
                MAst arg = _innerExpression.Transform();
                UnaryExpression converted = arg.Convert<string>();

                return result.eInvoke(converted);
            }
            else if (_innerExpression.Type.IsValueType)
            {
                var zero = (ValueType) (Activator.CreateInstance(_innerExpression.Type));

                return MAst.NotEqual(_innerExpression.Transform(), MAst.Constant(zero, _innerExpression.Type));
            }
            else if (_innerExpression.Type == typeof (Null))
            {
                return MAst.Constant(false, typeof (bool));
            }
            else
            {
                Expression<Func<object, bool>> result = o => (o != null);
                MAst arg = _innerExpression.Transform();
                UnaryExpression converted = arg.Convert<object>();

                return result.eInvoke(converted);
            }
        }

        #endregion
    }
}