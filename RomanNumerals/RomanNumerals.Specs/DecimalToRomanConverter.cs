namespace RomanNumerals.Tests
{
    using Machine.Specifications;

    [Subject("Decimal to Roman Converter")]
    public class when_converting_1999_to_roman
    {
        private static string Result;

        Because of = () =>
            {
                Result = 1999.ToRoman();
            };

        It should_return_MCMXC = () =>
            {
                Result.ShouldBeEqualIgnoringCase("MCMXCIX");
            };
    }

    [Subject("Decimal to Roman Converter")]
    public class when_converting_0_to_roman
    {
        private static string Result;

        Because of = () =>
            {
                Result = 0.ToRoman();
            };

        It should_return_empty = () =>
            {
                Result.ShouldBeEqualIgnoringCase(string.Empty);
            };
    }
}