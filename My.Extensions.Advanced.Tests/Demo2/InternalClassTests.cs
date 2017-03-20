﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My.Extensions.Advanced.Demo2;
using System.Reflection;

namespace My.Extensions.Advanced.Tests.Demo2
{
    [TestClass]
    public class InternalClassTests
    {
        [TestMethod]
        public void Class1()
        {
            var obj1 = new Class1();
            Assert.AreEqual("a", obj1.GetString1());
        }

        [TestMethod]
        public void Class2()
        {
            var obj2 = new Class1.Class2();
            Assert.AreEqual("b", obj2.GetString2());
        }

        [TestMethod]
        public void Class3()
        {
            var type3 = typeof(Class1.Class2).GetNestedType("Class3", BindingFlags.NonPublic);
            var methodInfo = type3.GetMethod("GetString3", BindingFlags.NonPublic | BindingFlags.Instance);
            var obj3 = Activator.CreateInstance(type3);
            Assert.AreEqual("c", methodInfo.Invoke(obj3, null));
        }
    }
}