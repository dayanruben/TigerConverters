using System;
using System.Linq.Expressions;
using NUnit.Framework;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test.Compiler
{
    [TestFixture]
    [Category("Program")]
    public class check_prorgam_results_Tests
    {
        public void array_access_test_with_expressions()
        {
            // doesn't know how to use the array index for indexer in non array abjects
            BinaryExpression e = Expression.ArrayIndex(Expression.Constant("123"), Expression.Constant(1));
            Expression<Func<char>> lamda = Expression.Lambda<Func<char>>(e);
            char result = lamda.Compile()();
            Assert.AreEqual('2', result);
        }

        [Test]
        public void IntConstantExpression()
        {
            Mother.Test("1", 1);
        }

        [Test]
        public void LetIn_variable_access()
        {
            Mother.Test("let var x:=1 in x end", 1);
        }

        [Test]
        public void StringConstantExpression()
        {
            Mother.Test("\"pepe\"", "pepe");
        }

        [Test]
        public void array_creation_tests()
        {
            Array array = Array.CreateInstance(typeof (int), 3);
            array.SetValue(1, 1);
        }

        [Test]
        public void bool_false()
        {
            Mother.Test("false", false);
        }

        [Test]
        public void bool_true()
        {
            Mother.Test("true", true);
        }

        [Test]
        public void call_function_defined_below()
        {
            const string program =
                @"let 
    function Bla():int = Foo() 
    function Foo():int = 1 
in 
    Bla()
end";
            Mother.Test(program, 1);
        }

        [Test]
        public void concat_strings()
        {
            const string program =
                @"let
    function Concat(x:string, y:string):string = y.Insert(0,x)
in 
    Concat(""a"",""b"") 
end";

            Mother.Test(program, "ab");
        }

        [Test]
        public void factorial_function_eval()
        {
            const string program =
                @"let
    function Fact(n:int):int = if n=0 then 1 else n*Fact(n-1)
in
    Fact(5)
end";

            Mother.Test(program, 120);
        }

        [Test]
        public void format_string_test()
        {
            Mother.Test("\"{0} to {1}\" % (0,1)", "0 to 1");
        }

        [Test]
        public void function_and_variable_defined_recursively_returns_default_value()
        {
            const string program =
                @"let
    var x:=Foo()
    function Foo():int = x
in
    x
end";

            Mother.Test(program, 0);
        }

        [Test]
        public void function_call_in_let_in_expression()
        {
            Mother.Test("let function Foo():int=1 in Foo() end", 1);
        }

        [Test]
        public void function_equals_to_variable_defined_above()
        {
            const string program =
                @"let
    var x:=1
    function Foo():int = x
in
    x
end";
            Mother.Test(program, 1);
        }

        [Test]
        public void function_equals_to_variable_defined_below()
        {
            const string program =
                @"let 
    function Foo():int = x
    var x:=1
in 
    x
end";
            Mother.Test(program, 1);
        }


        [Test]
        public void function_with_args()
        {
            const string program =
                @"let
    function Foo(x:int):int = x
in
    Foo(1)
end";
            Mother.Test(program, 1);
        }

        [Test]
        public void if_expression_false()
        {
            Mother.Test("if false then 1 else 0", 0);
        }

        [Test]
        public void if_expression_true()
        {
            Mother.Test("if true then 1 else 0", 1);
        }

        [Test]
        public void method_call_on_string()
        {
            const string program = "\"PEPE\".ToLower()";
            // program.ToUpper()
            Mother.Test(program, "pepe");
        }

        [Test]
        public void method_call_on_string_with_parameters()
        {
            const string program = "\"123\".Substring(1)";
            // program.Substring(1)
            Mother.Test(program, "23");
        }

        [Test]
        public void property_access_on_string()
        {
            const string program = "\"123\".Length";

            Mother.Test(program, 3);
        }

        [Test]
        public void variable_initializad_with_function_defined_below()
        {
            const string program =
                @"let
    var x:=Foo()
    function Foo():int = 1
in
    x
end";
            Mother.Test(program, 1);
        }
    }
}