﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My.Extensions.Samples.Demo3;
using My.Extensions.Samples.Demo3.Impl;
using System.Linq;

namespace My.Extensions.Tests.Demo3
{
    [TestClass]
    public class ReferenceDataSourceTests
    {
        [TestMethod]
        public void GetItems()
        {
            IReferenceDataSource source;
            source = new SqlReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
            source = new XmlReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
            source = new ApiReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
        }

        [TestMethod]
        public void GetItemsByCode_Sql()
        {
            IReferenceDataSource source;
            source = new SqlReferenceDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());
        }

        [TestMethod]
        public void GetItemsByCode_Xml()
        {
            var source = new XmlReferenceDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());
        }
    }
}
