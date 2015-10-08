using System.Linq;
using NUnit.Framework;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test.Compiler.Program_Tests.Errors
{
    [TestFixture]
    [Category("Program_Errors")]
    public class break_out_of_loops_error
    {
        [Test]
        public void break_in_a_function()
        {
            try
            {
                const string program =
                    @"let
    function suc(x : int) : int =
        let
            var y := 1
        in
            break;                  
            x + y
        end
in
    for i := 0 to 10 do
        let
            function zero() : int = {if i = 5 then break; 0}
        in
            break
        end        
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as BreakOutOfLoopScopeError;

                Assert.IsNotNull(error);
                Assert.AreEqual(6, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void break_in_a_valued_expression()
        {
            try
            {
                const string program =
                    @"let
    var a := {1 + 2; 3}
    var b := {if 3 - 1 then break; 1}
in
    1
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error1 = e.Errors.First() as BreakOutOfLoopScopeError;

                Assert.IsNotNull(error1);
                Assert.AreEqual(3, error1.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void break_out_of_for()
        {
            try
            {
                const string program =
                    @"let
    var a:= 3
in 
    for i := 1 to 10 do ""Hello, World!"";
    break
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as BreakOutOfLoopScopeError;

                Assert.IsNotNull(error);
                Assert.AreEqual(5, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void break_out_of_while()
        {
            try
            {
                const string program =
                    @"let
    var i := 0
in
    while i < 1 do if i = 0 then i := i + 1;
    break
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as BreakOutOfLoopScopeError;

                Assert.IsNotNull(error);
                Assert.AreEqual(5, error.Line, "bad line");


                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}