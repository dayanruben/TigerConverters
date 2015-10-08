using System;
using System.Diagnostics.CodeAnalysis;

namespace Tiger.Build.Compiler.Common
{
    /// <summary>
    ///   Represents a location in source code.
    /// </summary>
    [Serializable]
    public struct SourceLocation
    {
        /// <summary>
        ///   A location that is valid but represents no location at all.
        /// </summary>
        public static readonly SourceLocation None = new SourceLocation(0xfeefee, 0, true);

        /// <summary>
        ///   An invalid location.
        /// </summary>
        public static readonly SourceLocation Invalid = new SourceLocation(0, 0, true);

        /// <summary>
        ///   A minimal valid location.
        /// </summary>
        public static readonly SourceLocation MinValue = new SourceLocation(1, 1);

        private readonly int _column;

        private readonly int _line;

        /// <summary>
        ///   Creates a new source location.
        /// </summary>
        /// <param name = "index">The index in the source stream the location represents (0-based).</param>
        /// <param name = "line">The line in the source stream the location represents (1-based).</param>
        /// <param name = "column">The column in the source stream the location represents (1-based).</param>
        public SourceLocation(int line, int column)
        {
            ValidateLocation(line, column);

            _line = line;
            _column = column;
        }

        [SuppressMessage("Microsoft.Usage", "CA1801:ReviewUnusedParameters")]
        private SourceLocation(int line, int column, bool noChecks)
        {
            _line = line;
            _column = column;
        }

        /// <summary>
        ///   The line in the source stream the location represents (1-based).
        /// </summary>
        public int Line
        {
            get { return _line; }
        }

        /// <summary>
        ///   The column in the source stream the location represents (1-based).
        /// </summary>
        public int Column
        {
            get { return _column; }
        }

        /// <summary>
        ///   Whether the location is a valid location.
        /// </summary>
        /// <returns>True if the location is valid, False otherwise.</returns>
        public bool IsValid
        {
            get { return _line != 0 && _column != 0; }
        }

        private static void ValidateLocation(int line, int column)
        {
            if (line < 0)
            {
                throw ErrorOutOfRange("line", 0);
            }
            if (column < 0)
            {
                throw ErrorOutOfRange("column", 0);
            }
        }

        private static Exception ErrorOutOfRange(object p0, object p1)
        {
            return new ArgumentOutOfRangeException(string.Format("{0} must be greater than or equal to {1}", p0, p1));
        }

        /// <summary>
        ///   Compares two specified location values to see if they are equal.
        /// </summary>
        /// <param name = "left">One location to compare.</param>
        /// <param name = "right">The other location to compare.</param>
        /// <returns>True if the locations are the same, False otherwise.</returns>
        public static bool operator ==(SourceLocation left, SourceLocation right)
        {
            return left._line == right._line && left._column == right._column;
        }

        /// <summary>
        ///   Compares two specified location values to see if they are not equal.
        /// </summary>
        /// <param name = "left">One location to compare.</param>
        /// <param name = "right">The other location to compare.</param>
        /// <returns>True if the locations are not the same, False otherwise.</returns>
        public static bool operator !=(SourceLocation left, SourceLocation right)
        {
            return left._line != right._line || left._column != right._column;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is SourceLocation)) return false;

            var other = (SourceLocation) obj;
            return other._line == _line && other._column == _column;
        }

        public override int GetHashCode()
        {
            return (_line << 16) ^ _column;
        }

        public override string ToString()
        {
            return "(" + _line + "," + _column + ")";
        }
    }
}