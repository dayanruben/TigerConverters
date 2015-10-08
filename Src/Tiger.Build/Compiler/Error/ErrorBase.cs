using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public abstract class ErrorBase
    {
        protected ErrorBase(SourceLocation location)
        {
            Location = location;
        }

        public SourceLocation Location { get; set; }

        public int Line
        {
            get { return Location.Line; }
        }

        public int Col
        {
            get { return Location.Column; }
        }

        public string Message
        {
            get { return string.Format("({0},{1}) {2}.", Line, Col, GetMessage()); }
        }

        public abstract bool IsActive { get; }

        public override string ToString()
        {
            return Message;
        }

        /// <summary>
        ///   Returns the message corresponding to this error
        /// </summary>
        /// <returns></returns>
        protected abstract string GetMessage();
    }
}