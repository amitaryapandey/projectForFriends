using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace amitproject
{
    [TestClass]
    public class HelloWorldUnitTest
    {
        [TestMethod]
        public void ShouldRun()
        {
            // arrange
            var amit = new Amit();

            // act
            var response = amit.Sumit();

            // assert
            Assert.IsTrue();
        }
    }
}
