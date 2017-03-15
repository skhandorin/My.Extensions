using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml;

namespace My.Extensions.Tests.Demo2
{
    [TestClass]
    public class DateTimeExtensionsTest
    {
        [TestMethod]
        public void ToXmlDateTime()
        {
            var dateTime = new DateTime(2013, 10, 24, 13, 10, 15, 951);
            Assert.AreEqual("2013-10-24T13:10:15.951Z", dateTime.ToXmlDateTime());
        }

        [TestMethod]
        public void ToXmlDateTime_Local()
        {
            var dateTime = new DateTime(2013, 10, 24, 13, 10, 15, 951);
            Assert.AreEqual("2013-10-24T13:10:15.951+05:00", dateTime.ToXmlDateTime(XmlDateTimeSerializationMode.Local));
            Assert.AreEqual("2013-10-24T13:10:15.951+05:00", DateTimeExtensions.ToXmlDateTime(dateTime, XmlDateTimeSerializationMode.Local));
        }
    }
}
