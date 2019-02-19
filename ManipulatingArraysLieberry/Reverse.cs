using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatingArraysLieberry
{
    public class Reverse
    {
        public void reverse()
        {
            int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
            int[] ArrayB = { 1, 3, 5, 7, 9 };
            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            int[] ReverseA, ReverseB, ReverseC;

            Console.WriteLine($"Array A initially contained the following values: {string.Join(",",ArrayA)}");
            ReverseA = ReverseArray(ArrayA);
            Console.WriteLine($"After reversing: {string.Join(",",ReverseA)}\n");

            Console.WriteLine($"Array B initially contained the following values: {string.Join(",",ArrayB)}");
            ReverseB = ReverseArray(ArrayB);
            Console.WriteLine($"After reversing: {string.Join(",", ReverseB)}\n");

            Console.WriteLine($"Array C initially contained the following values: {string.Join(",", ArrayC)}");
            ReverseC = ReverseArray(ArrayC);
            Console.WriteLine($"After reversing: {string.Join(",", ReverseC)}\n");
            Console.WriteLine("Press any key to go back to Main Menu");
            Console.ReadLine();
            Console.Clear();
        }
        public static int[] ReverseArray(int[] Array)
        {
            int j = 0;
            int[] ReverseArray = new int[Array.Length];
            for (int i = Array.Length - 1; i >= 0; i--)
            {
                ReverseArray[j] = Array[i];
                j++;
            }
            return ReverseArray;
        }
    }
}
