using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test.Compiler.Errors
{
    [TestFixture]
    [Category("Program_Errors")]
    public class function_not_defined_error
    {
        [Test]
        public void function_call_invalid_argument_types()
        {
            try
            {
                const string program = @"substring(1, ""a"", nil)";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as FunctionNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(1, error.Col, "bad column");

                Assert.AreEqual("substring", error.FunctionName);
                CollectionAssert.AreEqual(new[] {typeof (int), typeof (string), typeof (Null)}, error.ArgTypes);

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void function_call_invalid_number_arguments()
        {
            try
            {
                const string program = @"substring(1, 2, 3, 4, 5)";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as FunctionNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(1, error.Col, "bad column");

                Assert.AreEqual("substring", error.FunctionName);
                CollectionAssert.AreEqual(
                    new[] {typeof (int), typeof (int), typeof (int), typeof (int), typeof (int),}, error.ArgTypes);

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void function_call_not_function()
        {
            try
            {
                const string program =
                    @"let
    var a := 1
in
    a(1)
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as FunctionNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(4, error.Line, "bad line");
                Assert.AreEqual(5, error.Col, "bad column");

                Assert.AreEqual("a", error.FunctionName);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void function_call_undefined_function()
        {
            try
            {
                const string program = @"undefined_function(1)";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as FunctionNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(1, error.Col, "bad column");

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void function_same_parameters_name()
        {
            try
            {
                const string program =
                    @"let
    function f(a: int, a: string, b: int, b: string) : int = 1
in
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as SomeParametersWithTheSameNameError;

                Assert.IsNotNull(error);
                Assert.AreEqual(2, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void simple_function_call()
        {
            // Foo()
            var target = new FunctionInvokeExpression
                {
                    FunctionName = new IdentifierNode {Name = "Foo"}
                };
            AstHelper helper = Mother.CreateRuntime();

            try
            {
                target.Compile(helper);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as FunctionNotDefinedError;
                Assert.IsNotNull(error);
            }
        }

        [Test]
        public void variable_initialization_with_undefined_function()
        {
            // let var x:=Foo() in x and
            var target = new LetInExpression
                {
                    VariableDeclarations = new List<VariableDeclarationBase>
                        {
                            new VariableDeclarationExpression
                                {
                                    VariableName =
                                        new MemberIdentifierNode {Name = "x"},
                                    VariableTypeName = new TypeReferenceNode(),
                                    Value = new FunctionInvokeExpression
                                        {
                                            FunctionName =
                                                new IdentifierNode
                                                    {Name = "Foo"}
                                        }
                                }
                        },
                    Body = new ListSemiExpression
                        {
                            new VariableAccessExpression {VariableName = "x"}
                        }
                };
            AstHelper helper = Mother.CreateRuntime();

            try
            {
                target.Compile(helper);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as FunctionNotDefinedError;
                Assert.IsNotNull(error);
            }
        }
    }
}