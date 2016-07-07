using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class InconclusiveDemo
    {
        [TestMethod]
        public void Test1()
        {
            Assert.Inconclusive();
        }
    }
}
