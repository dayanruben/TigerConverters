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
    public class member_not_defined_error
    {
        [Test]
        public void field_not_defined()
        {
            var target = new FieldAccessExpression
                {
                    FieldName = new IdentifierNode {Name = "Foo"},
                    Target = new StringLiteralExpression("abc")
                };
            AstHelper helper = Mother.CreateRuntime();

            try
            {
                target.Compile(helper);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as FieldNotFoundError;
                Assert.IsNotNull(error);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void record_initialized_with_values()
        {
            const string program = @"Person{Age=1,Name=""pepe"", Foo=1}";

            try
            {
                Mother.Eval<Mother.Person>(program);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as FieldNotFoundError;

                Assert.IsNotNull(error);
                Assert.AreEqual("Foo", error.MemberName);
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}