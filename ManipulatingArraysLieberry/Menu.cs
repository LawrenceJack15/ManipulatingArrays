using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatingArraysLieberry
{
    public class Menu
    {
        public void menu()
        {
            Restart:
            int caseSwitch = 0;
            Console.WriteLine("Please select a number:");
            Console.WriteLine("1.Computing the Mean");
            Console.WriteLine("2.Reversing Arrays");
            Console.WriteLine("3.Rotate Arrays");
            Console.WriteLine("4.Sorting Arrays");
            Console.WriteLine("5.Exit");
            caseSwitch = Convert.ToInt32(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    Console.Clear();
                    ComputingMean computingMean = new ComputingMean();
                    computingMean.computingMean();
                    goto Restart;
                case 2:
                    Console.Clear();
                    Reverse reverse = new Reverse();
                    reverse.reverse();
                    goto Restart;
                case 3:
                    Console.Clear();
                    Rotate rotate = new Rotate();
                    rotate.rotate();
                    goto Restart;
                case 4:
                    Console.Clear();
                    Sorting sorting = new Sorting();
                    sorting.sorting();
                    goto Restart;
                case 5:
                    Console.Clear();
                    Exit exit = new Exit();
                    exit.exit();
                    break;
            }
        }
    }
}
