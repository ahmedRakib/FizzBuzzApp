using System;

namespace FizzBuzzApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Press a Number");

            int aNumber;

            if (int.TryParse(Console.ReadLine(), out aNumber))
            {
                if (aNumber % 3 == 0 && aNumber % 5 == 0)
                {
                    Console.WriteLine("FiZZBuZZ");
                }

                else if (aNumber % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

                else if (aNumber % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                else
                {
                    Console.WriteLine("Not A FiZZ or Buzz Word. Not Even FizzBuzz ");
                }
            }

            else
            {
                Console.WriteLine("Man!!! I asked to enter a number. -_- ");
            }

            Console.ReadKey();
        }
    }
}
