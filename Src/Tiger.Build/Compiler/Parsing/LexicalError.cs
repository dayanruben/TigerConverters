using Antlr.Runtime;

namespace Tiger.Build.Compiler.Parsing
{
    public class LexicalError
    {
        private string _message;

        public LexicalError(RecognitionException e)
        {
            ProcessException(e);
        }

        private void ProcessException(RecognitionException e)
        {
            _message = string.Format("({0},{1}) {2}", e.Line, e.CharPositionInLine, e);
        }

        public override string ToString()
        {
            return _message;
        }
    }
}