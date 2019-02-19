using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatingArraysLieberry
{
    public class Sorting
    {
        public void sorting()
        {
            int temp;
            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Console.WriteLine($"Array C initially contained the following values: {string.Join(",", ArrayC)}");
            do
            {
                temp = 0;
                for (int i = 0; i < ArrayC.Length - 1; i++)
                {
                    if (ArrayC[i] > ArrayC[i + 1])
                    {
                        temp = ArrayC[i];
                        ArrayC[i] = ArrayC[i + 1];
                        ArrayC[i + 1] = temp;
                    }
                }
            }
            while (temp > 0);
            {
                Console.WriteLine("After sorting:");
            }
            Console.WriteLine($"{string.Join(",", ArrayC)}\n");

            Console.WriteLine("Press any key to go back to Main Menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
