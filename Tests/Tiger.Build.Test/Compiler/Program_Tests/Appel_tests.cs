using NUnit.Framework;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test.Compiler
{
    [TestFixture]
    [Category("Program")]
    public class Appel_tests
    {
        [Test]
        public void comparing_2_strings()
        {
            const string program =
                @"let
    var s:= """"
    var t:= """"
in
    s:= ""abc"";
    t:= ""cba"";
    if s = t then 0 else 1    
end";

            Mother.Test(program, 1);
        }

        [Test]
        public void compile_empty_let()
        {
            const string program = @"let in end";

            Mother.Compile(program);
        }

        [Test]
        public void correct_if()
        {
            /* correct if */
            const string program = @"if (10 > 20) then 30 else 40	";

            Mother.Test(program, 40);
        }

        [Test]
        public void local_types_hide_global()
        {
            /* local types hide global */
            const string program =
                @"let
    type a = int
in
    let
        type a = string
        var x :a := ""si"" 
    in
        x
    end
end";

            Mother.Test(program, "si");
        }

        [Test]
        public void locals_hide_global()
        {
            /* locals hide globals */
            const string program =
                @"let
    var a:=""abc""
    function g(a:int):int = a 
in 
    g(2)
end";

            Mother.Test(program, 2);
        }

        [Test]
        public void synonyms_are_fine()
        {
            /* synonyms are fine */
            const string program =
                @"let 
        type a = array of int
        type b = a

        var arr1:a := b [10] of 0
in
        arr1[2]
end";

            Mother.Test(program, 0);
        }
    }
}