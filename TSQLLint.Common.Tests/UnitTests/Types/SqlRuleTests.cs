using NUnit.Framework;
using System;

namespace TSQLLint.Common.Tests
{
    public class SqlRuleTests
    {
        [Test]
        public void TestSqlRule()
        {
            ISqlLintRule testSqlRule = new TestSqlRule();
            Assert.Throws<NotImplementedException>(() => { _ = testSqlRule.RULE_NAME; });
            Assert.DoesNotThrow(() => { testSqlRule.FixViolation(null, null, null); });
        }
    }
}