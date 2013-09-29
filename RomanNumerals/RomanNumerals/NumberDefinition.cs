namespace RomanNumerals
{
    public class NumberDefinition
    {
        public int Decimal { get; private set; }
        public string Roman { get; private set; }

        public NumberDefinition(int decimalNumber, string roman)
        {
            Decimal = decimalNumber;
            Roman = roman;
        }
    }
}