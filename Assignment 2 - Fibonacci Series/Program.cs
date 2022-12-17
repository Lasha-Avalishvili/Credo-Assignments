using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Series
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool isNumber = true;
            string str;
            long number = 0;


            while (isNumber)        // TryParse method in while loop to get the number
            {

                Console.Write("Enter the number: ");
                str = Console.ReadLine();
                isNumber = long.TryParse(str, out number);
                if (isNumber == true)
                {
                    isNumber = false;
                }
                else
                {
                    isNumber = true;
                    Console.WriteLine("That is not a number!");

                }
            }

            Console.WriteLine(CalculateFibonacci(number));

        }


        public static long CalculateFibonacci(long n)   // Fibonacci Calculator
        {
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
                return CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
        }

    }
}