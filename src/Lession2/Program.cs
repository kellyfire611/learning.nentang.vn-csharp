/*
C# Program to Swap 2 Numbers
This is a C# Program to swap 2 numbers.

Problem Description
This C# Program Swaps 2 Numbers.

Problem Solution
It obtains two numbers from the user and swaps the numbers using a temporary variable.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Lession2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.Write("\nEnter the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
            Console.Read();
        }
    }
}
