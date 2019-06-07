/*
C# Program to Check Whether the Entered Year is a Leap Year or Not
This is a C# Program to check whether the entered year is a leap year or not.

Problem Description
This C# Program Checks Whether the Entered Year is a Leap Year or Not.

Problem Solution
When A year is divided by 4. If the remainder becomes 0 then the year is called a leap year.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession7
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.readdata();
            obj.leap();
        }
        int y;
        public void readdata()
        {
            Console.WriteLine("Enter the Year in Four Digits : ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        public void leap()
        {
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year", y);
            }
            else
            {
                Console.WriteLine("{0} is not a Leap Year", y);
            }
            Console.ReadLine();
        }
    }
}
