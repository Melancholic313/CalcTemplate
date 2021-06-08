using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcTemplate;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Read()
        {
            var page = new MainWindow();
            Assert.IsTrue(page.Test_btn1(""));
            Assert.IsTrue(page.Test_btn1("5"));
        }

        [TestMethod]
        public void Test_Rezult()
        {
            var page = new MainWindow();
            Assert.IsFalse(page.Test_btnResult("", "", ""));
            Assert.IsTrue(page.Test_btnResult("+", "2", "4"));
            Assert.IsTrue(page.Test_btnResult("-", "4", "3"));
            Assert.IsTrue(page.Test_btnResult("*", "1", "1"));
            Assert.IsTrue(page.Test_btnResult("/", "1", "1"));
        }

        [TestMethod]
        public void Test_btnClear()
        {
            var page = new MainWindow();
            Assert.IsTrue(page.Test_btnClear());
        }
    }
}

}
