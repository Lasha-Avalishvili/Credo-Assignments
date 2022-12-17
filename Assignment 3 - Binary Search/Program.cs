using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class Program
    {
        public static int BinarySearch(int[] array, int target)
        {

            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (target == array[i])
                {
                    a = i;
                    break;
                }
                else
                {
                    a = -1;
                }
            }

            return a;
        }
        static void Main(string[] args)
        {

            int[] array = { 0, 1, 5, 76, 234, 678 };
            int target = 76;
            var index = BinarySearch(array, target);
            Console.WriteLine($"index - {index}");
            Console.WriteLine($"Number - {BinarySearch(array, 75)}");
        }
    }
}