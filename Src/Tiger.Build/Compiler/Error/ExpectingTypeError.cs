using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class ExpectingTypeError : ErrorBase
    {
        private readonly Expecting _expecting;

        public ExpectingTypeError(SourceLocation location, Expecting expecting) : base(location)
        {
            _expecting = expecting;
        }

        #region Overrides of ErrorBase

        public override bool IsActive
        {
            get { return _expecting.IsExpectingType; }
        }

        /// <summary>
        ///   Returns the message corresponding to this error
        /// </summary>
        /// <returns></returns>
        protected override string GetMessage()
        {
            return string.Format("The current expression do not return a value");
        }

        #endregion
    }
}