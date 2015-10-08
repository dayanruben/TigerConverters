using System.Linq;
using NUnit.Framework;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test.Compiler.Errors
{
    [TestFixture]
    [Category("Program_Errors")]
    public class identifier_not_defined_in_scope_error
    {
        [Test]
        public void access_variable_not_defined()
        {
            try
            {
                const string program = "x";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as IdentifierNotDefinedError;
                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(1, error.Col, "bad column");
                Assert.AreEqual("x", error.VariableName);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void access_variable_not_defined1()
        {
            try
            {
                const string program = "while 10 > 5 do {i+1; {}}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as IdentifierNotDefinedError;
                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(18, error.Col, "bad column");
                Assert.AreEqual("i", error.VariableName);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void variable_defined_in_inner_scope_can_not_be_accesed_from_outer()
        {
            try
            {
                const string program =
                    @" let
    var y:=
        let
            var x:=1
        in x end
in
    x
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as IdentifierNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(7, error.Line, "bad line");
                Assert.AreEqual(5, error.Col, "bad column");
                Assert.AreEqual("x", error.VariableName);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void variable_not_defined_and_used_as_parameter_in_other_function()
        {
            try
            {
                const string program =
                    @"let
    function do_nothing1(a: int, b: string):int=
        {do_nothing2(a+1);0}
    function do_nothing2(d: int):string =
        {do_nothing1(a, ""str"");"" ""}
in
    do_nothing1(0, ""str2"")
end";

                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as IdentifierNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(5, error.Line, "bad line");
                Assert.AreEqual(22, error.Col, "bad column");
                Assert.AreEqual("a", error.VariableName);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void variable_not_defined_in_let_scope()
        {
            try
            {
                const string program =
                    @" let
    var y:=0
in
    x
end";

                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as IdentifierNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(4, error.Line, "bad line");
                Assert.AreEqual(5, error.Col, "bad column");
                Assert.AreEqual("x", error.VariableName);
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}