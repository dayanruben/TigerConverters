using System.Linq;
using NUnit.Framework;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test.Compiler.Errors
{
    [TestFixture]
    [Category("Program_Errors")]
    public class type_mismatched_errors
    {
        [Test]
        public void and_operator_returns_value()
        {
            try
            {
                const string program = @"while 0 && 1 do 0 && 1";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as WhileBodyReturnsValueError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void body_of_a_if_then_returns_not_void()
        {
            try
            {
                const string program = @"if 20 then 3";

                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as IfThenBodyReturnsValueError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(12, error.Col, "bad column");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void body_of_a_while_returns_not_void()
        {
            try
            {
                const string program = @"while(10 > 5) do 5+6";

                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as WhileBodyReturnsValueError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(1, error.Col, "bad column");

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void hi_variable_of_for_is_wrong_assigned()
        {
            try
            {
                const string program = @"for i:=10 to "" "" do i := i - 1";

                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as NotAssignableError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(5, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.VariableType);
                Assert.AreEqual(typeof (string), error.ValueType);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void if_then_else_type_mismatch()
        {
            try
            {
                const string program = @"if 1 then ""abc"" else 0";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as ConditionalNotEquivalentTypes;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(1, error.Col, "bad column");

                Assert.AreEqual(typeof (string), error.ExpectedType);
                Assert.AreEqual(typeof (int), error.ActualType);

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void if_then_else_typed_and_not_typed()
        {
            try
            {
                const string program = @"if 1 then {} else 0";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as ConditionalNotEquivalentTypes;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(1, error.Col, "bad column");

                Assert.AreEqual(typeof (void), error.ExpectedType);
                Assert.AreEqual(typeof (int), error.ActualType);

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void if_then_else_with_integer_return_value()
        {
            try
            {
                const string program = @"while 1 do if 1 then 1 else 1";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as WhileBodyReturnsValueError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(1, error.Col, "bad column");

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void if_then_else_without_valued_condition()
        {
            try
            {
                const string program = @"if {} then 0 else 1";
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
        public void if_then_with_valued_expression()
        {
            try
            {
                const string program = @"if 1 then 1";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as IfThenBodyReturnsValueError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(11, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.ActualType);
                Assert.AreEqual(typeof (void), error.ExpectedType);

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void void_assigned_to_a_variable()
        {
            try
            {
                const string program = @"let var x:=1 in x:={} end";

                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as NotAssignableError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(18, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.VariableType);
                Assert.AreEqual(typeof (void), error.ValueType);
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}