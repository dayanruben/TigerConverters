using NUnit.Framework;

namespace Tiger.Build.Test.Compiler
{
    [TestFixture]
    [Category("Program")]
    public class assignments_tests
    {
        [Test]
        public void access_item_on_complex_array()
        {
            const string program =
                @"let 
    type SimpleArray = array of int 
    type ComplexArray = array of SimpleArray 
    
    var val := 0 
    var x := ComplexArray[2] of SimpleArray[2] of 1
in
    x
end";

            var result = Mother.Eval<int[][]>(program);
            CollectionAssert.AreEqual(new[] {new[] {1, 1}, new[] {1, 1}}, result);
        }

        [Test]
        public void assign_value_to_array()
        {
            const string program =
                @"let 
    type arr=array of int
    var x := arr[2] of 0
in 
    x[0]:=1;
    x[1]:=2;
    x
end";

            Mother.Test(program, new[] {1, 2});
        }

        [Test]
        public void assign_value_to_variable()
        {
            const string program =
                @"let 
    var x := 0
in 
    x:=1;
    x
end";
            Mother.Test(program, 1);
        }

        [Test]
        public void complex_array_initialization_evaluated_each_time()
        {
            // similar to test case #6 in modified specs

            const string program =
                @"let 
    type SimpleArray = array of int 
    type ComplexArray = array of SimpleArray 
    
    var val := 0 
    var x := ComplexArray[2] of SimpleArray[2] of {val:=val+1; val}
in
    x
end";

            var result = Mother.Eval<int[][]>(program);
            CollectionAssert.AreEqual(new[] {new[] {1, 2}, new[] {3, 4}}, result);
        }

        [Test]
        public void declare_array_of_string_equals_null()
        {
            const string program =
                @"let
    type arr=array of string
    var x:=arr[2] of nil
in
    x
end";
            Mother.Test(program, new string[] {null, null});
        }

        [Test]
        public void declare_string_equals_null()
        {
            const string program =
                @"let
    var x:string:=nil
in
    x
end";
            Mother.Test<string>(program, null);
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
    jaggedint1[1] := arrayinteger[2] of 0;
    jaggedint1[1]
end";
            Mother.Test(program, new[] {0, 0});
        }

        [Test]
        public void expected_type_in_inner_scope_with_string()
        {
            const string program =
                @"let 
    var x:=""something""
in 
    x:=let var _:=0 in nil end;
    x
end";

            Mother.Test<string>(program, null);
        }

        [Test]
        public void expected_type_in_inner_scope_with_string1()
        {
            const string program =
                @"let 
    var x:=""something""
    var y:=""something""

in 
    x:=let var _:=0 in y:={x:=""xyz""; nil}; nil end;
    y
end";

            Mother.Test<string>(program, null);
        }
    }
}