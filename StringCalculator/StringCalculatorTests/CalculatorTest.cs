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

        [TestMethod]
        public void Add_returns_3_when_1_and_2()
        {
            // Arrange
            var target = new Calculator();

            // Act
            var result = target.Add("1,2");

            // Assert
            Assert.AreEqual(3.ToString(), result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Add_throws_argument_exception_when_input_is_letters()
        {
            // Arrange
            var target = new Calculator();

            // Act
            var result = target.Add("abc,abc");

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Add_throws_exception_if_input_does_not_contain_numbers()
        {
            // Arrange
            var target = new Calculator();

            // Act
            var result = target.Add("abc,a");
        }


        [TestMethod]
        public void Add_returns_10_when_3_and_3_and_4()
        {
            var target = new Calculator();

            var result = target.Add("3,3,4");

            Assert.AreEqual("10", result);
        }

        [TestMethod]
        public void Add_returns_4_when_2_and_space2()
        {
            var target = new Calculator();

            var result = target.Add("2, 2");

            Assert.AreEqual("4", result);
        }

        [TestMethod]
        public void Add_returns_5_when_given_10_and_negatve5()
        {
            var target = new Calculator();

            var result = target.Add("10,-5");

            Assert.AreEqual("5", result);
        }

        [TestMethod]
        public void Subtract_returns_a_string()
        {
            var target = new Calculator();

            // Act
            object result = target.Subtract("");

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result is string);
        }

        [TestMethod]
        public void Subtract_returns_1_when_3_and_2()
        {
            var target = new Calculator();

            // Act
            object result = target.Subtract("3,2");

            // Assert
            Assert.AreEqual(1.ToString(), result);
        }

        [TestMethod]
        public void Subtract_returns_negative2_when_input_5_and_5_and_2()
        {
            var target = new Calculator();

            // Act
            object result = target.Subtract("5,5,2");

            // Assert
            Assert.AreEqual("-2", result);
        }

        [TestMethod]
        public void Subtract_returns_zero_when_input_negative1_and_negative1()
        {
            var target = new Calculator();

            // Act
            object result = target.Subtract("-1,-1");

            // Assert
            Assert.AreEqual("0", result);
        }


    }
}
