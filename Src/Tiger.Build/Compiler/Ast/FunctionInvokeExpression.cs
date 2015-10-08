using System;
using System.Collections.Generic;
using System.Linq;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class FunctionInvokeExpression : Expression
    {
        #region Ast members

        public IdentifierNode FunctionName { get; set; }

        public IEnumerable<Expression> Args { get; set; }

        #endregion

        private FunctionReference _pointer;

        public FunctionInvokeExpression()
        {
            Args = Enumerable.Empty<Expression>();
        }

        public override Type Type
        {
            get { return _pointer != null ? _pointer.ReturnType : typeof (Null); }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            FunctionName.CheckSemantics(astHelper);

            // initialize the scopes for each one of the arguments
            var scopes = new AstHelper[Args.Count()];
            for (int i = 0; i < scopes.Length; scopes[i++] = astHelper.CreateChild(expecting: true))
            {
            }

            foreach (var item in Args.Zip(scopes, (arg, scope) => new {arg, scope}))
                item.arg.CheckSemantics(item.scope);

            Type[] argTypes = (from arg in Args select arg.Type).ToArray();

            if (astHelper.Errors.Check(new FunctionNotDefinedError(FunctionName.Name, argTypes, astHelper.Functions,
                                                                   Start))) return;

            _pointer = astHelper.Functions[FunctionName.Name, argTypes];

            // SPEC: The following are legal: function f(p:rec) = f(nil)
            // for that reason the expected type for each one of the arguments is the
            // type of the function argument (in the definition)
            foreach (var item in _pointer.ArgTypes.Zip(scopes, (type, scope) => new {type, scope}))
                item.scope.Expecting.Type = item.type;
        }

        protected internal override MAst Transform()
        {
            return MAst.Invoke(_pointer.Function, from arg in Args select arg.Transform());
        }
    }
}