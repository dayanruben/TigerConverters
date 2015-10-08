using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;
using Expression = System.Linq.Expressions.Expression;

namespace Tiger.ConsoleCompiler
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Tiger Compiler version 1.0";
            Console.WriteLine("Tiger Compiler version 1.0");
            Console.WriteLine("Copyright (C) 2011 - 2012 Ariel Rodriguez & Eric Hernandez & Dayan Gonzalez");

            FileInfo fi;
            if (args.Length == 0 || args[0] == "")
            {
                fi = new FileInfo(Environment.CurrentDirectory + "\\program.tig");
            }
            else
            {
                string path = args.Aggregate("", (current, s) => current + s);
                fi = new FileInfo(path);
            }

            if (!fi.Exists)
            {
                Console.WriteLine("(0, 0): File '{0}' cannot be found.", fi.FullName);
                Console.WriteLine();
                return;
            }
            string fileName = fi.Name.Substring(0, fi.Name.Length - 4);

            try
            {
                var assemblyName = new AssemblyName("Program");
                assemblyName.Version = new Version(1, 0);

                AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName,
                                                                                                AssemblyBuilderAccess.
                                                                                                    Save);

                ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("Program", "Program.exe");

                AstHelper runtime = CreateRuntime(moduleBuilder);

                TypeBuilder typeBuilder = moduleBuilder.DefineType("Program");
                MethodBuilder methodBuilder = typeBuilder.DefineMethod("Main", MethodAttributes.Static);

                Expression<Func<string[], int>> lambda = WrapMain(ProgramExpression.CompileFile(runtime, fi.FullName));
                lambda.CompileToMethod(methodBuilder);

                typeBuilder.CreateType();

                moduleBuilder.CreateGlobalFunctions();
                assemblyBuilder.SetEntryPoint(methodBuilder);
                assemblyBuilder.Save(fileName + ".exe");
            }
            catch (SyntaxException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            catch (SemanticException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            //catch (Exception e)
            //{
            //    Console.WriteLine(e);
            //    Console.ReadLine();
            //}
        }

        public static Expression<Func<string[], int>> WrapMain(Expression program)
        {
            LabelTarget label = Expression.Label(typeof (int));

            BlockExpression programReturningNoErrorCode = Expression.Block(program, Expression.Constant(0));

            Expression<Action<Exception>> writeLine = s => Console.Error.WriteLine(s);

            ParameterExpression exitException = Expression.Variable(typeof (ExitException));
            ParameterExpression exception = Expression.Variable(typeof (Exception));

            TryExpression programCatchingExceptions = Expression.TryCatch(programReturningNoErrorCode,
                                                                          Expression.Catch(exitException, Expression.Property(exitException, "Code")),
                                                                          Expression.Catch(exception, Expression.Block(writeLine.eInvoke(exception), Expression.Constant(1))));

            LabelExpression returnLabel = Expression.Label(label, programCatchingExceptions);

            ParameterExpression parameter = Expression.Parameter(typeof (string[]), "args");
            Expression<Func<string[], int>> lambda = Expression.Lambda<Func<string[], int>>(returnLabel, parameter);

            return lambda;
        }

        private static AstHelper CreateRuntime(ModuleBuilder module)
        {
            var result = new AstHelper(module);

            result.Types.Add("int", typeof (int));
            result.Types.Add("string", typeof (string));
            result.Types.Add("bool", typeof (bool));

            Expression<Action<string>> print = a => Console.Write(a);
            result.Functions.Add("print", new FunctionReference(print, typeof (void), typeof (string)));
            Expression<Action<string>> printline = a => Console.WriteLine(a);
            result.Functions.Add("printline", new FunctionReference(printline, typeof (void), typeof (string)));

            Expression<Action<int>> printi = a => Console.WriteLine(a);
            result.Functions.Add("print", new FunctionReference(printi, typeof (void), typeof (int)));

            Expression<Func<string>> readLine = () => Console.ReadLine();
            result.Functions.Add("readline", new FunctionReference(readLine, typeof (string)));

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

            // function exit(i : int)
            // Terminate execution of the program with code i.
            ConstructorInfo constructor = typeof (ExitException).GetConstructor(new[] {typeof (int)});
            ParameterExpression parameter = Expression.Parameter(typeof (int));
            Expression<Action<int>> exit =
                Expression.Lambda<Action<int>>(Expression.Throw(Expression.New(constructor, parameter)), parameter);
            result.Functions.Add("exit", new FunctionReference(exit, typeof (void), typeof (int)));

            return result;
        }
    }
}