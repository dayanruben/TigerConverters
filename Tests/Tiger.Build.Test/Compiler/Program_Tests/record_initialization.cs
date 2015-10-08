using NUnit.Framework;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test.Compiler
{
    [TestFixture]
    [Category("Program")]
    public class record_initialization
    {
        // the person record is added to the scope, see create runtime in the Mother class

        [Test]
        public void access_record_field_after_init()
        {
            const string program =
                @"let
	type human = { age: int, siblin: human}
	var human1 := human{age = 2, siblin = nil}
in
	human1.siblin:=human{age=1};
    human1.siblin.age
end";

            Mother.Test(program, 1);
        }

        [Test]
        public void array_of_record()
        {
            const string program =
                @"let
    type Animal={Age:int}
    type arr=array of Animal
    var x:=arr[2] of Animal{Age=1}
in
    x[0].Age
end";

            Mother.Test(program, 1);
        }

        [Test]
        public void record_initialized_fails()
        {
            const string program =
                @"let
    type Animal={Age:int}
    var x:=Animal{Age=1}
in
    x.Age
end";

            Mother.Test(program, 1);
        }

        [Test]
        public void record_initialized_with_values()
        {
            const string program =
                @"let
    var x:=Person{Age=1,Name=""pepe""}
in
    x
end";

            Mother.Test(program, new Mother.Person {Age = 1, Name = "pepe"});
        }
    }
}