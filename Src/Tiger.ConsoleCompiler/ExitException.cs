using System;

namespace Tiger.ConsoleCompiler
{
    public class ExitException : Exception
    {
        public ExitException() : this(0)
        {
        }

        public ExitException(int code)
        {
            Code = code;
        }

        public int Code { get; private set; }
    }
}