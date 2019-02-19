using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulatingArraysLieberry
{
    public class Exit
    {
        public void exit()
        {
            string nah;
            Console.WriteLine("Are you absolutely sure you want to exit?");
            nah = Console.ReadLine();
            if (nah.ToUpper() != "NO")
            {
                Console.WriteLine("Thanks for stopping by!!!!!!!");
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Menu menu = new Menu();
                menu.menu();
            }
        }
    }
}
