using System;
using System.Collections.Generic;
using System.Linq;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class FunctionCallExpression : Expression
    {
        private MAst _pointer;
        private Type _type;

        #region Ast members

        public IdentifierNode FunctionName { get; set; }

        public IEnumerable<Expression> Parameters { get; set; }

        #endregion

        public override Type Type
        {
            get { return _type; }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            FunctionName.CheckSemantics(astHelper);

            foreach (Expression expression in Parameters)
                expression.CheckSemantics(astHelper);
            Type[] parameterTypes = Parameters.Select(param => param.Type).ToArray();

            if (!astHelper.Errors.Check(new FunctionNotDefinedError(FunctionName.Name, parameterTypes,
                                                                    astHelper.Functions, Start)))
            {
                FunctionReference functionReference = astHelper.Functions[FunctionName.Name, parameterTypes];

                _type = functionReference.ReturnType;
                _pointer = functionReference.Function;
            }
            else
            {
                // if there is any error
                _type = typeof (Null);
                _pointer = MAst.Empty();
            }
        }

        protected internal override MAst Transform()
        {
            return MAst.Invoke(_pointer,
                               from parameter in Parameters
                               select parameter.Transform());
        }
    }
}