using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

namespace Tiger.Build.Compiler.Common
{
    public static class ExpressionExtensors
    {
        public static UnaryExpression Not(this Expression expression)
        {
            return Expression.Not(expression);
        }

        public static UnaryExpression Convert<T>(this Expression expression)
        {
            return Expression.Convert(expression, typeof (T));
        }

        public static InvocationExpression eInvoke(this Expression expression, params Expression[] arguments)
        {
            return Expression.Invoke(expression, arguments);
        }

        public static InvocationExpression eInvoke(this Expression expression, IEnumerable<Expression> arguments)
        {
            return Expression.Invoke(expression, arguments);
        }

        public static BinaryExpression eEqual(this Expression left, Expression right)
        {
            return Expression.Equal(left, right);
        }

        public static BinaryExpression eGreaterThan(this Expression left, Expression right)
        {
            return Expression.GreaterThan(left, right);
        }

        public static BinaryExpression eLessThan(this Expression left, Expression right)
        {
            return Expression.LessThan(left, right);
        }

        public static BinaryExpression eGreaterThanOrEqual(this Expression left, Expression right)
        {
            return Expression.GreaterThanOrEqual(left, right);
        }

        public static BinaryExpression eAndAlso(this Expression left, Expression right)
        {
            return Expression.AndAlso(left, right);
        }

        public static BinaryExpression eOrElse(this Expression left, Expression right)
        {
            return Expression.OrElse(left, right);
        }

        public static BinaryExpression eAdd(this Expression left, Expression right)
        {
            return Expression.Add(left, right);
        }

        public static BinaryExpression eAddAssign(this Expression left, Expression right)
        {
            return Expression.AddAssign(left, right);
        }

        public static BinaryExpression eSubtract(this Expression left, Expression right)
        {
            return Expression.Subtract(left, right);
        }

        public static BinaryExpression eSubtractAssign(this Expression left, Expression right)
        {
            return Expression.SubtractAssign(left, right);
        }

        public static BinaryExpression eDivide(this Expression left, Expression right)
        {
            return Expression.Divide(left, right);
        }

        public static BinaryExpression eDivideAssign(this Expression left, Expression right)
        {
            return Expression.DivideAssign(left, right);
        }

        public static BinaryExpression eModulo(this Expression left, Expression right)
        {
            return Expression.Modulo(left, right);
        }

        public static BinaryExpression eModuloAssign(this Expression left, Expression right)
        {
            return Expression.ModuloAssign(left, right);
        }

        public static BinaryExpression eMultiply(this Expression left, Expression right)
        {
            return Expression.Multiply(left, right);
        }

        public static BinaryExpression eMultiplyAssign(this Expression left, Expression right)
        {
            return Expression.MultiplyAssign(left, right);
        }

        public static BinaryExpression eLeftShift(this Expression left, Expression right)
        {
            return Expression.LeftShift(left, right);
        }

        public static BinaryExpression eLeftShiftAssign(this Expression left, Expression right)
        {
            return Expression.LeftShiftAssign(left, right);
        }

        public static BinaryExpression eRightShift(this Expression left, Expression right)
        {
            return Expression.RightShift(left, right);
        }

        public static BinaryExpression eRightShiftAssign(this Expression left, Expression right)
        {
            return Expression.RightShiftAssign(left, right);
        }

        public static BinaryExpression eAnd(this Expression left, Expression right)
        {
            return Expression.And(left, right);
        }

        public static BinaryExpression eAndAssign(this Expression left, Expression right)
        {
            return Expression.AndAssign(left, right);
        }

        public static BinaryExpression eOr(this Expression left, Expression right)
        {
            return Expression.Or(left, right);
        }

        public static BinaryExpression eOrAssign(this Expression left, Expression right)
        {
            return Expression.OrAssign(left, right);
        }

        public static BinaryExpression eExclusiveOr(this Expression left, Expression right)
        {
            return Expression.ExclusiveOr(left, right);
        }

        public static BinaryExpression eExclusiveOr(this Expression left, Expression right, MethodInfo method)
        {
            return Expression.ExclusiveOr(left, right);
        }

        public static BinaryExpression eExclusiveOrAssign(this Expression left, Expression right)
        {
            return Expression.ExclusiveOrAssign(left, right);
        }

        public static BinaryExpression ePower(this Expression left, Expression right)
        {
            return Expression.Power(left, right);
        }

        public static BinaryExpression ePowerAssign(this Expression left, Expression right)
        {
            return Expression.PowerAssign(left, right);
        }

        public static UnaryExpression eNegate(this Expression expression)
        {
            return Expression.Negate(expression);
        }

        public static UnaryExpression eUnaryPlus(this Expression expression)
        {
            return Expression.UnaryPlus(expression);
        }

        public static UnaryExpression eNegateChecked(this Expression expression)
        {
            return Expression.NegateChecked(expression);
        }


        public static UnaryExpression eIsFalse(this Expression expression)
        {
            return Expression.IsFalse(expression);
        }

        public static UnaryExpression eIsTrue(this Expression expression)
        {
            return Expression.IsTrue(expression);
        }

        public static UnaryExpression eOnesComplement(this Expression expression)
        {
            return Expression.OnesComplement(expression);
        }

        public static UnaryExpression eTypeAs(this Expression expression, Type type)
        {
            return Expression.TypeAs(expression, type);
        }

        public static UnaryExpression eUnbox(this Expression expression, Type type)
        {
            return Expression.Unbox(expression, type);
        }

        public static UnaryExpression Unbox<T>(this Expression expression)
        {
            return Expression.Unbox(expression, typeof (T));
        }

        public static UnaryExpression eConvert(this Expression expression, Type type)
        {
            return Expression.Convert(expression, type);
        }

        public static UnaryExpression eArrayLength(this Expression array)
        {
            return Expression.ArrayLength(array);
        }

        public static UnaryExpression eQuote(this Expression expression)
        {
            return Expression.Quote(expression);
        }

        public static UnaryExpression eThrow(this Expression value)
        {
            return Expression.Throw(value);
        }

        public static UnaryExpression eThrow(this Expression value, Type type)
        {
            return Expression.Throw(value, type);
        }

        public static UnaryExpression eIncrement(this Expression expression)
        {
            return Expression.Increment(expression);
        }

        public static UnaryExpression eDecrement(this Expression expression)
        {
            return Expression.Decrement(expression);
        }

        public static UnaryExpression ePreIncrementAssign(this Expression expression)
        {
            return Expression.PreIncrementAssign(expression);
        }

        public static UnaryExpression ePreDecrementAssign(this Expression expression)
        {
            return Expression.PreDecrementAssign(expression);
        }

        public static UnaryExpression ePostIncrementAssign(this Expression expression)
        {
            return Expression.PostIncrementAssign(expression);
        }

        public static UnaryExpression ePostDecrementAssign(this Expression expression)
        {
            return Expression.PostDecrementAssign(expression);
        }
    }
}