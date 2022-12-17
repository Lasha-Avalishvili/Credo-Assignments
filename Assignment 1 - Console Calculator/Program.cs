using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Concosle_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {      /// Entire program is in infinite while loop so it will repeat


                bool isNumber1 = true;
                bool isNumber2 = true;
                bool isChar = true;
                double num1 = 0, num2 = 0, result = 0;
                string string1, string2, mathOperation;




                while (isNumber1)        // TryParse method in while loop to get first number
                {

                    Console.Write("Enter first number: ");
                    string1 = Console.ReadLine();
                    isNumber1 = double.TryParse(string1, out num1);
                    if (isNumber1 == true)
                    {
                        isNumber1 = false;
                    }
                    else
                    {
                        isNumber1 = true;
                        Console.WriteLine("That is not a number!");

                    }
                }


                while (isNumber2)    // TryParse method in while loop to get second number
                {

                    Console.Write("Enter second number: ");
                    string2 = Console.ReadLine();
                    isNumber2 = double.TryParse(string2, out num2);
                    if (isNumber2 == true)
                    {
                        isNumber2 = false;
                    }
                    else
                    {
                        isNumber2 = true;
                        Console.WriteLine("That is not a number!");
                    }
                }


                do     // swith statement in do while loop to get math operation and display the result
                {
                    Console.Write("Enter Math operation (+ - * /): ");
                    mathOperation = Console.ReadLine();
                    switch (mathOperation)
                    {
                        case "+":
                            result = num1 + num2;
                            Console.WriteLine($"{num1} {mathOperation} {num2} = {result}\n");
                            isChar = true; break;
                        case "-":
                            result = num1 - num2;
                            Console.WriteLine($"{num1} {mathOperation} {num2} = {result}\n");
                            isChar = true;
                            break;
                        case "*":
                            result = num1 * num2;
                            Console.WriteLine($"{num1} {mathOperation} {num2} = {result}\n");
                            isChar = true;
                            break;
                        case "/":
                            result = num1 / num2;
                            Console.WriteLine($"{num1} {mathOperation} {num2} = {result}\n");
                            isChar = true;
                            break;
                        default:
                            Console.WriteLine("Incorrect operation!");
                            isChar = false;
                            break;

                    }

                } while (isChar == false);

            }

        }
    }
}