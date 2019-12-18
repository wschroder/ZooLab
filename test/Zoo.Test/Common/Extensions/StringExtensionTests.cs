using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zoo.Common.Extensions;

namespace Zoo.Test.Common.Extensions
{
    [TestClass]
    public class StringExtensionTests
    {
        [DataTestMethod]
        [DataRow("a")]
        [DataRow(".")]
        [DataRow(". ")]
        [DataRow(". .")]
        [DataRow("x b c")]
        public void HasValue_WhenHasValue(string src)
        {
            Assert.IsTrue(src.HasValue());
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow(" ")]
        [DataRow(null)]
        public void HasValue_WhenNoValue(string src)
        {
            Assert.IsFalse(src.HasValue());
        }

    }
}
