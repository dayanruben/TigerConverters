using NUnit.Framework;

namespace Tiger.Build.Test.Compiler
{
    [TestFixture]
    [Category("Program")]
    // ReSharper disable InconsistentNaming
    public class binary_comparison_operation_tests
    {
        [Test]
        public void equals_operand_types_missmatch()
        {
            const string program = @"1 = ""abc""";
            Mother.Test(program, false);
        }

        [Test]
        public void literal_string_compared_with_null_is_true()
        {
            // Arrange (set up a scenario)
            const string program = @"nil<>""some""";
            // Act (attempt the operation)

            // Assert (verify the result)
            Mother.Test(program, true);
        }

        [Test]
        public void literal_string_compared_with_null_is_true_1()
        {
            // Arrange (set up a scenario)
            const string program = @"""some""<>nil";
            // Act (attempt the operation)

            // Assert (verify the result)
            Mother.Test(program, true);
        }

        [Test]
        public void string_variable_equals_null_compared_with_null_returns_false()
        {
            // Arrange (set up a scenario)
            const string program =
                @"let 
    var a:string:=nil
in a<>nil end";
            // Act (attempt the operation)

            // Assert (verify the result)
            Mother.Test(program, false);
        }

        [Test]
        public void string_variable_equals_null_compared_with_null_returns_true()
        {
            // Arrange (set up a scenario)
            const string program =
                @"let 
    var a:string:=nil
in a=nil end";
            // Act (attempt the operation)

            // Assert (verify the result)
            Mother.Test(program, true);
        }

        [Test]
        public void string_variable_not_equals_null()
        {
            // Arrange (set up a scenario)
            const string program =
                @"let
    var a:string:=""something""
in a<>nil end";
            // Act (attempt the operation)

            // Assert (verify the result)
            Mother.Test(program, true);
        }
    }
}