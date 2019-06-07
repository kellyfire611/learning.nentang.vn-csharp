/*
C# Program to Check whether the Entered Number is Even or Odd
This is a C# Program to check whether the entered number is even or odd.

Problem Description
This C# Program checks if a given integer is Odd or Even.

Problem Solution
Here if a given number is divisible by 2 with the remainder 0 then the number is an Even number. If the number is not divisible by 2 then that number will be an Odd number. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter a Number : ");
            i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
                Console.Read();
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
                Console.Read();
            }
        }
    }
}
