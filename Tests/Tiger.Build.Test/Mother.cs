// Developed by doiTTeam => devdoiTTeam@gmail.com

using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using Antlr.Runtime;
using NUnit.Framework;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Parsing;
using Expression = System.Linq.Expressions.Expression;

namespace Tiger.Build.Test
{
    public static class Mother
    {
        public static TigerParser CreateParser(string program)
        {
            var stream = new ANTLRStringStream(program);
            var lexer = new TigerLexer(stream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new TigerParser(tokens);

            return parser;
        }

        public static void Test<T>(string program, T expectedResult)
        {
            var result = Eval<T>(program);
            Assert.AreEqual(expectedResult, result);
        }

        public static void Test<T>(Expression program, T expectedResult)
        {
            var result = Eval<T>(program);
            Assert.AreEqual(expectedResult, result);
        }

        public static T Eval<T>(string program)
        {
            Expression expression = Compile(program);
            return Eval<T>(expression);
        }

        public static Expression Compile(string program)
        {
            var assemblyName = new AssemblyName(Guid.NewGuid().ToString()) {Version = new Version(1, 0)};
            AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName,
                                                                                            AssemblyBuilderAccess.Run);
            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("Program");

            AstHelper runtime = CreateRuntime(moduleBuilder);
            return ProgramExpression.Compile(runtime, program);
        }

        public static T Eval<T>(this Expression expression)
        {
            Expression<Func<T>> lamda = Expression.Lambda<Func<T>>(expression);
            T result = lamda.Compile()();
            return result;
        }

        public static AstHelper CreateRuntime(ModuleBuilder module = null)
        {
            var result = new AstHelper(module);

            result.Types.Add("int", typeof (int));
            result.Types.Add("string", typeof (string));
            result.Types.Add("bool", typeof (bool));
            result.Types.Add("Person", typeof (Person));

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
            result.Functions.Add("concat",
                                 new FunctionReference(concat, typeof (string), typeof (string), typeof (string)));

            // function not(i : int) : int
            // Return 1 if i is zero, 0 otherwise.
            Expression<Func<int, int>> not = i => i == 0 ? 1 : 0;
            result.Functions.Add("not", new FunctionReference(not, typeof (int), typeof (int)));

            return result;
        }

        #region Nested type: Person

        public class Person
        {
            public int Age;
            public string Name;

            public bool Equals(Person other)
            {
                if (ReferenceEquals(null, other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return other.Age == Age && Equals(other.Name, Name);
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != typeof (Person)) return false;
                return Equals((Person) obj);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return (Age*397) ^ (Name != null ? Name.GetHashCode() : 0);
                }
            }
        }

        #endregion
    }
}