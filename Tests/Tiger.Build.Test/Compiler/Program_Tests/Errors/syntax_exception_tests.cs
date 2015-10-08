using System.Data;
using NUnit.Framework;
using Tiger.Build.Compiler.Common;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test
{
    [TestFixture]
    [Category("Program_Errors")]
    public class syntax_exception_tests
    {
        [Test]
        public void ascii_escape_in_string_literal()
        {
            // this should be invalid?? in our program the string is captured fine
            const string program =
                @"let
    var s := ""This is an invalid character: \999""
in
    1
end";
            Mother.Test(program, 1);
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
        public void control_in_string_literal()
        {
            // this should be invalid?? in our program the string is captured fine
            const string program =
                @"let
    var s := ""This is an invalid Control-c sequence: \^0""
in
    s
end";
            Mother.Test(program, @"This is an invalid Control-c sequence: \^0");
        }

        [Test]
        public void id_underscore()
        {
            // this is allowed by our compiler
            const string program =
                @"let
    var _abc := ""This is an invalid identifier.""
in
    _abc
end";
            Mother.Test(program, "This is an invalid identifier.");
        }

        [Test]
        public void invalid_escape_in_string_literal()
        {
            const string program =
                @"let
    var s := ""This is an invalid escape: \j""
in
s
end";
            Mother.Test(program, @"This is an invalid escape: \j");
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
            catch (SyntaxException e)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void invalid_string_literal()
        {
            try
            {
                const string program =
                    @"let
    var s := ""This is a string literal that begins here...
in
    s
end";
                Mother.Test(program, "");
            }
            catch (SyntaxException e)
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}