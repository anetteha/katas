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
            NumeralConverter target = new NumeralConverter();
            int actual = target.ToArabic("VI");

            Assert.AreEqual(6, actual);
        }


        [TestMethod]
        public void ToArabic_return_2_when_II()
        {
            NumeralConverter target = new NumeralConverter();
            int actual = target.ToArabic("II");

            Assert.AreEqual(2, actual);
        }

        [TestMethod]
        public void ToArabic_return_9_when_IX()
        {
            NumeralConverter target = new NumeralConverter();
            int actual = target.ToArabic("IX");

            Assert.AreEqual(9, actual);
        }

        [TestMethod]
        public void ToArabic_return_8_when_VIII()
        {
            NumeralConverter target = new NumeralConverter();
            int actual = target.ToArabic("VIII");

            Assert.AreEqual(8, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ToArabic_throws_exception_when_InvalidCharater()
        {
            NumeralConverter target = new NumeralConverter();
            target.ToArabic("S");            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ToArabic_throws_exception_when_InvalidFormat()
        {
            NumeralConverter target = new NumeralConverter();
            int actual = target.ToArabic("IIX");
        }
        
        [TestMethod]
        public void ToArabic_return_50_when_L()
        {
            NumeralConverter target = new NumeralConverter();
            int actual = target.ToArabic("L");

            Assert.AreEqual(50, actual);
        }

        [TestMethod]
        public void ToArabic_return_48_when_XLVIII()
        {
            NumeralConverter target = new NumeralConverter();
            int actual = target.ToArabic("XLVIII");

            Assert.AreEqual(48, actual);
        }

        [TestMethod]
        public void ToArabic_return_2016_when_MMXVI()
        {
            NumeralConverter target = new NumeralConverter();
            int actual = target.ToArabic("MMXVI");

            Assert.AreEqual(2016, actual);
        }

        [TestMethod]
        public void ToArabic_return_3888_when_MMMDCCCLXXXVIII()
        {
            NumeralConverter target = new NumeralConverter();
            int actual = target.ToArabic("MMMDCCCLXXXVIII");

            Assert.AreEqual(3888, actual);
        }
    }
}
