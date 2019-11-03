/*
C# Program to Print a Binary Triangle
This is a C# Program to Print a binary triangle.

Problem Description
This C# Program Prints a Binary Triangle.

Problem Solution
Binary Triangle is a Triangle formed with 1’s and 0’s.Number of rows in the binary triangle is obtained from the user.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession5
{
    class Program
    {
        public static void Main(String[] args)
        {
            // Display Binary triangle
            BinaryTriangle();

            // Display Binary triable with formated
            BinaryTriangleFormated();
        }

        private static void BinaryTriangle()
        {
            int p, lastInt = 0, input;
            Console.Write("Enter the Number of Rows : ");
            input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                for (p = 1; p <= i; p++)
                {
                    if (lastInt == 1)
                    {
                        Console.Write("0");
                        lastInt = 0;
                    }
                    else if (lastInt == 0)
                    {
                        Console.Write("1");
                        lastInt = 1;
                    }
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }

        private static void BinaryTriangleFormated()
        {
            int i, j, k, numOfLines;
            Console.Write("Enter the number of lines:");
            numOfLines = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= numOfLines; i++)
            {
                for (k = numOfLines - i; k >= 1; k--)
                {
                    Console.Write(" ");
                }

                if (i % 2 != 0)
                {
                    for (j = 1; j <= i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("0 ");
                        }
                        else
                        {
                            Console.Write("1 ");
                        }
                    }
                }
                else if (i % 2 == 0)
                {
                    for (j = 1; j <= i; j++)
                    {
                        if (j % 2 == 0)
                        {
                            Console.Write("1 ");
                        }
                        else
                        {
                            Console.Write("0 ");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}