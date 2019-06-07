/*
C# Program to Get a Number and Display the Sum of the Digits
This is a C# Program to get a number and display the sum of the digits.

Problem Description
This C# Program Gets a Number and Display the Sum of the Digits.

Problem Solution
The digit sum of a given integer is the sum of all its digits.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, r;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                r = num % 10;
                num = num / 10;
                sum = sum + r;
            }
            Console.WriteLine("Sum of Digits of the Number : " + sum);
            Console.ReadLine();

        }
    }
}