using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatingArraysLieberry
{
    public class ComputingMean
    {
        public void computingMean()
        {
            double sumA, sumB, sumC;
            double AverageA, AverageB, AverageC;
            int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
            int[] ArrayB = { 1, 3, 5, 7, 9 };
            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            sumA = Sum(ArrayA);
            AverageA = average(sumA, ArrayA.Length);
            Console.WriteLine(string.Join(",", ArrayA));
            Console.WriteLine($"The count of Array A is: {ArrayA.Length}");
            Console.WriteLine($"The sum of Array A is: {sumA}");
            Console.WriteLine($"The mean of Array A is: {AverageA} \n");

            sumB = Sum(ArrayB);
            AverageB = average(sumB, ArrayB.Length);
            Console.WriteLine(string.Join(",", ArrayB));
            Console.WriteLine($"The count of Array B is: {ArrayB.Length}");
            Console.WriteLine($"The sum of Array B is: {sumB}");
            Console.WriteLine($"The mean of Array B is: {AverageB} \n");

            sumC = Sum(ArrayC);
            AverageC = average(sumC, ArrayC.Length);
            Console.WriteLine(string.Join(",", ArrayC));
            Console.WriteLine($"The count of Array C is: {ArrayC.Length}");
            Console.WriteLine($"The sum of Array C is: {sumC}");
            Console.WriteLine($"The mean of Array C is: {AverageC} \n");

            Console.WriteLine("Press any key to go back to Main Menu");
            Console.ReadLine();
            Console.Clear();
        }
        public static double average(double sum, int length)
        {
            return sum / length;
        }
        public static double Sum( int[] Array)
        {
            double sum = 0;
            foreach (int i in Array)
            {
                sum += i;
            }
            return sum;
        }
    }
}
