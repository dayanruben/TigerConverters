using NUnit.Framework;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test.Compiler
{
    [TestFixture]
    [Category("Program")]
    public class If_then_and_if_then_else_tests
    {
        [Test]
        public void if_then_else_with_string_condition()
        {
            const string program = @"if ""abc"" then 1 else 0";
            Mother.Test(program, 1);
        }

        [Test]
        public void if_then_with_comparing_int_and_string()
        {
            const string program = @"if 1 && ""abc"" then 1 else 0";

            Mother.Test(program, 1);
        }

        [Test]
        public void if_then_with_comparing_string_and_nil()
        {
            const string program = @"if (""abc"") && nil then 1 else 0";

            Mother.Test(program, 0);
        }

        [Test]
        public void simple_if_then()
        {
            const string program =
                @"let var i  := 1
    in 
        if i = 1 then i := i + 1;
        i
    end";

            Mother.Test(program, 2);
        }

        [Test]
        public void simple_if_with_null()
        {
            const string program = @"nil && 1";

            Mother.Test(program, false);
        }
    }
}