/*
C# Program to Get a Number and Display the Number with its Reverse
This is a C# Program to get a number and display the number with its reverse.

Problem Description
This C# Program Gets a Number and Display the Number with its Reverse.

Problem Solution
Here we obtain a number from the user and display the digits in the reverse order.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, reverse = 0;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                reverse = reverse * 10;
                reverse = reverse + num % 10;
                num = num / 10;
            }
            Console.WriteLine("Reverse of Entered Number is : " + reverse);
            Console.ReadLine();

        }
    }
}