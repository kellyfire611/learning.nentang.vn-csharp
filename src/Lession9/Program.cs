/*
C# Program to Compare Two Dates
This is a C# Program to compare two dates.

Problem Description
This C# Program Compares Two Dates.

Problem Solution
Here two dates are compared and the date which occurs first is displayed.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession9
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime sd = new DateTime(2019, 06, 07);
            Console.WriteLine("Starting Date : {0}", sd);
            DateTime ed = sd.AddDays(10);
            Console.WriteLine("Ending Date   : {0}", ed);
            // Start date compare with End date
            if (sd < ed)
                Console.WriteLine("{0} Occurs Before {1}", sd, ed);
            Console.Read();
        }
    }
}
