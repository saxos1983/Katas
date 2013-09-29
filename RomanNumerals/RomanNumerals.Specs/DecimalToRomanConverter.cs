using Machine.Specifications;

namespace RomanNumerals.Tests
{
    [Subject("Decimal to Roman Converter")]
    public class when_converting_1999_to_roman
    {
        private static IDecimalToRomanConverter Subject;
        private static string Result;

        Establish context = () =>
            {
                Subject = new DecimalToRomanConverter();
            };

        Because of = () =>
            {
                Result = Subject.Convert(1999);
            };

        It should_return_MCMXC = () =>
            {
                Result.ShouldBeEqualIgnoringCase("MCMXC");
            };
    }
}