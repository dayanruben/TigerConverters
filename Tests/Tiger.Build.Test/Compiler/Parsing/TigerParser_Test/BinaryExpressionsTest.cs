// Developed by doiTTeam => devdoiTTeam@gmail.com

using System;
using System.Linq.Expressions;
using NUnit.Framework;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;
using Tiger.Build.Compiler.Parsing;
using BinaryExpression = System.Linq.Expressions.BinaryExpression;
using Expression = System.Linq.Expressions.Expression;

namespace Tiger.Build.Test.Compiler.Parsing.TigerParser_Test
{
    [TestFixture]
    [Category("Parser")]
    public class BinaryExpressionsTest
    {
        [TestCase("4+3", ExpressionType.Add)]
        [TestCase("4-3", ExpressionType.Subtract)]
        [TestCase("4*3", ExpressionType.Multiply)]
        [TestCase("4/3", ExpressionType.Divide)]
        [TestCase("4+3*4", ExpressionType.Add)]
        public void BinaryExpresionOperation(string program, ExpressionType operation)
        {
            TigerParser parser = Mother.CreateParser(program);
            ProgramExpression rootAstExpression = parser.parse();
            Expression expression = rootAstExpression.Compile();

            Assert.IsInstanceOf<BinaryExpression>(expression);
            var binary = expression as BinaryExpression;
            Assert.AreEqual(binary.NodeType, operation);
        }

        [TestCase("sum(2,2)", 4)]
        [TestCase("resta(3,2)", 1)]
        [TestCase("prod(2,2)", 4)]
        [TestCase("div(12,2)", 6)]
        [TestCase("sum(div(12,2),prod(2,3))", 12)]
        [TestCase("2**2", 4)]
        [TestCase("2**3", 8)]
        [TestCase("2*(1+3)", 8)]
        public void FunctionInvoked_ComplexFunctions(string program, int result)
        {
            var scope = new AstHelper(null);
            Expression<Func<int, int, int>> sum = (a, b) => a + b;
            scope.Functions.Add("sum", new FunctionReference(sum, typeof (int), typeof (int), typeof (int)));
            Expression<Func<int, int, int>> resta = (a, b) => a - b;
            scope.Functions.Add("resta", new FunctionReference(resta, typeof (int), typeof (int), typeof (int)));
            Expression<Func<int, int, int>> prod = (a, b) => a*b;
            scope.Functions.Add("prod", new FunctionReference(prod, typeof (int), typeof (int), typeof (int)));
            Expression<Func<int, int, int>> div = (a, b) => a/b;
            scope.Functions.Add("div", new FunctionReference(div, typeof (int), typeof (int), typeof (int)));

            Expression expression = ProgramExpression.Compile(scope, program);

            int lamda = Expression.Lambda<Func<int>>(expression).Compile()();
            Assert.AreEqual(lamda, result);
        }

        [TestCase("2=2", true)]
        [TestCase("2<1", false)]
        [TestCase("1<1", false)]
        [TestCase("1>=1", true)]
        [TestCase("1<1 && 2=2", false)]
        [TestCase("1>=1 || 2<1", true)]
        [TestCase(" 2<1||1>=1", true)]
        [TestCase("1=0", false)]
        public void Comparisons(string program, bool result)
        {
            Expression expression = ProgramExpression.Compile(new AstHelper(null), program);

            bool lamda = Expression.Lambda<Func<bool>>(expression).Compile()();
            Assert.AreEqual(result, lamda);
        }

        [Test]
        public void CanConstantExpressionBeNull()
        {
            ConstantExpression c2 = Expression.Constant(null);
            ConstantExpression c1 = Expression.Constant(null);
            BinaryExpression a = Expression.Equal(c1, c2);
            Assert.Pass();
        }

        [Test]
        public void test_block_return_its_last_value()
        {
            // this test demostrates that only one of the blocks in the
            // path to the root should reference each variable used in the
            // child nodes. If one block below references the same variable
            // then it's not the same variable.

            ParameterExpression x = Expression.Parameter(typeof (int));
            ParameterExpression y = Expression.Parameter(typeof (int));

            BlockExpression expression = Expression.Block(new[] {x, y},
                                                          Expression.Block(
                                                              Expression.Assign(x, Expression.Constant(1)),
                                                              Expression.Block(Expression.Assign(y, x), y)));

            Expression<Func<int>> lamda = Expression.Lambda<Func<int>>(expression);
            int result = lamda.Compile()();
            Assert.AreEqual(1, result);
        }
    }
}