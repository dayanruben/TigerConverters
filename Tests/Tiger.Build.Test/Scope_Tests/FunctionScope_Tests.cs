using System.Linq.Expressions;
using NUnit.Framework;
using Tiger.Build.Compiler.Ast;
using Tiger.Build.Compiler.Common;
using Expression = System.Linq.Expressions.Expression;

// ReSharper disable InconsistentNaming

namespace Tiger.Build.Test.Scope_Tests
{
    [TestFixture]
    [Category("FunctionScope")]
    public class FunctionScope_Tests
    {
        [Test]
        public void resolves_correct_function_with_different_arguments()
        {
            var scope = new FunctionScope();

            ConstantExpression function1 = Expression.Constant(1);
            ConstantExpression function2 = Expression.Constant(2);

            scope.Add("f1", new FunctionReference(function1, typeof (void)));
            scope.Add("f1", new FunctionReference(function2, typeof (void), typeof (int)));

            FunctionReference result = scope["f1", typeof (int)];

            Assert.AreSame(function2, result.Function);
        }

        [Test]
        public void resolves_correct_function_with_different_arguments_returns_function_with_no_args()
        {
            var scope = new FunctionScope();

            ConstantExpression function1 = Expression.Constant(1);
            ConstantExpression function2 = Expression.Constant(2);

            scope.Add("f1", new FunctionReference(function1, typeof (void)));
            scope.Add("f1", new FunctionReference(function2, typeof (void), typeof (int)));

            FunctionReference result = scope["f1"];

            Assert.AreSame(function1, result.Function);
        }

        [Test]
        public void resolves_function_when_called_with_nil_parameter()
        {
            var scope = new FunctionScope();

            ConstantExpression function1 = Expression.Constant(1);
            ConstantExpression function2 = Expression.Constant(2);

            scope.Add("f1", new FunctionReference(function1, typeof (void), typeof (string)));
            scope.Add("f1", new FunctionReference(function2, typeof (void), typeof (int)));

            FunctionReference result = scope["f1", typeof (Null)];

            Assert.AreSame(function1, result.Function);
        }

        [Test]
        public void resolves_function_when_called_with_nil_parameter_and_different_number_of_args()
        {
            var scope = new FunctionScope();

            ConstantExpression function1 = Expression.Constant(1);
            ConstantExpression function2 = Expression.Constant(2);

            scope.Add("f1", new FunctionReference(function1, typeof (void)));
            scope.Add("f1", new FunctionReference(function2, typeof (void), typeof (string)));

            FunctionReference result = scope["f1", typeof (Null)];

            Assert.AreSame(function2, result.Function);
        }

        [Test]
        public void resolves_function_wih_same_number_of_parameters()
        {
            var scope = new FunctionScope();

            ConstantExpression function1 = Expression.Constant(1);
            ConstantExpression function2 = Expression.Constant(2);

            scope.Add("f1", new FunctionReference(function1, typeof (void), typeof (string)));
            scope.Add("f1", new FunctionReference(function2, typeof (void), typeof (int)));

            FunctionReference result = scope["f1", typeof (int)];

            Assert.AreSame(function2, result.Function);
        }

        [Test]
        public void return_function_implemented_if_added()
        {
            var scope = new FunctionScope();

            var functionReference = new FunctionReference(null, typeof (void));
            scope.Add("Foo", functionReference);

            FunctionReference function = scope["Foo"];

            Assert.AreSame(functionReference, function);
        }

        [Test]
        public void return_same_function_when_requested_two_times()
        {
            var scope = new FunctionScope();

            scope.Add("Foo", new FunctionReference(null, typeof (void)));

            // request for function "Foo()"
            FunctionReference function = scope["Foo"];

            FunctionReference function1 = scope["Foo"];

            Assert.AreSame(function, function1);
        }
    }
}