using System.Linq;
using NUnit.Framework;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test
{
    [TestFixture]
    [Category("Program_Errors")]
    public class not_assignable_error
    {
        [Test]
        public void array_init_with_value_type_and_nil()
        {
            try
            {
                const string program =
                    @"let
    var x := [nil,1]
in
    x
end";

                Mother.Test(program, new[] {1, 1});
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as NotAssignableError;

                Assert.IsNotNull(error);

                Assert.AreEqual(2, error.Line, "bad line");
                Assert.AreEqual(14, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.VariableType);
                Assert.AreEqual(typeof (Null), error.ValueType);

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void array_init_with_value_type_and_nil_second()
        {
            try
            {
                const string program =
                    @"let
    var x := [1,nil,nil]
in
    x
end";

                Mother.Test(program, new[] {1, 1, 1});
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as NotAssignableError;

                Assert.IsNotNull(error);

                Assert.AreEqual(2, error.Line, "bad line");
                Assert.AreEqual(14, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.VariableType);
                Assert.AreEqual(typeof (Null), error.ValueType);

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void assign_nil_to_value_type()
        {
            try
            {
                const string program =
                    @"let
    var x:int := nil
in
    x
end";

                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as NotAssignableError;

                Assert.IsNotNull(error);

                Assert.AreEqual(2, error.Line, "bad line");
                Assert.AreEqual(5, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.VariableType);
                Assert.AreEqual(typeof (Null), error.ValueType);

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void bad_record_initialization()
        {
            try
            {
                const string program =
                    @"let
	type human = { age: int, siblin: human}
	var human1 := human{age = 4, siblin = 1}
in
	1
end";

                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as NotAssignableError;

                Assert.IsNotNull(error);

                Assert.AreEqual(3, error.Line, "bad line");
                Assert.AreEqual(31, error.Col, "bad column");

                Assert.AreEqual("human", error.VariableType.Name);
                Assert.AreEqual(typeof (int), error.ValueType);

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
                var error = e.Errors.First() as NotAssignableError;

                Assert.IsNotNull(error);

                Assert.AreEqual(7, error.Line, "bad line");
                Assert.AreEqual(22, error.Col, "bad line");

                Assert.AreEqual(typeof (int), error.VariableType);
                Assert.AreEqual(typeof (string), error.ValueType);

                Assert.Pass();
            }
            Assert.Fail();
        }


        [Test]
        public void record_access_incompatible_types()
        {
            try
            {
                const string program =
                    @"let
	type human = { age: int, siblin: human}    
	type humanarray = array of human    
	var humanarray1 := humanarray[6] of nil    
	var human1 := human{age = 4, siblin = nil}
in
	humanarray1[1].age := human1;
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as NotAssignableError;

                Assert.IsNotNull(error);

                Assert.AreEqual(7, error.Line, "bad line");
                Assert.AreEqual(21, error.Col, "bad column");

                Assert.AreEqual(typeof (int), error.VariableType);
                Assert.AreEqual("human", error.ValueType.Name);

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void record_access_incompatible_types_setting_property()
        {
            try
            {
                const string program =
                    @"let
	type human = { age: int, siblin: human}    
	type humanarray = array of human    
	var humanarray1 := humanarray[6] of nil    
	var human1 := human{age = 4, siblin = nil}
in
	human1.siblin := 1
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as NotAssignableError;

                Assert.IsNotNull(error);

                Assert.AreEqual(7, error.Line, "bad line");
                Assert.AreEqual(16, error.Col, "bad column");

                Assert.AreEqual("human", error.VariableType.Name);
                Assert.AreEqual(typeof (int), error.ValueType);

                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}