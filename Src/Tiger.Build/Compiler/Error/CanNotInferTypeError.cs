using System;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    /// <summary>
    /// when there is a context where the type of some expression can't be 
    /// determined, e.g. 'nil=nil', var a:=nil, etc
    /// </summary>
    public class CanNotInferTypeError : ErrorBase
    {
        private readonly Type _left;
        private readonly Type _right;

        public CanNotInferTypeError(Type left, Type right, SourceLocation location)
            : base(location)
        {
            _left = left;
            _right = right;
        }

        public override bool IsActive
        {
            get { return _left == typeof (Null) && _right == typeof (Null); }
        }

        protected override string GetMessage()
        {
            return "The expression type can't be determined, try specifying the type";
        }
    }
}