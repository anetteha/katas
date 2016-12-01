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
    }
}
