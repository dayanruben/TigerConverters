using NUnit.Framework;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test.Compiler
{
    [TestFixture]
    [Category("Program")]
    public class array_tests
    {
        [Test]
        public void access_item_on_array_that_is_initialized_with_default_value()
        {
            const string program =
                @"let
    type arr=array of int
    var x := arr[3] of 1
in
    x[1]
end";

            Mother.Test(program, 1);
        }

        [Test]
        public void array_created_with_alias()
        {
            const string program =
                @"let
    type myint = int
    type  arrtype = array of myint

    var arr1:arrtype := arrtype [2] of 1
in
    arr1
end";

            Mother.Test(program, new[] {1, 1});
        }


        [Test]
        public void check_int_array_initialized_with_default_value()
        {
            const string program =
                @"let
    type arr=array of int
    var x := arr[3] of 1
in
    x
end";

            var result = Mother.Eval<int[]>(program);

            CollectionAssert.AreEqual(new[] {1, 1, 1}, result);
        }

        [Test]
        public void default_array_initialization_is_evaluated_each_time()
        {
            //            var builder=ne

            const string program =
                @"let
    var t:=0
    type arr=array of int
    var x := arr[3] of {t:=t+1; t}
in
    x
end";

            Mother.Test(program, new[] {1, 2, 3});
        }

        [Test]
        public void initialize_array_specifing_items()
        {
            const string program =
                @"let
    var x := [1,1,1]
in
    x
end";

            Mother.Test(program, new[] {1, 1, 1});
        }

        [Test]
        public void initialize_array_specifing_string_items()
        {
            const string program =
                @"let
    var x := [""a"",""b"",""c""]
in
    x
end";

            Mother.Test(program, new[] {"a", "b", "c"});
        }

        [Test]
        public void initialize_array_specifing_string_items_with_nil_between()
        {
            const string program =
                @"let
    var x := [""a"",nil,""c""]
in
    x
end";

            Mother.Test(program, new[] {"a", null, "c"});
        }

        [Test]
        public void initialize_array_specifing_string_items_with_nil_first()
        {
            const string program =
                @"let
    var x := [nil,""a"",""c""]
in
    x
end";

            Mother.Test(program, new[] {null, "a", "c"});
        }

        [Test]
        public void initialize_array_with_default_value()
        {
            const string program =
                @"let
    type arr=array of int
    var x := arr[3] of 1
in
    x
end";

            Mother.Test(program, new[] {1, 1, 1});
        }

        [Test]
        public void int_alias_type_declaration()
        {
            const string program =
                @"let
    type alias = int
    var x:alias := 1
in
    x.GetType()
end";

            Mother.Test(program, typeof (int));
        }

        [Test]
        public void int_array_type_declaration()
        {
            const string program =
                @"let
    type arr=array of int
    var x := arr[3] of 1
in
    x.GetType()
end";

            Mother.Test(program, typeof (int[]));
        }

        [Test]
        public void method_returning_array_and_accessing_it()
        {
            const string program =
                @"let
    type arr=array of int
    var x := arr[3] of 1
    function Foo():arr = x
in
    Foo()[1]
end";

            Mother.Test(program, 1);
        }
    }
}