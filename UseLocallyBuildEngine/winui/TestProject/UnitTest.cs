
using System;
using System.Threading.Tasks;

using Microsoft.UI.Xaml.Controls;
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
            // Arrange
            var button = new Button();
            App.ActiveWindow.Content = button;

            // Act
            button.Content = nameof(TestMethod2);

            // Assert
            Assert.AreEqual(nameof(TestMethod2), button.Content as string);
        }

        /*
        // Not supported yet
        [UITestMethod]
        public async Task TestMethod3()
        {
            // Arrange
            var button = new Button();
            App.ActiveWindow.Content = button;

            // Act
            button.Content = nameof(TestMethod3);

            // Assert
            Assert.AreEqual(nameof(TestMethod3), button.Content as string);
        }
        */
    }
}
