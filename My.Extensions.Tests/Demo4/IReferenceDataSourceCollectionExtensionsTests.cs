using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My.Extensions.Samples.Demo3;
using My.Extensions.Samples.Demo3.Impl;
using System.Linq;

namespace My.Extensions.Tests.Demo4
{
    [TestClass]
    public class IReferenceDataSourceCollectionExtensionsTests
    {
        [TestMethod]
        public void GetAllItemsByCode_Array()
        {
            var sources = new IReferenceDataSource[]
            {
                new SqlReferenceDataSource(),
                new XmlReferenceDataSource(),
                new ApiReferenceDataSource()
            };
            var items = sources.GetAllItemsByCode("xyz");
            Assert.AreEqual(6, items.Count());
        }
    }
}
