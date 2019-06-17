using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace H4ck3rSp34k
{
    class Program
    {
        //HackerSpeak("javascript is cool") ➞ "j4v45cr1pt 15 c00l"
        //HackerSpeak("programming is fun") ➞ "pr0gr4mm1ng 15 fun"
        //HackerSpeak("become a coder") ➞ "b3c0m3 4 c0d3r"
        static string HackerSpeak(string msg)
        {
            msg = msg.Replace("a", "4");
            msg = msg.Replace("s", "5");
            msg = msg.Replace("i", "1");
            msg = msg.Replace("d", "6");
            msg = msg.Replace("o", "0");
            msg = msg.Replace("e", "3");
            
            return msg;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your secret message: ");
            string msgInput = Console.ReadLine();

            Console.WriteLine("Hacker speak: ");
            string hacked = HackerSpeak(msgInput);
            Console.WriteLine(hacked);

            Console.ReadKey();
        }
    }
}
