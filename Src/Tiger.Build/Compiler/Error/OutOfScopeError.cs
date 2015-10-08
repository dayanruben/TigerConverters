using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class BreakOutOfLoopScopeError : ErrorBase
    {
        private readonly LoopScope _scope;

        public BreakOutOfLoopScopeError(SourceLocation location, LoopScope scope) : base(location)
        {
            _scope = scope;
        }

        #region Overrides of ErrorBase

        public override bool IsActive
        {
            get { return _scope == null; }
        }

        /// <summary>
        ///   Returns the message corresponding to this error
        /// </summary>
        /// <returns></returns>
        protected override string GetMessage()
        {
            return string.Format("The current break key word is out of a loop scope");
        }

        #endregion
    }

    public class ContinueOutOfLoopScopeError : ErrorBase
    {
        private readonly LoopScope _scope;

        public ContinueOutOfLoopScopeError(SourceLocation location, LoopScope scope)
            : base(location)
        {
            _scope = scope;
        }

        #region Overrides of ErrorBase

        public override bool IsActive
        {
            get { return _scope == null; }
        }

        /// <summary>
        ///   Returns the message corresponding to this error
        /// </summary>
        /// <returns></returns>
        protected override string GetMessage()
        {
            return string.Format("The current continue key word is out of a loop scope");
        }

        #endregion
    }
}