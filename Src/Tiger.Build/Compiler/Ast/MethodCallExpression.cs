using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class MethodCallExpression : MemberAccessExpression
    {
        #region Ast members

        public IdentifierNode MethodName { get; set; }

        public IEnumerable<Expression> Args { get; set; }

        #endregion

        private MethodInfo _methodInfo;

        public MethodCallExpression()
        {
            Args = Enumerable.Empty<Expression>();
        }

        public override Type Type
        {
            get { return _methodInfo.ReturnType; }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);
            MethodName.CheckSemantics(astHelper);
            foreach (Expression expression in Args) expression.CheckSemantics(astHelper);

            Type[] argTypes = (from arg in Args select arg.Type).ToArray();

            if (!astHelper.Errors.Check(new MethodNotFoundError(Target.Type, MethodName.Name, argTypes, Start)))
                _methodInfo = Target.Type.GetMethod(MethodName.Name, argTypes);
        }

        protected internal override MAst Transform()
        {
            return MAst.Call(Target.Transform(), _methodInfo, from arg in Args select arg.Transform());
        }
    }
}