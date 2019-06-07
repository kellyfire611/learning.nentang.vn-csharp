/*
C# Program to Generate Random Numbers
This is a C# Program to generate random numbers.

Problem Description
This C# Program Generates Random Numbers.

Problem Solution
Here random numbers are generated using the Random class and the next() in it.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Some Random Numbers that are generated are : ");
            for (int i = 1; i < 10; i++)
            {
                Randfunc();
            }
            Console.Read();
        }
        static Random r = new Random();
        static void Randfunc()
        {
            int n = r.Next();
            Console.WriteLine(n);
        }
    }
}
