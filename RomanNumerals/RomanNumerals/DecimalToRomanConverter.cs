namespace RomanNumerals
{
    public class DecimalToRomanConverter : IDecimalToRomanConverter
    {
        private static readonly TupleList<int, string> RomanLetterDefinitions = new TupleList<int, string>
            {
                { 1000,  "M" },
                {  500,  "D" },
                {  100,  "C" },
                {   50,  "L" },
                {   10,  "X" },
                {    5,  "V" },
                {    1,  "I" },
            };

        public string Convert(int decimalNumber)
        {
            var result = string.Empty;

            foreach (var current in RomanLetterDefinitions)
            {
                while (decimalNumber >= current.Item1)
                {
                    decimalNumber -= current.Item1;
                    result += current.Item2;
                }
            }

            return result;
        }
    }
}