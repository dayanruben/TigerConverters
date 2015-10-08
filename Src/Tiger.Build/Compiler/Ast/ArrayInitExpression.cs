using System;
using System.Collections.Generic;
using System.Linq;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class ArrayInitExpression : Expression
    {
        public IEnumerable<Expression> Initializers { get; set; }

        public override Type Type
        {
            get { return InnerType.MakeArrayType(); }
        }

        private Type InnerType { get; set; }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            AstHelper helper = astHelper.CreateChild(expecting: true);

            base.CheckSemantics(astHelper);

            // semantic for this items is checked before having a type for them
            // so after the array type is determined they must be checked
            var lateCheckItems = new List<Expression>();

            foreach (Expression initializer in Initializers)
            {
                initializer.CheckSemantics(helper);

                if (helper.Expecting.IsExpectingType)
                    helper.Errors.Check(new NotAssignableError(helper.Expecting.Type, initializer.Type, Start));
                else
                {
                    // the array type isn't determined yet
                    if (initializer.Type != typeof (Null))
                        helper.Expecting.Type = initializer.Type;
                    else
                        lateCheckItems.Add(initializer);
                }
            }

            if (helper.Expecting.IsExpectingType)
            {
                InnerType = helper.Expecting.Type;

                // check that all types are assignable to the array type
                foreach (Expression lateCheckItem in lateCheckItems)
                    helper.Errors.Check(new NotAssignableError(helper.Expecting.Type, lateCheckItem.Type, Start));
            }
            else
            {
                // if the array doesn't have a type assign null to it
                InnerType = typeof (Null);
            }

            helper.Errors.Check(new CanNotInferArrayTypeError(Initializers.Select(i => i.Type), Start));
        }

        protected internal override MAst Transform()
        {
            return MAst.NewArrayInit(InnerType, from initializer in Initializers select initializer.Transform());
        }
    }
}