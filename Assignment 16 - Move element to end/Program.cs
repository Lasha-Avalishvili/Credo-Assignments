using System;
using System.Collections.Generic;

namespace homework_16_trial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = new List<int>() { 1, 2, 3, 4, 5, 6, 3, 3, 6, 4, 3 };
            int toMove = 3;
            int count = 0;
            Display(list1);
            Console.WriteLine("--------------------------------");

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] == toMove)
                {
                    list1.Remove(toMove);
                    count++;
                }
            }

            if (list1[^1] == toMove)
            {
                list1.Remove(toMove);
                count++;
            }

            for (int i = 0; i < count; i++)
            {
                list1.Add(toMove);
            }

            Display(list1);
        }
        public static void Display(List<int> list)
        {
            Console.WriteLine(string.Join(", ", list));
        }
    }
}