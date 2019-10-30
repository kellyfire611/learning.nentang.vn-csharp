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

            //
            // TODO: Viết chương trình tính Hằng đẳng thức
            // https://vi.wikipedia.org/wiki/B%E1%BA%A3y_h%E1%BA%B1ng_%C4%91%E1%BA%B3ng_th%E1%BB%A9c_%C4%91%C3%A1ng_nh%E1%BB%9B
            // Write a program to calculate (a+b)2.
            // Hint: (a * a + b * b + 2 * a * b)
            //




            //
            // TODO: Viết chương trình tính Diện tích hình tròn
            // https://www.mathsisfun.com/geometry/circle-area.html
            // Write a program to calculate formulae A = (π * r * 2).
            //



            //
            // TODO: Viết chương trình tính Diện tích Tam giác
            // https://www.mathsisfun.com/algebra/trig-area-triangle-without-right-angle.html
            //
        }
    }
}
