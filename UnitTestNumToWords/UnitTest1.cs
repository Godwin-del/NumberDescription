using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestNumToWords
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NumbersToWords_18456002032011000007()
        {
            string NumberToConvert = "18,456,002,032,011,000,007";
            string NumberInWords = Exercise01.ExtensionMethods.ProcessInterger(NumberToConvert);
            Assert.AreEqual(NumberInWords, "Eighteen Quintillion Four Hundred And Fifty Six Quadrillion Two Trillion Thirty Two Billion Eleven Million And Seven", NumberInWords);
        }
        [TestMethod]
        public void NumbersToWords_2007()
        {
            string NumberToConvert = "2,007";
            string NumberInWords = Exercise01.ExtensionMethods.ProcessInterger(NumberToConvert);
            Assert.AreEqual(NumberInWords, "Two Thousand And Seven", NumberInWords);
        }
        [TestMethod]
        public void NumbersToWords_203309()
        {
            string NumberToConvert = "203,309";
            string NumberInWords = Exercise01.ExtensionMethods.ProcessInterger(NumberToConvert);
            Assert.AreEqual(NumberInWords, "Two Hundred And Three Thousand Three Hundred And Nine", NumberInWords);
        }
    }
}