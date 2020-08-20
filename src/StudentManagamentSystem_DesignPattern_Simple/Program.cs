using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagamentSystem_DesignPattern_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            // Show Main menu
            Menu mnu = Menu.GetInstance();
            mnu.ShowMainMenu();

            // Wait console for read
            Console.Read();
        }
    }
}
