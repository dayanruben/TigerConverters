using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection.Emit;
using Tiger.Build.Compiler.Common;

namespace Tiger.Build.Compiler.Ast
{
    using MAst = System.Linq.Expressions.Expression;

    public class AstHelper
    {
        private AstHelper()
        {
        }

        public AstHelper(ModuleBuilder moduleBuilder)
        {
            ModuleBuilder = moduleBuilder;
            Expecting = new Expecting();
            Functions = new FunctionScope();
            Variables = new VariableScope();
            Types = new TypeScope();
            Errors = new ErrorSet();

            ReturnScope = new ReturnScope();
        }

        public LoopScope LoopScope { get; private set; }

        public ReturnScope ReturnScope { get; set; }

        /// <summary>
        /// when an assignment is found then this property is setted if 
        /// the variable...
        /// </summary>
        public Expecting Expecting { get; private set; }

        public FunctionScope Functions { get; private set; }

        public VariableScope Variables { get; private set; }

        public TypeScope Types { get; private set; }

        public ErrorSet Errors { get; private set; }

        public ModuleBuilder ModuleBuilder { get; private set; }

        public AstHelper CreateChild(bool function = false, bool variables = false, bool types = false,
                                     bool expecting = false, Type expectedType = null,
                                     bool loop = false, LabelTarget breakLabel = null, LabelTarget continueLabel = null,
                                     bool returning = false, LabelTarget returnLabel = null)
        {
            var result = new AstHelper
                {
                    ModuleBuilder = ModuleBuilder,
                    Errors = Errors,
                    Expecting = expecting
                                    ? expectedType != null ? new Expecting(expectedType) : new Expecting()
                                    : Expecting,
                    Functions = function ? (FunctionScope) Functions.GetChild() : Functions,
                    Variables = variables
                                    ? (VariableScope) Variables.GetChild()
                                    : Variables,
                    Types = types ? (TypeScope) Types.GetChild() : Types,
                    LoopScope = loop ? new LoopScope(breakLabel, continueLabel) : LoopScope,
                    ReturnScope = returning ? new ReturnScope(returnLabel) : ReturnScope
                };

            return result;
        }

        public static AstHelper Default(ModuleBuilder moduleBuilder)
        {
            var result = new AstHelper(moduleBuilder);

            result.Types.Add("int", typeof (int));
            result.Types.Add("string", typeof (string));
            result.Types.Add("bool", typeof (bool));

            Expression<Func<int, string>> str = a => a.ToString(CultureInfo.InvariantCulture);
            result.Functions.Add("str", new FunctionReference(str, typeof (string), typeof (int)));

            // function ord(s : string) : int
            // Return the ASCII value of the first character of s, or 1 if s is empty.
            Expression<Func<string, int>> ord = a => string.IsNullOrEmpty(a) ? -1 : (int) a[0];
            result.Functions.Add("ord", new FunctionReference(ord, typeof (int), typeof (string)));

            // function chr(i : int) : string
            // Return a single-character string for ASCII value i. Terminate program if i is out of range.
            // todo when chr is called terminate the program if i is out of range
            Expression<Func<int, string>> chr = a => ((char) a).ToString();
            result.Functions.Add("chr", new FunctionReference(chr, typeof (string), typeof (int)));

            // function size(s : string) : int
            // Return the number of characters in s.
            Expression<Func<string, int>> size = a => a.Length;
            result.Functions.Add("size", new FunctionReference(size, typeof (int), typeof (string)));

            // function substring(s:string,f:int,n:int):string
            // Return the substring of s starting at the character f (first character is numbered zero) and going for n characters.
            Expression<Func<string, int, int, string>> substring = (s, f, n) => s.Substring(f, n);
            result.Functions.Add("substring",
                                 new FunctionReference(substring, typeof (int), typeof (string), typeof (int),
                                                       typeof (int)));

            // function concat (s1:string, s2:string):string
            // Return a new string consisting of s1 followed by s2.
            Expression<Func<string, string, string>> concat = (s1, s2) => s1 + s2;
            result.Functions.Add("concat", new FunctionReference(concat, typeof (string), typeof (string), typeof (string)));

            // function not(i : int) : int
            // Return 1 if i is zero, 0 otherwise.
            Expression<Func<int, int>> not = i => i == 0 ? 1 : 0;
            result.Functions.Add("not", new FunctionReference(not, typeof (int), typeof (int)));

            return result;
        }
    }

    public class ReturnScope
    {
        public ReturnScope()
        {
            IsInsideFunction = false;
        }

        public ReturnScope(LabelTarget returnLabel)
        {
            ReturnLabel = returnLabel;
            ReturnType = returnLabel.Type;
            IsInsideFunction = true;
        }

        public LabelTarget ReturnLabel { get; private set; }
        public Type ReturnType { get; private set; }

        public bool IsInsideFunction { get; private set; }
    }
}