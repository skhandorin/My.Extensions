using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using My.Extensions.Samples.Demo5;
using My.Extensions.Samples.Demo3;
using System.Collections.Generic;
using My.Extensions.Samples.Demo3.Impl;

namespace My.Extensions.Tests.Demo5
{
    [TestClass]
    public class ObjectExtensionsTests
    {
        [TestMethod]
        public void ToJsonStringTests()
        {
            var obj1 = int.MaxValue;
            Debug.WriteLine("obj1 - " + obj1.ToJsonString());

            var obj2 = new DateTime(2000, 12, 31);
            Debug.WriteLine("obj2 - " + obj2.ToJsonString());

            var obj3 = new ReferenceDataItem()
            {
                Code = "xyz",
                Description = "123"
            };
            Debug.WriteLine("obj3 - " + obj3.ToJsonString());

            IEnumerable<IReferenceDataSource> obj4 = new List<IReferenceDataSource>
            {
                new SqlReferenceDataSource(),
                new XmlReferenceDataSource(),
                new ApiReferenceDataSource()
            };
            Debug.WriteLine("obj4 - " + obj4.ToJsonString());
        }

        [TestMethod]
        public void GetJsonTypeDescriptionTests()
        {
            var obj1 = int.MaxValue;
            Debug.WriteLine("obj1 - " + obj1.GetJsonTypeDescription());

            var obj2 = new DateTime(2000, 12, 31);
            Debug.WriteLine("obj2 - " + obj2.GetJsonTypeDescription());

            var obj3 = new ReferenceDataItem()
            {
                Code = "xyz",
                Description = "123"
            };
            Debug.WriteLine("obj3 - " + obj3.GetJsonTypeDescription());

            IEnumerable<IReferenceDataSource> obj4 = new List<IReferenceDataSource>
            {
                new SqlReferenceDataSource(),
                new XmlReferenceDataSource(),
                new ApiReferenceDataSource()
            };
            Debug.WriteLine("obj4 - " + obj4.GetJsonTypeDescription());
        }
    }
}
