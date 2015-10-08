using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    /// <summary>
    /// represents an object initialization via the constructor
    /// </summary>
    public class NewExpression : Expression
    {
        #region Ast members

        public IEnumerable<Expression> Args { get; set; }

        public ConstructorInfo Constructor { get; set; }

        #endregion

        public NewExpression()
        {
            Args = Enumerable.Empty<Expression>();
        }

        public NewExpression(Type targetType) : this()
        {
            // use the parameter less constructor
            Constructor = targetType.GetConstructor(new Type[] {});
        }

        public override Type Type
        {
            get { return Constructor.DeclaringType; }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            foreach (var item in Args.Zip(Constructor.GetParameters().Select(parameter => parameter.ParameterType), (arg, type) => new {arg, type}))
            {
                AstHelper helper = astHelper.CreateChild(expecting: true, expectedType: item.type);
                item.arg.CheckSemantics(helper);
            }
        }

        protected internal override MAst Transform()
        {
            return MAst.New(Constructor, from arg in Args select arg.Transform());
        }
    }
}