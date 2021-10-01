using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the set of values
            for (int i = 1; i <= 50; i++)
            {
                // display fizzbuzz if value is divisible by both 3 and 5
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine(i + " is FizzBuzz");
                }
                // display fizz if value is divisible by 3
                else if (i % 3 == 0)
                {
                    Console.WriteLine(i + " is Fizz");
                }
                // display fizz if value is divisible by 5
                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + " is Buzz");
                }
                // not valid if value is not a divisible number by 3 or 5
                else
                {
                    Console.WriteLine(i + " is Not Valid");
                }
            }
        }
    }
}
