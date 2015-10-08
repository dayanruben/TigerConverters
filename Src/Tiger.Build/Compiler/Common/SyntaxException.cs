using System;
using System.Collections.Generic;
using System.Linq;

namespace Tiger.Build.Compiler.Common
{
    public class SyntaxException : Exception
    {
        public SyntaxException(IEnumerable<string> errors)
        {
            Errors = errors;
        }

        public SyntaxException(string message, Exception inner, IEnumerable<string> errors)
            : base(message, inner)
        {
            Errors = errors;
        }

        public IEnumerable<string> Errors { get; private set; }

        public override string Message
        {
            get
            {
                return Errors.Aggregate("",
                                        (current, next) => current + (!string.IsNullOrEmpty(current) ? "\n" : "") + next);
            }
        }
    }
}