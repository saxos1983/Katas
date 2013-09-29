namespace RomanNumerals.Tests
{
    using FluentAssertions;
    using NUnit.Framework;

    [TestFixture]
    public class DecimalToRomanConverterTest
    {
        private IDecimalToRomanConverter testee;

        [SetUp]
        public void SetUp()
        {
            this.testee = new DecimalToRomanConverter();
        }

        [TestCase(1, "I", TestName = "1 = I")]
        [TestCase(5, "V", TestName = "5 = V")]
        [TestCase(10, "X", TestName = "10 = X")]
        [TestCase(50, "L", TestName = "50 = L")]
        [TestCase(100, "C", TestName = "100 = C")]
        [TestCase(500, "D", TestName = "500 = D")]
        [TestCase(1000, "M", TestName = "1000 = M")]
        public void ShouldConvertToSingleRomanLetter(int decimalNumber, string expectedRomanNumber)
        {
            var result = this.testee.Convert(decimalNumber);
            result.Should().Be(expectedRomanNumber);
        }

        [TestCase(3, "III", TestName = "3 = III")]
        [TestCase(30, "XXX", TestName = "30 = XXX")]
        [TestCase(300, "CCC", TestName = "300 = CCC")]
        [TestCase(3000, "MMM", TestName = "3000 = MMM")]
        public void ShouldConvertToThreeEqualRomanLetters(int decimalNumber, string expectedRomanNumber)
        {
            var result = this.testee.Convert(decimalNumber);
            result.Should().Be(expectedRomanNumber);
        }

        [TestCase(2, "II", TestName = "2 = II")]
        [TestCase(20, "XX", TestName = "20 = XX")]
        [TestCase(200, "CC", TestName = "200 = CC")]
        [TestCase(2000, "MM", TestName = "2000 = MM")]
        public void ShouldConvertToTwoEqualRomanLetters(int decimalNumber, string expectedRomanNumber)
        {
            var result = this.testee.Convert(decimalNumber);
            result.Should().Be(expectedRomanNumber);
        }

        [TestCase(8, "VIII", TestName = "8 = VIII")]
        [TestCase(80, "LXXX", TestName = "80 = LXXX")]
        [TestCase(800, "DCCC", TestName = "800 = DCCC")]
        public void ShouldConvertToOneAndThreeEqualRomanLetters(int decimalNumber, string expectedRomanNumber)
        {
            var result = this.testee.Convert(decimalNumber);
            result.Should().Be(expectedRomanNumber);
        }

        [TestCase(25, "XVVV", TestName = "25 != XVVV")]
        [TestCase(250, "CLLL", TestName = "250 != CLLL")]
        [TestCase(2500, "MDDD", TestName = "2500 != MDDD")]
        public void ShouldNotConvertToOneAndThreeEqualRomanLetters(int decimalNumber, string expectedRomanNumber)
        {
            var result = this.testee.Convert(decimalNumber);
            result.Should().NotBe(expectedRomanNumber);
        }

        [TestCase(25, "XXV", TestName = "25 = XXV")]
        [TestCase(250, "CCL", TestName = "250 = CCL")]
        [TestCase(2500, "MMD", TestName = "2500 = MMD")]
        public void ShouldConvertToTwoEqualAndOneRomanLetter(int decimalNumber, string expectedRomanNumber)
        {
            var result = this.testee.Convert(decimalNumber);
            result.Should().Be(expectedRomanNumber);
        }

        [TestCase(11, "VVI", TestName = "11 != VVI")]
        [TestCase(110, "LLX", TestName = "110 != LLX")]
        [TestCase(1100, "DDC", TestName = "1100 != DDC")]
        public void ShouldNotConvertToTwoEqualAndOneRomanLetter(int decimalNumber, string expectedRomanNumber)
        {
            var result = this.testee.Convert(decimalNumber);
            result.Should().NotBe(expectedRomanNumber);
        }

        [TestCase(11, "XI", TestName = "11 = XI")]
        [TestCase(110, "CX", TestName = "110 = CX")]
        [TestCase(1100, "MC", TestName = "1100 = MC")]
        public void ShouldConvertToTwoCombinedRomanLetters(int decimalNumber, string expectedRomanNumber)
        {
            var result = this.testee.Convert(decimalNumber);
            result.Should().Be(expectedRomanNumber);
        }

        [TestCase(4, "IV", TestName = "4 = IV")]
        [TestCase(9, "IX", TestName = "9 = IX")]
        [TestCase(40, "XL", TestName = "40 = XL")]
        [TestCase(90, "XC", TestName = "90 = XC")]
        [TestCase(400, "CD", TestName = "400 = CD")]
        [TestCase(900, "CM", TestName = "900 = CM")]
        public void ShouldHandleSubstractionProperly(int decimalNumber, string expectedRomanNumber)
        {
            var result = this.testee.Convert(decimalNumber);
            result.Should().Be(expectedRomanNumber);
        }
    }
}