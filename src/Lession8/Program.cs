/*
C# Program to Display the Date in Various Formats
This is a C# Program to display the date in various formats.

Problem Description
This C# Program Displays the Date in Various Formats.

Problem Solution
Here the Date is Displayed in various Formats.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specific date
            //DateTime date = new DateTime(2019, 6, 7);
            
            // Current date
            DateTime date = DateTime.Now;
            Console.WriteLine("Some Date Formats : ");
            Console.WriteLine("Date and Time:  {0}", date);
            Console.WriteLine(date.ToString("yyyy-MM-dd"));
            Console.WriteLine(date.ToString("dd-MMM-yy"));
            Console.WriteLine(date.ToString("M/d/yyyy"));
            Console.WriteLine(date.ToString("M/d/yy"));
            Console.WriteLine(date.ToString("MM/dd/yyyy"));
            Console.WriteLine(date.ToString("MM/dd/yy"));
            Console.WriteLine(date.ToString("yy/MM/dd"));
            Console.Read();
        }
    }
}
