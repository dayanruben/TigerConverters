using System.Linq;
using NUnit.Framework;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test.Compiler
{
    [TestFixture]
    [Category("Program")]
    public class loop_tests
    {
        [Test]
        public void basic_while_semantic()
        {
            const string program =
                @"let var i  := 1
    in 
        while i < 5 do
            {i := i + 1};
        
        i
    end";

            //we are saying while i < 5 update i to i + 1 then when i = 5 the loop condition fail and the i value must be 5
            Mother.Test(program, 5);
        }

        [Test]
        public void breack_in_a_simple_for()
        {
            /* valid for and let */
            const string program =
                @"let
    var a:= 0
in 
    for i:=0 to 100 do {a:=a+1; if a = 5 then break};
    a
end";

            Mother.Test(program, 5);
        }

        [Test]
        public void break_out_of_a_loop_error()
        {
            const string program =
                @"let var x : int := 4
    in
        while x > 0 do  
            x := {10; x - 1};
    break;
    x
end";

            //we are saying while i < 5 update i to i + 1 then when i = 5 the loop condition fail and the i value must be 5

            try
            {
                Mother.Test(program, -1);
            }
            catch (SemanticException e)
            {
                Assert.AreEqual(e.Errors.Count(), 1);
                Assert.AreEqual(e.Errors.First().GetType(), typeof (BreakOutOfLoopScopeError));
            }
        }

        [Test]
        public void breaking_complicated_nested_loops()
        {
            const string program =
                @"let var i  := 0
      var j  := 0
      var k  := 0
    in 
        while i < 10 do
            {
                i := i + 1; 
                if i = 5 then break;
                j := 0;
                while j < 10 do
                    { 
                        j := j + 1;
                        if j = 5 then break;
                        k := 0;
                        while k < 10 do
                            {
                                k := k + 1;
                                if k = 5 then break
                            }  
                    }
            };
        
        i * j * k
    end";

            Mother.Test(program, 125);
        }

        [Test]
        public void breaking_loop_in_a_specific_moment()
        {
            const string program =
                @"let var i  := 1
    in 
        while i < 10 do
            {
                i := i + 1; 
                if i = 5 then break
            };
        
        i
    end";

            Mother.Test(program, 5);
        }

        [Test]
        public void breaking_nested_loops()
        {
            const string program =
                @"let 
    var i  := 1
    var j  := 1
in 
    while i < 10 do
    {
        i := i + 1; 
        if i = 5 then break;
        j := 0;
        while j < 5 do
        { 
            j := j + 1;
            if j = 3 then break  
        }
    };
        
    i * j
end";

            Mother.Test(program, 15);
        }

        [Test]
        public void continuing_a_loop()
        {
            const string program =
                @"let var i  := 1
      var p  := 1
    in 
        while i < 10 do
            {i := i + 1; if p = 5 then continue; p := p + 1};
        
        p
    end";

            Mother.Test(program, 5);
        }

        [Test]
        public void factorial_of_5_with_loop()
        {
            const string program =
                @"let var i  := 1
      var a  := 1
    in 
        while i < 5 do
            {i := i + 1; a := a * i};
        
        a
    end";

            Mother.Test(program, 120);
        }

        [Test]
        public void simple_for()
        {
            const string program =
                @"/* valid for and let */

let
    var a:= 0
in 
    for i:=0 to 100 do {a:=a+1};
    a
end
";

            Mother.Test(program, 101);
        }

        [Test]
        public void simple_loop_behavior()
        {
            const string program =
                @"let var i  := 1
    in 
        while i < 10 do
            i := i + 1;
        
        i
    end";

            Mother.Test(program, 10);
        }

        [Test]
        public void testing_break_semantic_error1()
        {
            const string program =
                @"let var x : int := 4
    in
        while x > 0 do  
            x := {10 ; break ; x - 1} /* Este programa no es válido. El compilador debe reportar que la expresión que se intenta asignar a x no retorna valor. */ 
    end";

            //we are saying while i < 5 update i to i + 1 then when i = 5 the loop condition fail and the i value must be 5

            try
            {
                Mother.Test(program, 5);
            }
            catch (SemanticException e)
            {
                Assert.AreEqual(e.Errors.Count(), 1);
                Assert.AreEqual(e.Errors.First().GetType(), typeof (ExpectingTypeError));
            }
        }

        [Test]
        public void testing_break_semantic_error2()
        {
            const string program =
                @"let var x : int := 4
      var c : int := 8 
in
        while x > 0 do
            x := {10 ; if c < 3 then break ; x - 1} /* Este programa no es válido. El compilador debe reportar que la expresión que se intenta asignar a x no retorna valor [pues la condición de la instrucción if-then puede potencialmente tomar valor 1 (aunque en este caso particular eso no ocurra) y hacer que se produzca un break cuando se ejecute el cuerpo de la misma]. */ 
end";

            try
            {
                Mother.Test(program, 5);
            }
            catch (SemanticException e)
            {
                Assert.AreEqual(e.Errors.Count(), 1);
                Assert.AreEqual(e.Errors.First().GetType(), typeof (ExpectingTypeError));
            }
        }

        [Test]
        public void testing_break_semantic_error3()
        {
            const string program =
                @"let var x : int := 4 
    in 
        while x > 0 do 
            x := {10 ; if 1 - 1 then break ; x - 1} 
    /* A pesar de que el cuerpo de la instrucción if-then nunca se ejecutará (porque su condición siempre evaluará a 0), 
    Ud. puede considerar que este programa no es válido. El compilador reportará que la expresión que se intenta asignar 
    a x no retorna valor [creyendo que la condición de la instrucción if-then puede potencialmente tomar valor 1 (aunque
    sabemos que esto no ocurrirá y que podría haberse detectado en tiempo de compilación) y hacer que se produzca un break 
    cuando se ejecute el cuerpo de la misma]. */ 
end";

            //we are saying while i < 5 update i to i + 1 then when i = 5 the loop condition fail and the i value must be 5
            try
            {
                Mother.Test(program, 5);
            }
            catch (SemanticException e)
            {
                Assert.AreEqual(e.Errors.Count(), 1);
                Assert.AreEqual(e.Errors.First().GetType(), typeof (ExpectingTypeError));

                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}