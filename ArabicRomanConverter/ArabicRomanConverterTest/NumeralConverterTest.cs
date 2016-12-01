using System;
using ArabicRomanConverter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArabicRomanConverterTest
{
    [TestClass]
    public class NumeralConverterTest
    {
        [TestMethod]
        public void ToArabic_returns_0_when_empty_string()
        {
            var target = new NumeralConverter();
            var actual = target.ToArabic("");

            Assert.AreEqual(0, actual);
        }

        [TestMethod]
        public void ToArabic_return_1_when_I()
        {
            var target = new NumeralConverter();
            var actual = target.ToArabic("I");
             
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void ToArabic_return_10_when_X()
        {
            var target = new NumeralConverter();
            var actual = target.ToArabic("X");

            Assert.AreEqual(10, actual);
        }

        [TestMethod]
        public void ToArabic_return_4_when_IV()
        {
            var target = new NumeralConverter();
            var actual = target.ToArabic("IV");

            Assert.AreEqual(4, actual);
        }

        [TestMethod]
        public void ToArabic_return_6_when_VI()
        {
            var target = new NumeralConverter();
            var actual = target.ToArabic("VI");

            Assert.AreEqual(6, actual);
        }


        [TestMethod]
        public void ToArabic_return_2_when_II()
        {
            var target = new NumeralConverter();
            var actual = target.ToArabic("II");

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void ToArabic_return_9_when_IX()
        {
            var target = new NumeralConverter();
            var actual = target.ToArabic("IX");

            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void ToArabic_return_8_when_VIII()
        {
            var target = new NumeralConverter();
            var actual = target.ToArabic("VIII");

            Assert.AreEqual(8, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ToArabic_throws_exception_when_InvalidCharater()
        {
            var target = new NumeralConverter();
            target.ToArabic("S");            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ToArabic_throws_exception_when_InvalidFormat()
        {
            var target = new NumeralConverter();
            target.ToArabic("IIX");
        }
        
        [TestMethod]
        public void ToArabic_return_50_when_L()
        {
            var target = new NumeralConverter();
            var actual = target.ToArabic("L");

            Assert.AreEqual(50, actual);
        }

        [TestMethod]
        public void ToArabic_return_48_when_XLVIII()
        {
            var target = new NumeralConverter();
            var actual = target.ToArabic("XLVIII");

            Assert.AreEqual(48, actual);
        }

        [TestMethod]
        public void ToArabic_return_2016_when_MMXVI()
        {
            var target = new NumeralConverter();
            var actual = target.ToArabic("MMXVI");

            Assert.AreEqual(2016, actual);
        }

        [TestMethod]
        public void ToArabic_return_3888_when_MMMDCCCLXXXVIII()
        {
            var target = new NumeralConverter();
            var actual = target.ToArabic("MMMDCCCLXXXVIII");

            Assert.AreEqual(3888, actual);
        }
    }
}
