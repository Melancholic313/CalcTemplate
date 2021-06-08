using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcTemplate.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Num1(bool first, string second)
        {
                var page = new MainWindow();
                Assert.IsTrue(page.number1());
        }
    }
}
