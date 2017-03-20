using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using My.Extensions.Advanced.Demo1;
using System.Threading;
using System.Diagnostics;

namespace My.Extensions.Advanced.Tests.Demo1
{
    [TestClass]
    public class InstrumentationTests
    {
        [TestMethod]
        public void GetTotalSeconds()
        {
            var instrumentation = new Instrumentation();
            instrumentation.Start();
            Thread.Sleep(750);
            Assert.AreEqual(1, instrumentation.GetElapsedTime());
        }

        [TestMethod]
        public void GetPreciseElapsedTime()
        {
            var instrumentation = new Instrumentation();
            instrumentation.Start();
            Thread.Sleep(750);
            var elapsed = instrumentation.GetPreciseElapsedTime();
            Debug.WriteLine("elapsed = " + elapsed);
            Assert.IsTrue(elapsed >= 0.75 && elapsed < 0.753);
        }

        [TestMethod]
        public void GetReallyPreciseElapsedTime()
        {
            var instrumentation = new Instrumentation();
            instrumentation.StartWithPrecision();
            Thread.Sleep(750);
            Assert.AreEqual(750, instrumentation.GetReallyPreciseElapsedTime());
        }
    }
}
