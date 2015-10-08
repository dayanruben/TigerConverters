using System.Collections;
using System.Collections.Generic;

namespace Tiger.Build.Compiler.Ast
{
    /// <summary>
    ///   Represents a type reference
    /// </summary>
    public class TypePath : IEnumerable<string>
    {
        public string NameSpace { get; set; }

        public string TypeName { get; set; }

        #region IEnumerable<string> Members

        public IEnumerator<string> GetEnumerator()
        {
            yield break;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}