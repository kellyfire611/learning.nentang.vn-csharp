/*
C# Program to Accept the Height of a Person & Categorize as Tall, Dwarf or Average
This is a C# Program to accept the height of a person & categorize as tall, dwarf or average.

Problem Description
This C# Program accepts the height of a person & categorizes it as Tall, Dwarf or Average.

Problem Solution
Here the program accepts height of a person in centimeters. Then, it categorizes it based on the height. If height is less than 150 centimeter, then the person is dwarf and if the height is between 151 to 165 then it is categorized as average and if the height is between 165 to 175 then it is categorized as tall.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession12
{
    class Program
    {
        static void Main(string[] args)
        {
            float height;
            Console.WriteLine("Enter the Height (in centimeters) ");
            height = int.Parse(Console.ReadLine());
            if (height < 150.0)
                Console.WriteLine("Dwarf ");
            else if ((height >= 150.0) && (height <= 165.0))
                Console.WriteLine(" Average Height ");
            else if ((height >= 165.0) && (height <= 195.0))    
                Console.WriteLine("Taller ");
            else
                Console.WriteLine("Abnormal height ");

            Console.Read();
        }
    }
}
