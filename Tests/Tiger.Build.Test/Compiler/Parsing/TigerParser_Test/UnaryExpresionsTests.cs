// Developed by doiTTeam => devdoiTTeam@gmail.com

using System.Linq.Expressions;
using NUnit.Framework;
using Tiger.Build.Compiler.Parsing;

namespace Tiger.Build.Test.Compiler.Parsing.TigerParser_Test
{
    [Category("Parser")]
    [TestFixture]
    public class UnaryExpresionsTests
    {
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(8)]
        public void ConstantExpression_intValue(int number)
        {
            TigerParser parser = Mother.CreateParser(number.ToString());

            Expression expression = parser.parse().Compile();

            Assert.IsInstanceOf<ConstantExpression>(expression);
            var constant = expression as ConstantExpression;
            Assert.IsInstanceOf<int>(constant.Value);
            Assert.AreEqual((int) constant.Value, number);
        }

        [TestCase("\"some string\"")]
        [TestCase("\"other string longer /n /u /3456\"")]
        public void ConstantExpression_stringValue(string str)
        {
            TigerParser parser = Mother.CreateParser(str);

            Expression expression = parser.parse().Compile();

            Assert.IsInstanceOf<ConstantExpression>(expression);
            var constant = expression as ConstantExpression;
            Assert.IsInstanceOf<string>(constant.Value);
            Assert.AreEqual(constant.Value, str.Substring(1, str.Length - 2));
        }
    }
}