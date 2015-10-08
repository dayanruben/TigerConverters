using System;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class IfThenElseExpression : IfThenExpression
    {
        #region Ast members

        public Expression Else { get; set; }

        #endregion

        public override Type Type
        {
            get
            {
                return Then.Type == typeof (Null)
                           ? Else.Type
                           : Then.Type;
            }
        }

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            Test.CheckSemantics(astHelper);

            // the if-then-else expression is expected to have a static type
            // for that reason it defines a new Expecting.Type scope
            AstHelper helper = astHelper.CreateChild(expecting: true);

            Then.CheckSemantics(helper);
            Else.CheckSemantics(helper);

            astHelper.Errors.Check(new ConditionalNotEquivalentTypes(Then.Type, Else.Type, Start));

            if (astHelper.Errors.Check(new CanNotInferTypeError(Then.Type, Else.Type, Start)))
                return;

            if (Then.Type == typeof (Null))
                helper.Expecting.Type = Else.Type;
            if (Else.Type == typeof (Null))
                helper.Expecting.Type = Then.Type;
        }

        protected internal override MAst Transform()
        {
            return MAst.Condition(Test.Transform(), Then.Transform(), Else.Transform());
        }
    }
}