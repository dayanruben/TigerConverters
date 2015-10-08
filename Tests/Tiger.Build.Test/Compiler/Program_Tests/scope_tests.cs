using NUnit.Framework;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test.Compiler
{
    [TestFixture]
    [Category("Program")]
    public class scope_tests
    {
        [Test]
        public void modify_variable_defined_in_outer_scope()
        {
            const string program =
                @"let 
    var x:=0
in
    let var y:=0
    in x:=1 end;
    x
end";

            Mother.Test(program, 1);
        }

        [Test]
        public void same_variable_defined_in_inner_scope_does_not_affect_outer()
        {
            const string program =
                @"let 
    var x:=0
in 
    let
        var x:=1
    in x end;
    x
end";

            Mother.Test(program, 0);
        }


        [Test]
        public void simple_return_inside_a_function()
        {
            const string program =
                @"let 
    function Foo():int = {return 1; 0}
in
    Foo()
end";

            Mother.Test(program, 1);
        }
    }
}