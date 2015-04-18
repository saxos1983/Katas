using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using NUnit.Framework;

namespace Recursion.Tests
{
    using FluentAssertions;

    // ReSharper disable InconsistentNaming
    // ReSharper disable PossibleNullReferenceException

    [TestFixture]
    public class FibonacciTest
    {
        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 2)]
        [TestCase(4, 3)]
        [TestCase(10, 55)]
        [TestCase(35, 9227465)]
        public void Fibonacci_GivenCount_CorrectFibonacciResult(int count, int expectedResult)
        {
            var result = Fibonacci.CalculateFibonacci(count);

            result.Should().Be(expectedResult);
        }

        [Test]
        public void Fiboancci_GivenNonPositiveNumber_ThrowsException()
        {
            Action act = () => Fibonacci.CalculateFibonacci(0);

            act.ShouldThrow<ArgumentException>().WithMessage("Fibonacci works only on positive numbers.\r\nParameter name: n");
        }
    }

    // ReSharper restore InconsistentNaming
    // ReSharper restore PossibleNullReferenceException
}