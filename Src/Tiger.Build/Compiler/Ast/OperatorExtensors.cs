using System;
using System.Collections.Generic;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Ast
{
    public static class OperatorExtensors
    {
        public static bool IsComparison(this TigerOperator @operator)
        {
            return new List<TigerOperator>
                {
                    TigerOperator.LessThan,
                    TigerOperator.LessThanOrEqual,
                    TigerOperator.GreaterThan,
                    TigerOperator.GreaterThanOrEqual,
                    TigerOperator.Equal,
                    TigerOperator.NotEqual,
                    TigerOperator.AndAlso,
                    TigerOperator.OrElse,
                    TigerOperator.ExclusiveOr
                }.Contains(@operator);
        }

        public static bool IsOperation(this TigerOperator @operator)
        {
            return new List<TigerOperator>
                {
                    TigerOperator.Add,
                    TigerOperator.Subtract,
                    TigerOperator.Multiply,
                    TigerOperator.Divide,
                    TigerOperator.Mod,
                    TigerOperator.Power
                }.Contains(@operator);
        }

        public static string ToSymbol(this TigerOperator @operator)
        {
            switch (@operator)
            {
                case TigerOperator.None:
                    break;
                case TigerOperator.Not:
                    return "not";
                case TigerOperator.Pos:
                    return "Pos";
                case TigerOperator.Invert:
                    return "Invert";
                case TigerOperator.Negate:
                    return "Negate";

                case TigerOperator.Add:
                    return "+";
                case TigerOperator.Subtract:
                    return "-";
                case TigerOperator.Multiply:
                    return "*";
                case TigerOperator.Divide:
                    return "/";

                case TigerOperator.TrueDivide:
                    return "TrueDivide";

                case TigerOperator.Mod:
                    return "%";

                case TigerOperator.BitwiseAnd:
                    return "BitwiseAnd";
                case TigerOperator.BitwiseOr:
                    return "BitwiseOr";
                case TigerOperator.Xor:
                    return "Xor";
                case TigerOperator.LeftShift:
                    return "<<";
                case TigerOperator.RightShift:
                    return ">>";
                case TigerOperator.Power:
                    return "**";
                case TigerOperator.FloorDivide:
                    return "FloorDivide";

                case TigerOperator.AndAlso:
                    return "&";
                case TigerOperator.OrElse:
                    return "|";
                case TigerOperator.LessThan:
                    return "<";
                case TigerOperator.LessThanOrEqual:
                    return "<=";
                case TigerOperator.GreaterThan:
                    return ">";
                case TigerOperator.GreaterThanOrEqual:
                    return ">=";
                case TigerOperator.Equal:
                    return "=";
                case TigerOperator.NotEqual:
                    return "<>";

                case TigerOperator.In:
                    return "In";
                case TigerOperator.NotIn:
                    return "NotIn";
                case TigerOperator.IsNot:
                    return "IsNot";
                case TigerOperator.Is:
                    return "Is";
                default:
                    throw new ArgumentOutOfRangeException("operator");
            }
            throw new ArgumentOutOfRangeException("operator");
        }
    }
}