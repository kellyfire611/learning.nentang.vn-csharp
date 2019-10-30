using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperatorInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://learnxinyminutes.com/docs/csharp/
            ///////////////////////////////////////
            // Operators
            ///////////////////////////////////////
            Console.WriteLine("\n->Operators");

            int i1 = 1, i2 = 2; // Shorthand for multiple declarations

            // Arithmetic is straightforward
            Console.WriteLine(i1 + i2 - i1 * 3 / 7); // => 3

            // Modulo
            Console.WriteLine("11%3 = " + (11 % 3)); // => 2

            // Comparison operators
            Console.WriteLine("3 == 2? " + (3 == 2)); // => false
            Console.WriteLine("3 != 2? " + (3 != 2)); // => true
            Console.WriteLine("3 > 2? " + (3 > 2)); // => true
            Console.WriteLine("3 < 2? " + (3 < 2)); // => false
            Console.WriteLine("2 <= 2? " + (2 <= 2)); // => true
            Console.WriteLine("2 >= 2? " + (2 >= 2)); // => true

            // Bitwise operators!
            /*
            ~       Unary bitwise complement
            <<      Signed left shift
            >>      Signed right shift
            &       Bitwise AND
            ^       Bitwise exclusive OR
            |       Bitwise inclusive OR
            */

            // Incrementations
            int i = 0;
            Console.WriteLine("\n->Inc/Dec-rementation");
            Console.WriteLine(i++); //Prints "0", i = 1. Post-Incrementation
            Console.WriteLine(++i); //Prints "2", i = 2. Pre-Incrementation
            Console.WriteLine(i--); //Prints "2", i = 1. Post-Decrementation
            Console.WriteLine(--i); //Prints "0", i = 0. Pre-Decrementation
        }
    }
}
