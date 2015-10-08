using System.Linq;
using NUnit.Framework;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test
{
    [TestFixture]
    [Category("Program_Errors")]
    public class type_matched_error
    {
        [Test]
        public void empty_expresion_sequence_does_not_return()
        {
            try
            {
                const string program = @"if {} then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as NotBoolConvertibleError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(4, error.Col, "bad column");

                Assert.AreEqual(typeof (void), error.Expected);
                Assert.AreEqual(typeof (void), error.Type);

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void if_then_else_without_return_value()
        {
            try
            {
                const string program = @"while if 1 then {} else {} do {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as NotBoolConvertibleError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(7, error.Col, "bad column");

                Assert.AreEqual(typeof (void), error.Expected);
                Assert.AreEqual(typeof (void), error.Type);

                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}