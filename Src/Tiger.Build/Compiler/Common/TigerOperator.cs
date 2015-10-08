namespace Tiger.Build.Compiler.Common
{
    public enum TigerOperator
    {
        None,

        // Unary
        Not,
        Pos,
        Invert,
        Negate,

        // Binary
        Add,
        Subtract,
        Multiply,
        Divide,
        TrueDivide,
        Mod,
        BitwiseAnd,
        BitwiseOr,
        Xor,
        LeftShift,
        RightShift,
        Power,
        FloorDivide,

        AndAlso,
        OrElse,

        // Comparisons
        LessThan,
        LessThanOrEqual,
        GreaterThan,
        GreaterThanOrEqual,
        Equal,
        NotEqual,
        In,
        NotIn,
        IsNot,
        Is,

        // Aliases
        ExclusiveOr = Xor,
        Equals = Equal,
        NotEquals = NotEqual,

        PreIncrementAssign,
        PreDecrementAssign
    }
}