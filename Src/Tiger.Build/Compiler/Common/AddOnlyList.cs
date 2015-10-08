using System.Collections;
using System.Collections.Generic;

namespace Tiger.Build.Compiler.Ast
{
    public class AddOnlyList<T> : IEnumerable<T>
    {
        private readonly List<T> _storage = new List<T>();

        public int Count
        {
            get { return _storage.Count; }
        }

        public T this[int index]
        {
            get { return _storage[index]; }
            set { _storage[index] = value; }
        }

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            return _storage.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable) _storage).GetEnumerator();
        }

        #endregion

        public void Add(T item)
        {
            _storage.Add(item);
        }

        public void AddRange(IEnumerable<T> collection)
        {
            _storage.AddRange(collection);
        }
    }
}