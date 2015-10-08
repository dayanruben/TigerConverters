using System.Linq;
using NUnit.Framework;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test.Compiler.Errors
{
    [TestFixture]
    [Category("Program_Errors")]
    public class member_with_same_name_already_defined_error
    {
        [Test]
        public void two_functions_with_different_signature()
        {
            const string program =
                @" let
    function x():int=0
    function x(a:int):int=1
in
    x(1)
end";

            Mother.Test(program, 1);
        }

        [Test]
        public void two_functions_with_same_signature()
        {
            try
            {
                const string program =
                    @" let
    function x()=0
    function x()=0
in
    x
end";

                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(3, error.Line, "bad line");
                Assert.AreEqual(14, error.Col, "bad column");
                Assert.AreEqual("x", error.MemberName);
            }
        }

        [Test]
        public void two_variables_in_same_scope()
        {
            try
            {
                const string program =
                    @" let
    var x:=0
    var x:=1
in
    x
end";

                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameNameAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(3, error.Line, "bad line");
                Assert.AreEqual(9, error.Col, "bad column");
                Assert.AreEqual("x", error.MemberName);
            }
        }

        [Test]
        public void variable_and_method_with_same_name_function_first()
        {
            try
            {
                const string program =
                    @" let
    function x()=0
    var x:=0
in
    x
end";

                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameNameAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(3, error.Line, "bad line");
                Assert.AreEqual(9, error.Col, "bad column");
                Assert.AreEqual("x", error.MemberName);
            }
        }

        [Test]
        public void variable_and_method_with_same_name_variable_first()
        {
            try
            {
                const string program =
                    @" let
    var x:=0
    function x()=0
in
    x
end";

                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameNameAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(2, error.Line, "bad line");
                Assert.AreEqual(9, error.Col, "bad column");
                Assert.AreEqual("x", error.MemberName);
            }
        }
    }
}