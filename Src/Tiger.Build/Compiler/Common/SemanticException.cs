using System;
using System.Collections.Generic;
using System.Linq;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Compiler.Common
{
    public class SemanticException : Exception
    {
        private readonly ErrorSet _errors;

        public SemanticException(ErrorSet errors)
        {
            _errors = errors;
        }

        public IEnumerable<ErrorBase> Errors
        {
            get { return _errors; }
        }

        public override string Message
        {
            get
            {
                return "The file has some semantic errors:" +
                       _errors.Aggregate("", (current, next) => current + "\n" + next.ToString());
            }
        }

        public override string ToString()
        {
            return "The file has some errors: \n" +
                   _errors.Aggregate("", (current, next) => current + "\n" + next.Message);
        }
    }
}