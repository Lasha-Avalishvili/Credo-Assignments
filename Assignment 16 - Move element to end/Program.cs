using System;
using System.Collections.Generic;

namespace Move_element_to_end
{
    class Program
    {
        static void Main(string[] args)
        {
            var array =new List<int> { 2, 1, 2, 2, 2, 3, 4, 2 };
            var toMove = 2;

            int count = 0;
            Display(array);


            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] == toMove)
                {
                    array.Remove(toMove);
                    count++;
                }
            }

            if (array[^1] == toMove)
            {
                array.Remove(toMove);
                count++;
            }

            Display(array);

            for (int i = 0; i < count; i++)
            {
                array.Add(toMove);
            }

            Display(array);

        }

        public static void Display(List<int> list)
        {
            foreach (int number in list)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("*******************");
        }


    }
}