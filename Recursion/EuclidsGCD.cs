namespace Recursion
{
    using System;
    using System.ComponentModel;

    [Description("Euclids Greatest Common Divisor")]
    public class EuclidsGCD
    {
        static void Main()
        {
            Console.Write("Euclids Greatest Common Divisor (GCD)");
            Console.Write("Please enter the first number: ");
            var number1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the first number: ");
            var number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci output for {0} and {1} is {2}", number1, number2, GCD(number1, number2));
        }

        public static int GCD(int x, int y)
        {
            if (x == 0)
            {
                return y;
            }
            if (y == 0)
            {
                return x;
            }

            int max = Math.Abs(Math.Max(x, y));
            int min = Math.Abs(Math.Min(x, y));
            return GCD(max % min, min);
        }
    }
}