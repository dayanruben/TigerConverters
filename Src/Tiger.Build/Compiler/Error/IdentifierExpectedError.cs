using System.Collections.Generic;
using System.Linq;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Error
{
    public class IdentifierExpectedError : ErrorBase
    {
        private static readonly IEnumerable<string> _keyWords = new[]
            {
                "int", "string", "bool",
                "if", "then",
                "while", "for", "to", "do",
                "let", "in", "end",
                "type", "var", "array", "of", "function",
                "not",
                "true", "false",
                "break", "continue", "nil"
            };

        public IdentifierExpectedError(string identifier, SourceLocation location) : base(location)
        {
            Identifier = identifier;
        }

        public static IEnumerable<string> KeyWords
        {
            get { return _keyWords; }
        }

        public string Identifier { get; private set; }

        public override bool IsActive
        {
            get { return KeyWords.Contains(Identifier); }
        }

        protected override string GetMessage()
        {
            return string.Format("Identifier expected: '{0}' is a keyword.", Identifier);
        }
    }
}