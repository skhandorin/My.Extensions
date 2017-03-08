using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My.Extensions.Samples.Demo1;

namespace My.Extensions.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ToLegacyFormat_C20()
        {
            var dateTime = new DateTime(1920, 12, 31);
            Assert.AreEqual("0201231", dateTime.ToLegacyFormat());
        }
    }
}
