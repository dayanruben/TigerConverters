using System;
using System.Collections.Generic;
using System.Linq;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    /// <summary>
    /// used to check if the type of an array initialized giving it's
    /// values can be determined, [nil,nil,nil]
    /// </summary>
    public class CanNotInferArrayTypeError : ErrorBase
    {
        public CanNotInferArrayTypeError(IEnumerable<Type> itemTypes, SourceLocation location) : base(location)
        {
            ItemTypes = itemTypes;
        }

        public IEnumerable<Type> ItemTypes { get; private set; }

        public override bool IsActive
        {
            get
            {
                // is active if all items are null: [nil,nil,nil]
                return ItemTypes.All(type => type == typeof (Null));
            }
        }

        protected override string GetMessage()
        {
            return "The array type can't be determined";
        }
    }
}