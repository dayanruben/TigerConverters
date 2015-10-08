using System.Collections.Generic;
using Antlr.Runtime;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Parsing
{
    public partial class TigerParser
    {
        private readonly List<LexicalError> _errors = new List<LexicalError>();

        public IEnumerable<LexicalError> Errors
        {
            get { return _errors; }
        }

        public override void ReportError(RecognitionException e)
        {
            base.ReportError(e);
            _errors.Add(new LexicalError(e));
        }

        private static SourceLocation Loc(IToken token)
        {
            // token.CharPositionInLine is the zero based position
            return new SourceLocation(token.Line, token.CharPositionInLine + 1);
        }
    }
}