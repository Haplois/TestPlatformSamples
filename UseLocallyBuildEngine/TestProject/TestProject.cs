using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public sealed class MyTestClass : MyTestClassBase
    {
        [TestMethod]
        [TestCategory("MyTests")]
        public void TestSomething()
        {
        }

        [TestMethod]
        [TestCategory("MyTests")]
        public void TestSomething2()
        {

        }
    }

    public abstract class MyTestClassBase
    {
        protected void TxestSomething2()
        {
            // Do something
        }
    }
}