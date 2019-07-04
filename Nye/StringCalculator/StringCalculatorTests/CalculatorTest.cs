using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;

namespace StringCalculatorTests
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add_returns_a_string()
        {
            // Arrange
            var target = new Calculator();

            // Act
            object result = target.Add("");

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result is string);
        }
    }
}
