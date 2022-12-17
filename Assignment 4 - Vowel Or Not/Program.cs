using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_Or_Not
{
    internal class Program
    {
        public static bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'ა', 'ე', 'ი', 'ო', 'უ' };
            bool isTrue = true;

            for (int i = 0; i < vowels.Length; i++)
            {
                if (c == vowels[i])
                {
                    isTrue = true;
                    break;
                }
                else
                {
                    isTrue = false;
                }
            }

            return isTrue;


        }
        static void Main(string[] args)
        {
            var isVowel = IsVowel('ა');
            Console.WriteLine(isVowel);

        }
    }
}