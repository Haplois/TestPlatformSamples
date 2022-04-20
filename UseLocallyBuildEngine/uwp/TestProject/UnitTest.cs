
using System;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.AppContainer;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue('1' == 49);
        }

        [UITestMethod]
        public void TestMethod2()
        {
            Assert.IsTrue('1' == 49);
        }
    }
}
