using System.Collections.Generic;
using System.Linq;
using FizzBuzzCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzCoreTest
{
    [TestClass]
    public class FizzBuzzConverterTest
    {
        [TestMethod]
        public void Convert_1_returns_1()
        {
            // Arrange
            var target = new FizzBuzzConverter();

            // Act
            var actual = target.Convert(new List<int> {1});

            // Assert
            var expected = new List<string> {"1"};
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
}