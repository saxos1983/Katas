namespace RomanNumerals.Tests
{
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class DecimalToRomanConverterTest
    {
        [TestCase(1, "I", TestName = "1 = I")]
        [TestCase(5, "V", TestName = "5 = V")]
        [TestCase(10, "X", TestName = "10 = X")]
        [TestCase(50, "L", TestName = "50 = L")]
        [TestCase(100, "C", TestName = "100 = C")]
        [TestCase(500, "D", TestName = "500 = D")]
        [TestCase(1000, "M", TestName = "1000 = M")]
        public void ShouldConvertToSingleRomanLetter(int decimalNumber, string expectedRomanNumber)
        {
            AssertEquals(decimalNumber, expectedRomanNumber);
        }

        [TestCase(3, "III", TestName = "3 = III")]
        [TestCase(30, "XXX", TestName = "30 = XXX")]
        [TestCase(300, "CCC", TestName = "300 = CCC")]
        [TestCase(3000, "MMM", TestName = "3000 = MMM")]
        public void ShouldConvertToThreeEqualRomanLetters(int decimalNumber, string expectedRomanNumber)
        {
            AssertEquals(decimalNumber, expectedRomanNumber);
        }

        [TestCase(2, "II", TestName = "2 = II")]
        [TestCase(20, "XX", TestName = "20 = XX")]
        [TestCase(200, "CC", TestName = "200 = CC")]
        [TestCase(2000, "MM", TestName = "2000 = MM")]
        public void ShouldConvertToTwoEqualRomanLetters(int decimalNumber, string expectedRomanNumber)
        {
            AssertEquals(decimalNumber, expectedRomanNumber);
        }

        [TestCase(8, "VIII", TestName = "8 = VIII")]
        [TestCase(80, "LXXX", TestName = "80 = LXXX")]
        [TestCase(800, "DCCC", TestName = "800 = DCCC")]
        public void ShouldConvertToOneAndThreeEqualRomanLetters(int decimalNumber, string expectedRomanNumber)
        {
            AssertEquals(decimalNumber, expectedRomanNumber);
        }

        [TestCase(25, "XXV", TestName = "25 = XXV")]
        [TestCase(250, "CCL", TestName = "250 = CCL")]
        [TestCase(2500, "MMD", TestName = "2500 = MMD")]
        public void ShouldConvertToTwoEqualAndOneRomanLetter(int decimalNumber, string expectedRomanNumber)
        {
            AssertEquals(decimalNumber, expectedRomanNumber);
        }

        [TestCase(6, "VI", TestName = "6 = VI")]
        [TestCase(60, "LX", TestName = "60 = LX")]
        [TestCase(600, "DC", TestName = "600 = DC")]
        [TestCase(11, "XI", TestName = "11 = XI")]
        [TestCase(110, "CX", TestName = "110 = CX")]
        [TestCase(1100, "MC", TestName = "1100 = MC")]
        public void ShouldConvertToTwoCombinedRomanLetters(int decimalNumber, string expectedRomanNumber)
        {
            AssertEquals(decimalNumber, expectedRomanNumber);
        }

        [TestCase(4, "IV", TestName = "4 = IV")]
        [TestCase(9, "IX", TestName = "9 = IX")]
        [TestCase(40, "XL", TestName = "40 = XL")]
        [TestCase(90, "XC", TestName = "90 = XC")]
        [TestCase(400, "CD", TestName = "400 = CD")]
        [TestCase(900, "CM", TestName = "900 = CM")]
        public void ShouldHandleSubstractionProperly(int decimalNumber, string expectedRomanNumber)
        {
            AssertEquals(decimalNumber, expectedRomanNumber);
        }
        
        [TestCase(23, "XXIII", TestName = "23 = XXIII")]
        [TestCase(28, "XXVIII", TestName = "28 = XXVIII")]
        [TestCase(59, "LIX", TestName = "59 = LIX")]
        [TestCase(2840, "MMDCCCXL", TestName = "2840 = MMDCCCXL")]
        [TestCase(1949, "MCMXLIX", TestName = "1949 = MCMXLIX")]
        public void ShouldConvertToCombinedRomanLetters(int decimalNumber, string expectedRomanNumber)
        {
            AssertEquals(decimalNumber, expectedRomanNumber);
        }

        private static void AssertEquals(int decimalNumber, string expectedRomanNumber)
        {
            decimalNumber.ToRoman().Should().Be(expectedRomanNumber);
        }
    }
}