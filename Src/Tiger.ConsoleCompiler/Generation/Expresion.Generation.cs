using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;

namespace Tiger.ConsoleCompiler
{
    public static class ExpresionExtensors
    {
        public static Expression WrapIntoConsoleTry(this Expression statements)
        {
            MethodInfo writeLine = typeof (Console).GetMethod("WriteLine", new[] {typeof (object)});

            ParameterExpression exception = Expression.Variable(typeof (Exception));
            TryExpression lambda = Expression.TryCatch(statements,
                                                       Expression.Catch(exception,
                                                                        Expression.Call(writeLine, exception)));
            return lambda;
        }

        public static void SaveIntoAssembly(this Expression statements, string moduleName, string fileName)
        {
            Debug.Assert(moduleName != null, "moduleName != null");

            var assemblyName = new AssemblyName(moduleName);
            assemblyName.Version = new Version(1, 0);
            AssemblyBuilder assemblyBuilder = AppDomain.CurrentDomain.DefineDynamicAssembly(assemblyName,
                                                                                            AssemblyBuilderAccess.Save);

            ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule(moduleName, fileName);

            TypeBuilder typeBuilder = moduleBuilder.DefineType("Program");
            MethodBuilder methodBuilder = typeBuilder.DefineMethod("Main", MethodAttributes.Static);

            ParameterExpression parameter = Expression.Parameter(typeof (string[]), "args");
            Expression<Action<string[]>> lambda = Expression.Lambda<Action<string[]>>(statements, parameter);
            lambda.CompileToMethod(methodBuilder);

            typeBuilder.CreateType();

            moduleBuilder.CreateGlobalFunctions();
            assemblyBuilder.SetEntryPoint(methodBuilder);
            assemblyBuilder.Save(fileName);
        }
    }
}