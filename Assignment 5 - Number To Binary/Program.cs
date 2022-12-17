using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Number_To_Binary
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine(ToBinary(245));
        }

        public static string ToBinary(long number)
        {

            string str = "";
            string str2 = "";
            while (number > 0)           // creating string whichs needs to be reversed 
            {
                if (number % 2 == 0)
                {
                    str += "0";
                    number /= 2;
                }
                else
                {
                    str += "1";
                    number /= 2;
                }

            }

            char[] charArray = str.ToCharArray();         // converting string to char array and reversing it
            Array.Reverse(charArray);

            foreach (char item in charArray)          // adding reversed chararray elements to an empty string
            {
                str2 += item;
            }

            return str2;
        }

    }
}