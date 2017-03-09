using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My.Extensions.Samples.Demo1;

namespace My.Extensions.Tests.Demo1
{
    [TestClass]
    public class LegacyExtensionsTests
    {
        [TestMethod]
        public void ToLegacyFormat_C20()
        {
            var dateTime = new DateTime(1920, 12, 31);
            Assert.AreEqual("0201231", dateTime.ToLegacyFormat());
        }

        [TestMethod]
        public void ToLegacyFormat_C21()
        {
            var dateTime = new DateTime(2013, 10, 31);
            Assert.AreEqual("1131031", dateTime.ToLegacyFormat());
        }

        [TestMethod()]
        public void ToLegacyName()
        {
            var name = "Elton Stoneman";
            Assert.AreEqual("STONEMAN, ELTON", name.ToLegacyFormat());
        }
    }
}
