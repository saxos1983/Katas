namespace RomanNumerals
{
    public static class DecimalToRomanConverter
    {
        private static readonly NumberDefinition[] NumberDefinitions = new[]
        {
            new NumberDefinition( 1000,  "M" ),
            new NumberDefinition(  900, "CM" ),
            new NumberDefinition(  500,  "D" ),
            new NumberDefinition(  400, "CD" ),
            new NumberDefinition(  100,  "C" ),
            new NumberDefinition(   90, "XC" ),
            new NumberDefinition(   50,  "L" ),
            new NumberDefinition(   40, "XL" ),
            new NumberDefinition(   10,  "X" ),
            new NumberDefinition(    9, "IX" ),
            new NumberDefinition(    5,  "V" ),
            new NumberDefinition(    4, "IV" ),
            new NumberDefinition(    1,  "I" )
        };

        public static string ToRoman(this int decimalNumber)
        {
            var result = string.Empty;

            foreach (var current in NumberDefinitions)
            {
                while (decimalNumber >= current.Decimal)
                {
                    decimalNumber -= current.Decimal;
                    result += current.Roman;
                }
            }

            return result;
        }
    }
}