using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    using System.ComponentModel;

    [Description("Fibonacci with Recursion")]
    public class Fibonacci
    {
        static void Main()
        {
            Console.Write("Please enter a number for the fibonacci sequence: ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine("Fibonacci output for {0} is {1}", number, CalculateFibonacci(number));
        }

        public static int CalculateFibonacci(int n)
        {
            if (n < 1)
            {
                throw new ArgumentOutOfRangeException("n", "Fibonacci works only on positive numbers.");
            }
            if (n == 1 || n == 2)
            {
                return 1;
            }

            return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        }
    }
}
