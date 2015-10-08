using System.Linq;
using NUnit.Framework;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test.Compiler.Errors
{
    [TestFixture]
    [Category("Program_Errors")]
    public class identifier_expected_keyword_used_error
    {
        [Test]
        public void variable_declaration_named_int()
        {
            try
            {
                const string program =
                    @" let
    var int:=0
in
    int
end";

                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as IdentifierExpectedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(2, error.Line, "bad line");
                Assert.AreEqual(9, error.Col, "bad column");
                Assert.AreEqual("int", error.Identifier);
            }
        }
    }
}