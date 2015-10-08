using System.Data;
using System.Linq;
using NUnit.Framework;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;

namespace Tiger.Build.Test.Compiler.Program_Tests.Errors
{
    [TestFixture]
    [Category("Program_Errors")]
    [Ignore("Tests not finalized yet...")]
    internal class Appel_error_tests
    {
        [Test]
        public void and_operator_returns_value()
        {
            try
            {
                const string program = @"while 0 & 1 do 0 & 1";
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

                // Assert.AreEqual("break", error.MemberName);

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

        [Test]
        public void comment_not_ended_after_program()
        {
            // the exception isn't thrown because the comment is after the program
            try
            {
                const string program =
                    @"let
    var s := ""Hello, world!""
in
    s
end
/* This is a comment that begins here...
";
                Mother.Test(program, "Hello, world!");
            }
            catch (SyntaxErrorException e)
            {
                Assert.Pass();
            }
        }

        [Test]
        public void comment_not_ended_in_program()
        {
            try
            {
                const string program =
                    @"let
    var s := ""Hello, world!\n""
in
    /* This is a comment that begins here...
    print(s);
end
";
                Mother.Test(program, 1);
            }
            catch (SyntaxException e)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void differents_types_array_assign()
        {
            const string program =
                @"let
    type arrayint = array of int
    type arrayinteger = array of int 
    type jaggedint = array of arrayint
    var arrayint1 := arrayint[5+7] of 1 + (3/2) - (5*7)
    var N := 6
    var jaggedint1 := jaggedint[N] of arrayint1
in
    jaggedint1[1] := arrayinteger[2] of 0
    jaggedint1[1]
end";
            Mother.Test(program, new[] {0, 0});
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
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void divide_between_non_integer_right()
        {
            try
            {
                const string program = @"1 / ""a""";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void divide_between_non_valued_left()
        {
            try
            {
                const string program = @"""a"" / 1";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void divide_between_non_valued_right()
        {
            try
            {
                const string program =
                    @"let 
    var a := 0
in
    1 + (a := 1)
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(4, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

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
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
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
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void equals_operand_types_missmatch()
        {
            try
            {
                const string program = @"if 1 = ""abc"" then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void for_index_variable_readonly()
        {
            // for us the variable is not read-only

            try
            {
                const string program = @"for i := 1 to 10 do i := nil";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as NotAssignableError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(23, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.VariableType);
                Assert.AreEqual(typeof (Null), error.ValueType);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void for_non_valued_both()
        {
            try
            {
                const string program = @"for i := {} to {} do i";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as NotAssignableError;
                var error1 = e.Errors.Skip(1).First() as NotAssignableError;

                Assert.IsNotNull(error);
                Assert.IsNotNull(error1);

                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(5, error.Col, "bad line");
                Assert.AreEqual(typeof (int), error.VariableType);
                Assert.AreEqual(typeof (void), error.ValueType);

                Assert.AreEqual(1, error1.Line, "bad line");
                Assert.AreEqual(5, error1.Col, "bad line");
                Assert.AreEqual(typeof (int), error1.VariableType);
                Assert.AreEqual(typeof (void), error1.ValueType);

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void for_non_valued_lower()
        {
            try
            {
                const string program = @"for i := {} to 10 do i";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as NotAssignableError;

                Assert.IsNotNull(error);

                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(5, error.Col, "bad line");

                Assert.AreEqual(typeof (int), error.VariableType);
                Assert.AreEqual(typeof (void), error.ValueType);

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void for_non_valued_upper()
        {
            try
            {
                const string program = @"for i := 1 to {} do i";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as NotAssignableError;

                Assert.IsNotNull(error);

                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(5, error.Col, "bad line");

                Assert.AreEqual(typeof (int), error.VariableType);
                Assert.AreEqual(typeof (void), error.ValueType);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void for_wrong_valued_both()
        {
            try
            {
                const string program = @"for i := nil to nil do i";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as NotAssignableError;
                var error1 = e.Errors.Skip(1).First() as NotAssignableError;

                Assert.IsNotNull(error);
                Assert.IsNotNull(error1);

                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(5, error.Col, "bad line");
                Assert.AreEqual(typeof (int), error.VariableType);
                Assert.AreEqual(typeof (Null), error.ValueType);

                Assert.AreEqual(1, error1.Line, "bad line");
                Assert.AreEqual(5, error1.Col, "bad line");
                Assert.AreEqual(typeof (int), error1.VariableType);
                Assert.AreEqual(typeof (Null), error1.ValueType);

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void for_wrong_valued_lower()
        {
            try
            {
                const string program = @"for i := nil to 10 do i";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as NotAssignableError;

                Assert.IsNotNull(error);

                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(5, error.Col, "bad line");
                Assert.AreEqual(typeof (int), error.VariableType);
                Assert.AreEqual(typeof (Null), error.ValueType);

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void for_wrong_valued_upper()
        {
            try
            {
                const string program = @"for i := 0 to nil do i";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as NotAssignableError;

                Assert.IsNotNull(error);

                Assert.AreEqual(1, error.Line, "bad line");
                Assert.AreEqual(5, error.Col, "bad line");
                Assert.AreEqual(typeof (int), error.VariableType);
                Assert.AreEqual(typeof (Null), error.ValueType);

                Assert.Pass();
            }
            Assert.Fail();
        }

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
        public void greater_equals_than_invalid_type_operand_left()
        {
            try
            {
                const string program = @"if nil >= 1 then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void greater_equals_than_invalid_type_operand_right()
        {
            try
            {
                const string program = @"if 1 >= nil then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void greater_equals_than_non_associative()
        {
            try
            {
                const string program = @"if 0 >= 1 >= 2 then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void greater_equals_than_non_valued_operand_left()
        {
            try
            {
                const string program = @"if {} >= 1 then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
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
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void greater_equals_than_operand_types_missmatch()
        {
            try
            {
                const string program = @"if 1 >= ""abc"" then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void greater_than_invalid_type_operand_left()
        {
            try
            {
                const string program = @"if nil > 1 then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void greater_than_invalid_type_operand_right()
        {
            try
            {
                const string program = @"if 1 > nil then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as TypeMatchedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");

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
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void greater_than_non_valued_operand_left()
        {
            try
            {
                const string program = @"if {} > 1 then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void greater_than_non_valued_operand_right()
        {
            try
            {
                const string program = @"if 1 > {} then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void greater_than_operand_types_missmatch()
        {
            try
            {
                const string program = @"if 1 > ""abc"" then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
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
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
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
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
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
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void if_then_else_without_integer_condition()
        {
            try
            {
                const string program = @"if ""abc"" then 0 else 1";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void if_then_else_without_return_value()
        {
            try
            {
                const string program = @"while if 1 then break else break do break";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
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
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
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
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void if_then_without_incompatible_types_jagged_arrayvalued_condition()
        {
            try
            {
                const string program =
                    @"let  
    type arrayint = array of int
    type jaggedint = array of arrayint
    var arrayint1 := arrayint[5+7] of 1 + (3/2) - (5*7)
    var jaggedint1 := jaggedint[6] of arrayint1
in
    jaggedint1[1][2] := ""a""
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(7, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void if_then_without_integer_condition()
        {
            try
            {
                const string program = @"if ""abc"" then break";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void if_then_without_valued_condition()
        {
            try
            {
                const string program = @"while if break then break do ""3""";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void inferred_variable_incompatibles_type()
        {
            try
            {
                const string program =
                    @"let
    var a := ""20""
    var b := 1
in
    b = a;
    b := ""a"";
    a := 1
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(5, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void inferred_variable_nil()
        {
            try
            {
                const string program =
                    @"let
    var a := ""20""
    var b := nil
in
    a := ""a"";
    a
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(5, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void invalid_ascii_escape_in_string_literal()
        {
            try
            {
                const string program =
                    @"let
    var s := ""This is an invalid character: \999""
in
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(2, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void invalid_control_in_string_literal()
        {
            try
            {
                const string program =
                    @"let
    var s := ""This is an invalid Control-c sequence: \^0""
in
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(2, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void invalid_escape_in_string_literal()
        {
            try
            {
                const string program =
                    @"let
    var s := ""This is an invalid escape: \j""
in
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(2, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void invalid_id_number()
        {
            try
            {
                const string program =
                    @"let
    var 1abc := ""This is an invalid identifier.""
in
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(2, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void invalid_id_underscore()
        {
            try
            {
                const string program =
                    @"let
    var _abc := ""This is an invalid identifier.""
in
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as MemberWithSameSignatureAlreadyDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(2, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void invalid_mutually_recursive_function_declaration()
        {
            try
            {
                const string program =
                    @"let
    var s := ""This is a string literal that begins here...
in
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as CircularTypeReferencesError;

                Assert.IsNotNull(error);
                Assert.AreEqual(2, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void invalid_mutually_recursive_function_declaration_3_depth()
        {
                const string program =
                    @"let
    function f(b : B) : int = 1
    type B = {field : int}
    function g(i : int) : int = h(B{field = i+2})
    type C = B
    var a:= 1
    function h(c : C) : int = f(c)
in
    g(2)
end";
                Mother.Test(program, 1);
        }

        [Test]
        public void invalid_mutually_recursive_function_declaration_4_depth()
        {
            try
            {
                const string program =
                    @"let
    function f(b : B) : int = g(b.field)
    type B = {field : int}
    function g(i : int) : int = h(B{field = i+2})
    type C = B
    var a:= 1
    function h(c : C) : int = i(b.field + c.field)
    var b:= C{field = 1}
    function i(i : int) : int = f(i)
in
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as CircularTypeReferencesError;

                Assert.IsNotNull(error);
                Assert.AreEqual(9, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void invalid_mutually_recursive_record_declaration()
        {
            try
            {
                const string program =
                    @"/* The woman test. */
let
    type Woman = {beauty : int}
in
    let     
    type Men = {wife : Woman} 
    var a:= 1
    type Woman = {husband : Men}
    in
    end
    1
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as CircularTypeReferencesError;

                Assert.IsNotNull(error);
                Assert.AreEqual(8, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void invalid_mutually_recursive_record_declaration_3_depth()
        {
            try
            {
                const string program = @"if nil < 1 then {}";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as CircularTypeReferencesError;

                Assert.IsNotNull(error);
                Assert.AreEqual(8, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void invalid_mutually_recursive_record_declaration_4_depth()
        {
            try
            {
                const string program =
                    @"let
    type A = {field : int}
in
    let
        type B = {field : A}      
        var a:= 1
        type A = {field : C} 
        function b(field : int) : int = 1
        type C = G
        type G = {field : H}
        var c:= 2
        type H = B
    in
    end
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as CircularTypeReferencesError;

                Assert.IsNotNull(error);
                Assert.AreEqual(10, error.Line, "bad line");
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
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
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
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void less_than_invalid_type_operand_left()
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
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(1, error.Line, "bad line");
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
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void minus_between_non_valued_left()
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
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void multiple_alias_errors()
        {
            try
            {
                const string program =
                    @"let
    type a = b
    type b = c
    type c = d
    type d = b
in 
    let
        type g = h
        type h = non_defined
    in
        2
    end
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(4, error.Line, "bad line");
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
                Assert.AreEqual(4, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void multiple_divide_between_non_integers_left()
        {
            try
            {
                const string program = @"""a"" / 1 / 2";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(4, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void multiple_divide_between_non_integers_right()
        {
            try
            {
                const string program = @"1 / 2 / ""a""";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(4, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void multiple_minus_between_non_integers_center()
        {
            try
            {
                const string program = @"1 - ""a"" - 2";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(4, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void multiple_minus_between_non_integers_left()
        {
            try
            {
                const string program = @"""a"" - 1 - 2";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(4, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void multiple_minus_between_non_integers_right()
        {
            try
            {
                const string program = @"1 - 2 - ""a""";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(4, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void multiple_operator_between_non_integers()
        {
            try
            {
                const string program = @"""a"" + 2 * ""b"" - ""c"" + 3 / ""uno""";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(4, error.Line, "bad line");
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
                Assert.AreEqual(4, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void multiple_plus_between_non_integer_left()
        {
            try
            {
                const string program = @"""a"" + 1 + 2";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(4, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void multiple_plus_between_non_integer_right()
        {
            try
            {
                const string program = @"1 + 2 + ""a""";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(4, error.Line, "bad line");
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
                Assert.AreEqual(4, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void multiple_times_between_non_integers_left()
        {
            try
            {
                const string program = @"""a"" * 1 * 2";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(4, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void multiple_times_between_non_integers_right()
        {
            try
            {
                const string program = @"1 * 2 * ""a""";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as OperatorNotDefinedError;

                Assert.IsNotNull(error);
                Assert.AreEqual(4, error.Line, "bad line");
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}