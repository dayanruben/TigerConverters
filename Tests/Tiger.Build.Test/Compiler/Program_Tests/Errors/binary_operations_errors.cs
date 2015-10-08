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
    public class binary_operations_errors
    {
        [Test]
        public void compare_record_with_array()
        {
            // this test fails in the appel tests but in python should work
            const string program =
                @"let
    type arrtype = array of int

    var rec := Person {Name=""name"", Age=1}
    var arr := arrtype [3] of 0
in
    if rec <> arr then 1 else 0
end";

            Mother.Test(program, 1);
        }

        [Test]
        public void divide_between_non_integer_left()
        {
            try
            {
                const string program = @"""a"" / 1";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                //                Assert.AreEqual(4, error.Line, "bad line");
                //                Assert.AreEqual(7, error.Col, "bad column");

                Assert.AreEqual(typeof (string), error.Left);
                Assert.AreEqual(typeof (int), error.Right);
                Assert.AreEqual(TigerOperator.Divide, error.Operator);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void equals_non_valued_operand_left()
        {
            try
            {
                const string program = @"if {} = 1 then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(7, error.Col, "bad column");

                Assert.AreEqual(typeof (void), error.Left);
                Assert.AreEqual(typeof (int), error.Right);
                Assert.AreEqual(TigerOperator.Equal, error.Operator);

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void greater_equals_than_non_valued_operand_right()
        {
            try
            {
                const string program = @"if 1 >= {} then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(6, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.Left);
                Assert.AreEqual(typeof (void), error.Right);
                Assert.AreEqual(TigerOperator.GreaterThanOrEqual, error.Operator);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void greater_than_non_associative()
        {
            try
            {
                const string program = @"if 0 > 1 > 2 then {}";
                Mother.Test(program, 1);
            }
            catch (SyntaxException e)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }


        [Test]
        public void less_equals_than_invalid_type_operand_left()
        {
            try
            {
                const string program = @"if nil <= 1 then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(8, error.Col, "bad column");

                Assert.AreEqual(typeof (Null), error.Left);
                Assert.AreEqual(typeof (int), error.Right);
                Assert.AreEqual(TigerOperator.LessThanOrEqual, error.Operator);

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void less_equals_than_invalid_type_operand_right()
        {
            try
            {
                const string program = @"if 1 <= nil then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(6, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.Left);
                Assert.AreEqual(typeof (Null), error.Right);
                Assert.AreEqual(TigerOperator.LessThanOrEqual, error.Operator);

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void less_equals_than_non_associative()
        {
            try
            {
                const string program = @"if 0 <= 1 <= 2 then {}";
                Mother.Test(program, 1);
            }
            catch (SyntaxException e)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void less_equals_than_non_valued_operand_left()
        {
            try
            {
                const string program = @"if {} <= 1 then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(7, error.Col, "bad column");

                Assert.AreEqual(typeof (void), error.Left);
                Assert.AreEqual(typeof (int), error.Right);
                Assert.AreEqual(TigerOperator.LessThanOrEqual, error.Operator);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void less_equals_than_non_valued_operand_right()
        {
            try
            {
                const string program = @"if 1 <= {} then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(6, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.Left);
                Assert.AreEqual(typeof (void), error.Right);
                Assert.AreEqual(TigerOperator.LessThanOrEqual, error.Operator);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void less_equals_than_operand_types_missmatch()
        {
            try
            {
                const string program = @"if 1 <= ""abc"" then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(6, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.Left);
                Assert.AreEqual(typeof (string), error.Right);
                Assert.AreEqual(TigerOperator.LessThanOrEqual, error.Operator);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void less_than_invalid_type_operand_right()
        {
            try
            {
                const string program = @"if 1 < nil then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(6, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.Left);
                Assert.AreEqual(typeof (Null), error.Right);
                Assert.AreEqual(TigerOperator.LessThan, error.Operator);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void less_than_non_associative()
        {
            try
            {
                const string program = @"if 0 < 1 < 2 then {}";
                Mother.Test(program, 1);
            }
            catch (SyntaxException e)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void less_than_non_valued_operand_left()
        {
            try
            {
                const string program = @"if {} < 1 then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(7, error.Col, "bad column");

                Assert.AreEqual(typeof (void), error.Left);
                Assert.AreEqual(typeof (int), error.Right);
                Assert.AreEqual(TigerOperator.LessThan, error.Operator);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void less_than_non_valued_operand_right()
        {
            try
            {
                const string program = @"if 1 < {} then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(6, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.Left);
                Assert.AreEqual(typeof (void), error.Right);
                Assert.AreEqual(TigerOperator.LessThan, error.Operator);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void less_than_operand_types_missmatch()
        {
            try
            {
                const string program = @"if 1 < ""abc"" then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(6, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.Left);
                Assert.AreEqual(typeof (string), error.Right);
                Assert.AreEqual(TigerOperator.LessThan, error.Operator);

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void minus_between_non_integer_left()
        {
            try
            {
                const string program = @"""a"" - 1";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(4, error.Col, "bad column");

                Assert.AreEqual(typeof (string), error.Left);
                Assert.AreEqual(typeof (int), error.Right);
                Assert.AreEqual(TigerOperator.Subtract, error.Operator);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void minus_between_non_integer_right()
        {
            try
            {
                const string program = @"1 - ""a""";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(2, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.Left);
                Assert.AreEqual(typeof (string), error.Right);
                Assert.AreEqual(TigerOperator.Subtract, error.Operator);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void minus_between_non_valued_right()
        {
            try
            {
                const string program =
                    @"let 
    var a := 0
in
    1 - (a := 1)
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(4, error.Line, "bad line");
                Assert.AreEqual(7, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.Left);
                Assert.AreEqual(typeof (void), error.Right);
                Assert.AreEqual(TigerOperator.Subtract, error.Operator);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void multiple_divide_between_non_integers_center()
        {
            try
            {
                const string program = @"1 / ""a"" / 2";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                //                Assert.AreEqual(4, error.Line, "bad line");
                //                Assert.AreEqual(7, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.Left);
                Assert.AreEqual(typeof (string), error.Right);
                Assert.AreEqual(TigerOperator.Divide, error.Operator);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void multiple_plus_between_non_integer_center()
        {
            try
            {
                const string program = @"1 + ""a"" + 2";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                //                Assert.AreEqual(4, error.Line, "bad line");
                //                Assert.AreEqual(7, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.Left);
                Assert.AreEqual(typeof (string), error.Right);
                Assert.AreEqual(TigerOperator.Add, error.Operator);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void multiple_times_between_non_integers_center()
        {
            try
            {
                const string program = @"1 * ""a"" * 2";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                //                Assert.AreEqual(4, error.Line, "bad line");
                //                Assert.AreEqual(7, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.Left);
                Assert.AreEqual(typeof (string), error.Right);
                Assert.AreEqual(TigerOperator.Multiply, error.Operator);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void nil_less_than_one()
        {
            try
            {
                const string program = @"if nil < 1 then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(8, error.Col, "bad column");

                Assert.AreEqual(typeof (Null), error.Left);
                Assert.AreEqual(typeof (int), error.Right);
                Assert.AreEqual(TigerOperator.LessThan, error.Operator);

                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}