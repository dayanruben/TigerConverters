// ReSharper disable InconsistentNaming

using NUnit.Framework;
using Tiger.Build.Compiler.Ast;

namespace Tiger.Build.Test.Compiler
{
    [TestFixture]
    [Category("Program")]
    public class match_expression_stmt
    {
        [Test]
        public void simple_match_expression()
        {
            var target = new MatchExpression
                {
                    new GuardNode
                        {
                            Test = new[] {new BoolLiteral(true),},
                            Result = new BoolLiteral(true)
                        },
                    new GuardNode
                        {
                            Test = new[] {new BoolLiteral(false),},
                            Result = new BoolLiteral(false)
                        }
                };
            target.Match = new[] {new BoolLiteral(true),};

            Mother.Test(target.Compile(Mother.CreateRuntime()), true);
        }
    }
}