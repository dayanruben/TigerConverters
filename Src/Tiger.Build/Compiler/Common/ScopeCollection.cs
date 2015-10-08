using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Tiger.Build.Compiler.Common
{
    public class ScopeCollection<T> : ScopeBase<T>, IEnumerable<T>
    {
        private readonly Dictionary<string, T> _storage = new Dictionary<string, T>();

        public T this[string key]
        {
            get
            {
                if (_storage.ContainsKey(key))
                    return _storage[key];

                if (Parent != null)
                    return ((ScopeCollection<T>) Parent)[key];

                throw new KeyNotFoundException("The specified key wasn't found in the scope.");
            }
        }

        public IEnumerable<T> Locals
        {
            get { return _storage.Values; }
        }

        /// <summary>
        ///   returns all items in the scope tree starting with this scope as the root.
        /// </summary>
        public IEnumerable<T> GetAll
        {
            get { return this.Union(Childs.SelectMany(child => (ScopeCollection<T>) child)); }
        }

        #region IEnumerable<T> Members

        /// <summary>
        ///   Returns all items in this scope and from his parent
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            // return the items from it's parent
            if (Parent != null)
                foreach (T item in (ScopeCollection<T>) Parent)
                    yield return item;

            // and then return the items from this scope
            foreach (T item in _storage.Values)
                yield return item;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        protected void SetValue(string key, T value)
        {
            if (_storage.ContainsKey(key))
                _storage[key] = value;
            else
            {
                _storage.Add(key, value);
            }
        }

        public T GetLocal(string key)
        {
            if (_storage.ContainsKey(key))
                return _storage[key];

            throw new KeyNotFoundException("The specified key wasn't found in the scope.");
        }

        public void Add(string key, T value)
        {
            _storage.Add(key, value);

            OnItemAdded(new ItemAddedEventArgs<T>(value, key));
        }

        public bool Contains(string key)
        {
            return _storage.ContainsKey(key) || (Parent != null && ((ScopeCollection<T>) Parent).Contains(key));
        }

        public bool ContainsLocal(string key)
        {
            return _storage.ContainsKey(key);
        }

        public event EventHandler<ItemAddedEventArgs<T>> ItemAdded;

        protected void OnItemAdded(ItemAddedEventArgs<T> e)
        {
            EventHandler<ItemAddedEventArgs<T>> handler = ItemAdded;
            if (handler != null) handler(this, e);

            // notify all childs
            foreach (ScopeCollection<T> child in Childs)
                child.OnItemAdded(e);
        }

        protected override ScopeBase<T> Create()
        {
            return new ScopeCollection<T>();
        }
    }

    public class ItemAddedEventArgs<T> : EventArgs
    {
        public ItemAddedEventArgs(T item, string key)
        {
            Item = item;
            Key = key;
        }

        public T Item { get; private set; }

        public string Key { get; private set; }
    }
}