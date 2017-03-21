using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My.Extensions.Advanced.Demo5;

namespace My.Extensions.Advanced.Tests.Demo5
{
    [TestClass]
    public class DecimalExtensionsTests
    {
        [TestMethod]
        new public void ToString()
        {
            var input = 10.51M;
            Assert.AreEqual("10,51", input.ToString());
        }

        [TestMethod]
        public void ToStringRounded()
        {
            var input = 10.51M;
            Assert.AreEqual("10,5", input.ToStringRounded());
        }
    }
}
