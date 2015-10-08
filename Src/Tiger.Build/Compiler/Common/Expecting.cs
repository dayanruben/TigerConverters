using System;

namespace Tiger.Build.Compiler.Ast
{
    /// <summary>
    /// this class is used by <see cref="AstHelper"/> class.
    /// Every time an assignment or a comparison is done for one member,
    /// is expected that the next one types matches.
    /// </summary>
    public class Expecting
    {
        private bool _isExpectingType;
        private Type _type;

        public Expecting()
        {
        }

        public Expecting(Type type)
        {
            _isExpectingType = true;
            _type = type;
        }

        public Type Type
        {
            get { return _type; }
            set
            {
                if (_isExpectingType)
                    throw new InvalidOperationException("the type can only be setted once");

                if (value != null)
                {
                    _type = value;
                    _isExpectingType = true;
                }
            }
        }

        public bool IsExpectingType
        {
            get { return _isExpectingType; }
        }
    }
}