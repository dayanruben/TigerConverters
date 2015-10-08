using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Error;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test.Compiler.Errors
{
    [TestFixture]
    [Category("Program_Errors")]
    public class can_not_infer_type_error
    {
        [Test]
        public void and_operator_with_non_valued_operands()
        {
            const string program = @"if 1 && {} then 1 else 0";

            try
            {
                Mother.Eval<int>(program);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as TypeMatchedError;

                Assert.IsNotNull(error);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void and_operator_with_non_valued_operands1()
        {
            const string program = @"if {{} && {}} then 1 else 0";

            try
            {
                Mother.Eval<int>(program);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as TypeMatchedError;

                Assert.IsNotNull(error);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void compare_integer_with_string()
        {
            // "abc" = "abc"
            var target = new LogicalBinaryOperationExpression
                {
                    Left = new IntLiteralExpression(1),
                    Right = new StringLiteralExpression("abc"),
                    Operator = TigerOperator.Equal
                };
            AstHelper helper = Mother.CreateRuntime();

            var result = target.Compile(helper).Eval<bool>();
            Assert.IsFalse(result);
        }

        [Test]
        public void if_then_expression_infers_type_and_returns_nil_of_that_type()
        {
            // nil && 1
            var target = new IfThenElseExpression
                {
                    Test = new BoolLiteral(false),
                    Then = new StringLiteralExpression("\"abc\""),
                    Else = new NullLiteralExpression(),
                };
            AstHelper helper = Mother.CreateRuntime();

            var result = target.Compile(helper).Eval<string>();
            Assert.AreEqual(null, result);
        }

        [Test]
        public void if_then_expression_infers_type_when_one_value_is_nil()
        {
            // nil && 1
            var target = new IfThenElseExpression
                {
                    Test = new BoolLiteral(true),
                    Then = new StringLiteralExpression("\"abc\""),
                    Else = new NullLiteralExpression(),
                };
            AstHelper helper = Mother.CreateRuntime();

            var result = target.Compile(helper).Eval<string>();
            Assert.AreEqual("abc", result);
        }

        [Test]
        public void inferred_variable_nil()
        {
            try
            {
                const string program =
                    @"let
    var b := nil
in
    b
end";
                Mother.Test(program, 1);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as CanNotInferTypeError;

                Assert.IsNotNull(error);

                Assert.AreEqual(2, error.Line, "bad line");
                Assert.AreEqual(5, error.Col, "bad column");

                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void initialize_array_all_nil()
        {
            try
            {
                const string program =
                    @"let
    var x := [nil,nil,nil]
in
    x
end";

                Mother.Test(program, new[] {null, null, "c"});
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as CanNotInferArrayTypeError;

                Assert.IsNotNull(error);

                Assert.AreEqual(2, error.Line, "bad line");
                Assert.AreEqual(14, error.Col, "bad column");
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void integer_or_else_nil()
        {
            // 1 || nil
            var target = new LogicalBinaryOperationExpression
                {
                    Left = new ToBooleanExpression(new IntLiteralExpression(1)),
                    Right = new ToBooleanExpression(new NullLiteralExpression()),
                    Operator = TigerOperator.OrElse
                };
            AstHelper helper = Mother.CreateRuntime();

            var result = target.Compile(helper).Eval<bool>();
            Assert.IsTrue(result);
        }

        [Test]
        public void logical_binary_comparation_nil_with_string()
        {
            // nil=(nil="pepe")
            var target = new LogicalBinaryOperationExpression
                {
                    Left = new NullLiteralExpression(),
                    Right = new LogicalBinaryOperationExpression
                        {
                            Left = new NullLiteralExpression(),
                            Right = new StringLiteralExpression("pepe"),
                            Operator = TigerOperator.Equal
                        },
                    Operator = TigerOperator.Equal
                };
            AstHelper helper = Mother.CreateRuntime();

            var result = target.Compile(helper).Eval<bool>();
            Assert.IsFalse(result);
        }

        [Test]
        public void nil_and_also_integer()
        {
            // nil && 1
            var target = new LogicalBinaryOperationExpression
                {
                    Left = new ToBooleanExpression(new NullLiteralExpression()),
                    Right = new ToBooleanExpression(new IntLiteralExpression(1)),
                    Operator = TigerOperator.AndAlso
                };
            AstHelper helper = Mother.CreateRuntime();

            var result = target.Compile(helper).Eval<bool>();
            Assert.IsFalse(result);
        }

        [Test]
        public void nil_equals_integer()
        {
            // nil = 1
            var target = new LogicalBinaryOperationExpression
                {
                    Left = new NullLiteralExpression(),
                    Right = new IntLiteralExpression(1),
                    Operator = TigerOperator.Equal
                };
            AstHelper helper = Mother.CreateRuntime();

            var result = target.Compile(helper).Eval<bool>();
            Assert.IsFalse(result);
        }

        [Test]
        public void nil_equals_nil()
        {
            // nil = nil
            var target = new LogicalBinaryOperationExpression
                {
                    Left = new NullLiteralExpression(),
                    Right = new NullLiteralExpression(),
                    Operator = TigerOperator.Equal
                };
            AstHelper helper = Mother.CreateRuntime();

            try
            {
                target.Compile(helper);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as CanNotInferTypeError;
                Assert.IsNotNull(error);
                Assert.Pass();
            }
            Assert.Fail();
        }

        [Test]
        public void nil_is_false()
        {
            // nil
            var target = new ToBooleanExpression(new NullLiteralExpression());
            AstHelper helper = Mother.CreateRuntime();

            var result = target.Compile(helper).Eval<bool>();
            Assert.IsFalse(result);
        }

        [Test]
        public void valid_equals_comparison_using_strings()
        {
            // "abc" = "abc"
            var target = new LogicalBinaryOperationExpression
                {
                    Left = new StringLiteralExpression("abc"),
                    Right = new StringLiteralExpression("abc"),
                    Operator = TigerOperator.Equal
                };
            AstHelper helper = Mother.CreateRuntime();

            var result = target.Compile(helper).Eval<bool>();
            Assert.IsTrue(result);
        }

        [Test]
        public void variable_declaration_without_type_equals_null()
        {
            // let var x:=nil in x and
            var target = new LetInExpression
                {
                    VariableDeclarations = new List<VariableDeclarationBase>
                        {
                            new VariableDeclarationExpression
                                {
                                    VariableName =
                                        new MemberIdentifierNode {Name = "x"},
                                    VariableTypeName = new TypeReferenceNode(),
                                    Value = new NullLiteralExpression()
                                }
                        },
                    Body = new ListSemiExpression
                        {
                            new VariableAccessExpression {VariableName = "x"}
                        }
                };
            AstHelper helper = Mother.CreateRuntime();

            try
            {
                target.Compile(helper);
            }
            catch (SemanticException e)
            {
                var error = e.Errors.First() as CanNotInferTypeError;
                Assert.IsNotNull(error);
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}