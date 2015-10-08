using System;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Ast
{
    public class ArrayInitializationExpression : Expression
    {
        protected Type OriginalType { get; set; }

        public override Type Type
        {
            get { return ArrayTypeName.ReferencedType; }
        }

        #region Ast members

        public TypeReferenceNode ArrayTypeName { get; set; }

        public Expression Lenght { get; set; }

        #endregion

        protected internal override void CheckSemantics(AstHelper astHelper)
        {
            base.CheckSemantics(astHelper);

            ArrayTypeName.CheckSemantics(astHelper);
            // type must be an array: type XX = array of ...
            astHelper.Errors.Check(new NotAnArrayTypeError(Type, Start));

            OriginalType = Type.GetElementType();

            Lenght.CheckSemantics(astHelper);

            astHelper.Errors.Check(new TypeMismatchedError(Lenght.Type, typeof (int), Start));
        }

        protected internal override System.Linq.Expressions.Expression Transform()
        {
            return System.Linq.Expressions.Expression.NewArrayBounds(OriginalType, Lenght.Transform());
        }
    }
}