using System;
using System.Linq.Expressions;
using NUnit.Framework;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Parsing;
using Expression = System.Linq.Expressions.Expression;

namespace Tiger.Build.Test.Compiler
{
    [TestFixture]
    [Category("Program")]
    public class runtime_function_calls
    {
        [Test]
        public void calls_function_in_runtime()
        {
            string program = "Calc()";

            TigerParser parser = Mother.CreateParser(program);
            var runtime = new AstHelper(null);
            Expression<Func<int>> calc = () => 1;
            runtime.Functions.Add("Calc", new FunctionReference(calc, typeof (int)));
            Expression result = parser.parse().Compile(runtime);

            Mother.Test(result, 1);
        }

        [Test]
        public void mutually_recursive_function_declaration_3_depth()
        {
            const string program =
                @"let
    function f(b : Person) : int = g(b.Age)
    function g(i : int) : int = h(Person{Age = i+2})
    type C = Person
    var a:= 1
    function h(c : C) : int = f(c)
in
1
end";
            Mother.Test(program, 1);
        }
    }
}