using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatingArraysLieberry
{
    public class Rotate
    {
        public void rotate()
        {
            int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
            int[] ArrayB = { 1, 3, 5, 7, 9 };
            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            int[] RotateA, RotateB, RotateC;
            int j;
            int caseSwitch = 0;

            Console.WriteLine("Please select a number:");
            Console.WriteLine("1.Rotate array A two places to the left");
            Console.WriteLine("2.Rotate array B two places to the right");
            Console.WriteLine("3.Rotate array C four places to the left");
            Console.WriteLine("4.Go back to Main Menu");
            caseSwitch = Convert.ToInt32(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    Console.Clear();
                    j = 2;
                    Console.WriteLine($"Array A initially contained the following values: {string.Join(",", ArrayA)}");
                    RotateA = Shift(ArrayA, j, "Left");
                    Console.WriteLine($"After rotating: {string.Join(",", RotateA)}\n");
                    rotate();
                    break;
                case 2:
                    Console.Clear();
                    j = 8;
                    Console.WriteLine($"Array B initially contained the following values: {string.Join(",", ArrayB)}");
                    RotateB = Shift(ArrayB, j, "Right");
                    Console.WriteLine($"After rotating: {string.Join(",", RotateB)}\n");
                    rotate();
                    break;
                case 3:
                    Console.Clear();
                    j = 4;
                    Console.WriteLine($"Array C initially contained the following values: {string.Join(",", ArrayC)}");
                    RotateC = Shift(ArrayC, j, "Left");
                    Console.WriteLine($"After rotating: {string.Join(",", RotateC)}\n");
                    rotate();
                    break;
                case 4:
                    Console.Clear();
                    Menu menu = new Menu();
                    menu.menu();
                    break;
            }
        }
        public static int[] Shift(int[] Array,int j, string Direction)
        {
            int[] RotateArray = new int[Array.Length];
            for (int i = 0; i < Array.Length; i++)
            {
                RotateArray[i] = Array[(j + i) % Array.Length];
            }
            return RotateArray;
        }
    }
}
