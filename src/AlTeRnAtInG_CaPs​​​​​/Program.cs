using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlTeRnAtInG_CaPs​​​​​
{
    class Program
    {
        //AlternatingCaps("Hello") ➞ "HeLlO"
        //AlternatingCaps("Hey, how are you?") ➞ "HeY, hOw aRe yOu?"
        //AlternatingCaps("OMG!!! This website is awesome!!") ➞ "OmG!!! tHiS WeBsItE Is aWeSoMe!!"
        //Rules: 
        //- First character is alway UPPERCASE
        static string AlternatingCaps(string msg)
        {
            char[] characters = msg.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                if ((i % 2) == 0) //0, 2, 4, 6 ...
                {
                    characters[i] = Char.ToUpper(characters[i]);
                }
                else //1, 3, 5, 7, ...
                {
                    characters[i] = Char.ToLower(characters[i]);
                }
            }

            return new string(characters);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your secret message: ");
            string msgInput = Console.ReadLine();

            Console.WriteLine("Hacker speak: ");
            string hacked = AlternatingCaps(msgInput);
            Console.WriteLine(hacked);

            Console.ReadKey();
        }
    }
}
