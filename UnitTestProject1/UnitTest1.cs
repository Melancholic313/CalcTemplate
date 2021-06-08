using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalcTemplate;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_go()
        {
            var page = new MainWindow();
            Assert.IsTrue(page.Test_go_reg());
        }
        [TestMethod]
        public void Test_Vhod()
        {
            var page = new Auth();
            Assert.IsTrue(page.Test_Vhod("test", "12345"));
            Assert.IsFalse(page.Test_Vhod("", ""));
            Assert.IsFalse(page.Test_Vhod("Golub", "many"));
        }
        [TestMethod]
        public void Test_Reg()
        {
            var page = new Reg();
            Assert.IsFalse(page.Test_reg("test", "12345"));
            Assert.IsFalse(page.Test_reg("", ""));
            Assert.IsTrue(page.Test_reg("Migula", "mi1"));
        }
        [TestMethod]
        public void Test_Open_Menu()
        {
            var page = new MainWindow();
            Assert.IsTrue(page.Test_open_menu());
        }
        [TestMethod]
        public void Test_Close_Menu()
        {
            var page = new MainWindow();
            Assert.IsTrue(page.Test_Close_menu());
        }
        [TestMethod]
        public void Test_Close()
        {
            var page = new Auth();
            Assert.IsTrue(page.Test_Close());
        }
    }
}
