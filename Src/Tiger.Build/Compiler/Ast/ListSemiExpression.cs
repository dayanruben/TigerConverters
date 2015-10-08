using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class ListSemiExpression : Expression, IEnumerable<Expression>
    {
        #region Ast members

        private readonly List<Expression> _body = new List<Expression>();

        public IEnumerable<Expression> Body
        {
            get { return _body; }
        }

        public void Add(Expression expression)
        {
            _body.Add(expression);
        }

        #endregion

        public ListSemiExpression()
        {
        }

        public ListSemiExpression(IEnumerable<Expression> expressions)
        {
            _body.AddRange(expressions);
        }

        public override Type Type
        {
            get { return Body.Select(item => item.Type).DefaultIfEmpty(typeof (void)).Last(); }
        }

        #region IEnumerable<Expression> Members

        public IEnumerator<Expression> GetEnumerator()
        {
            return Body.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            foreach (Expression expression in Body)
                expression.CheckSemantics(astHelper);
        }

        protected internal override MAst Transform()
        {
            return MAst.Block(from expression in Body.DefaultIfEmpty(new EmptyExpression())
                              select expression.Transform());
        }
    }
}