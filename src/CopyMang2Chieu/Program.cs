using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CopyMang2Chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int i, j;

            // Storing user input in arr1
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Enter array value:\t");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //copying value of arr1 to arr2
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    arr2[i, j] = arr1[i, j];
                }
            }

            Console.WriteLine("\n\nElements of second array are:\n\n");
            //Printing the arr2 value
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 3; j++)
                {
                    Console.Write("\t{0}", arr2[i, j]);
                }
            }

            Console.ReadLine();
        }
    }
}
