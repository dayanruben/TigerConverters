using System;
using System.Collections.Generic;
using System.Linq;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class ArrayIndexExpression : MemberAccessExpression
    {
        public IEnumerable<Expression> Indexes { get; set; }

        public override Type Type
        {
            get { return Target.Type.GetElementType(); }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            Target.CheckSemantics(astHelper);

            foreach (Expression index in Indexes)
                index.CheckSemantics(astHelper);
        }

        protected internal override MAst Transform()
        {
            return MAst.ArrayAccess(Target.Transform(), from index in Indexes
                                                        select index.Transform());
        }
    }
}