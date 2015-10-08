using System;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class OperatorNotDefinedError : ErrorBase
    {
        public OperatorNotDefinedError(Type left, Type right, TigerOperator @operator, SourceLocation location)
            : base(location)
        {
            Left = left;
            Right = right;
            Operator = @operator;
        }

        public Type Left { get; private set; }

        public TigerOperator Operator { get; private set; }

        public Type Right { get; private set; }

        public override bool IsActive
        {
            get
            {
                switch (Operator)
                {
                    case TigerOperator.AndAlso:
                        return Left == typeof (void) || Right == typeof (void);
                    case TigerOperator.OrElse:
                        return Left == typeof (void) || Right == typeof (void);
                    case TigerOperator.ExclusiveOr:
                        return Left == typeof (void) || Right == typeof (void);

                    case TigerOperator.LessThan:
                        return !TypeUtils.IsArithmetic(Left) || !TypeUtils.IsArithmetic(Right);
                    case TigerOperator.LessThanOrEqual:
                        return !TypeUtils.IsArithmetic(Left) || !TypeUtils.IsArithmetic(Right);
                    case TigerOperator.GreaterThan:
                        return !TypeUtils.IsArithmetic(Left) || !TypeUtils.IsArithmetic(Right);
                    case TigerOperator.GreaterThanOrEqual:
                        return !TypeUtils.IsArithmetic(Left) || !TypeUtils.IsArithmetic(Right);

                    case TigerOperator.Equal:
                        return Left == typeof (void) || Right == typeof (void);
                    case TigerOperator.NotEqual:
                        return Left == typeof (void) || Right == typeof (void);
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        protected override string GetMessage()
        {
            return string.Format("Can't apply operator {2} to types {1} and {0}", Left.Name, Right.Name,
                                 Operator.ToSymbol());
        }
    }
}