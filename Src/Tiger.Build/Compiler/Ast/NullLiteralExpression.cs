using System;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class NullLiteralExpression : Expression
    {
        private Expecting _expecting;

        public override Type Type
        {
            get { return typeof (Null); }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            _expecting = astHelper.Expecting;
        }

        protected internal override MAst Transform()
        {
            return _expecting.IsExpectingType
                       ? _expecting.Type == typeof (bool)
                             ? MAst.Constant(false, typeof (bool))
                             : MAst.Constant(null, _expecting.Type)
                       : MAst.Constant(null);
        }
    }

    public sealed class Null
    {
    }
}