using NUnit.Framework;

namespace Recursion.Tests
{
    using FluentAssertions;

    // ReSharper disable InconsistentNaming
    // ReSharper disable PossibleNullReferenceException

    [TestFixture]
    public class EuclidsGCDTest
    {
        [TestCase(252, 105, 21)]
        [TestCase(105, 252, 21)]
        [TestCase(-105, 252, 21)]
        [TestCase(-105, -252, 21)]
        [TestCase(17, 31, 1)]
        [TestCase(0, 0, 0)]
        public void GCD_GivenNumbers_CorrectGCDResult(int number1, int number2, int expectedResult)
        {
            var result = EuclidsGCD.GCD(number1, number2);

            result.Should().Be(expectedResult);
        }
    }

    // ReSharper restore InconsistentNaming
    // ReSharper restore PossibleNullReferenceException
}