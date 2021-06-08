using System;
using CalcTemplate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() //Clear
        {
            var page = new MainWindow();
            Assert.IsTrue(page.TestMethod1("0"));
            Assert.IsFalse(page.TestMethod1());
        }

    }
}
