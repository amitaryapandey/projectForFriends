using FluentAssertions;
using HelloWorld;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            var amit = Substitute.For<Amit123>();

            // act
            var response  = amit.Sumit();

            // assert
            response.Should().BeTrue();
        }

        [TestMethod]
        public void TestMethod2()
        {
            // arrange
            var add = Substitute.For<Add>();

            // act
            var response = add.Addition(1,3);

            // assert
            response.Should().Be(4);
        }
    }
}
