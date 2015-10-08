using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;

namespace Tiger.Build.Compiler.Common
{
    public class Scope
    {
        // Fields
        private readonly Dictionary<string, LambdaExpression> _func;
        private readonly ModuleBuilder _moduleBuilder;
        private readonly Dictionary<string, Type> _types;
        private readonly Dictionary<string, ParameterExpression> _vars;

        public Scope()
        {
            _vars = new Dictionary<string, ParameterExpression>();
            _types = new Dictionary<string, Type>();
            _func = new Dictionary<string, LambdaExpression>();
        }

        public Scope(ModuleBuilder moduleBuilder)
        {
            _vars = new Dictionary<string, ParameterExpression>();
            _types = new Dictionary<string, Type>();
            _func = new Dictionary<string, LambdaExpression>();
            _moduleBuilder = moduleBuilder;
        }

        public Scope(Scope parent) : this()
        {
            Parent = parent;
        }

        public Scope Parent { get; set; }

        public IEnumerable<ParameterExpression> Variables
        {
            get
            {
                foreach (ParameterExpression v in _vars.Values)
                    yield return v;
                if (Parent != null)
                    foreach (ParameterExpression v in Parent.Variables)
                        yield return v;
            }
        }

        public void AddFunc(string key, LambdaExpression value)
        {
            _func.Add(key, value);
        }

        public void AddType(string key, Type value)
        {
            _types.Add(key, value);
        }

        public void AddVar(string key, ParameterExpression value)
        {
            _vars.Add(key, value);
        }

        public bool ContainsFunc(string key)
        {
            if (_func.ContainsKey(key))
            {
                return true;
            }
            if (Parent == null)
            {
                throw new ArgumentException(string.Format("key {0} was not found", key), "key");
            }
            return Parent.ContainsFunc(key);
        }

        public bool ContainsParameter(string key)
        {
            return _vars.ContainsKey(key);
        }

        public bool ContainsType(string key)
        {
            return _types.ContainsKey(key);
        }

        public LambdaExpression GetFunc(string key)
        {
            if (_func.ContainsKey(key))
            {
                return _func[key];
            }
            if (Parent == null)
            {
                throw new ArgumentException(string.Format("key {0} was not found", key), "key");
            }
            return Parent.GetFunc(key);
        }

        public ParameterExpression GetParam(string key)
        {
            if (_vars.ContainsKey(key))
            {
                return _vars[key];
            }
            return Parent.GetParam(key);
        }

        public Type GetType(IEnumerable<string> typePath)
        {
            return GetType(typePath.Last());
        }

        public Type GetType(string key)
        {
            if (_types.ContainsKey(key))
            {
                return _types[key];
            }
            return Parent.GetType(key);
        }

        public bool TryGetValue(string key, out ParameterExpression value)
        {
            return _vars.TryGetValue(key, out value);
        }

        public TypeBuilder TypeBuilder(string name)
        {
            if (_moduleBuilder == null)
            {
                return Parent.TypeBuilder(name);
            }
            return _moduleBuilder.DefineType(name);
        }

        // Properties
    }
}