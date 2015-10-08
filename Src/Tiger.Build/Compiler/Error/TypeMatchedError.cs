using System;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class TypeMatchedError : ErrorBase
    {
        private readonly Type _expected;
        private readonly Type _type;

        public TypeMatchedError(Type type, Type expected, SourceLocation location) : base(location)
        {
            _type = type;
            _expected = expected;
        }

        public Type Type
        {
            get { return _type; }
        }

        public Type Expected
        {
            get { return _expected; }
        }

        #region Overrides of ErrorBase

        public override bool IsActive
        {
            get { return TypeUtils.AreEquivalent(_type, _expected); }
        }

        /// <summary>
        ///   Returns the message corresponding to this error
        /// </summary>
        /// <returns></returns>
        protected override string GetMessage()
        {
            return string.Format("The expression can't be {0}", _type.Name);
        }

        #endregion
    }
}