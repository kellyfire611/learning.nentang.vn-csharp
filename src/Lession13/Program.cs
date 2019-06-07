/*
C# Program to Find the Frequency of the Word ʺtheʺ in a given Sentence
This is a C# Program to find the frequency of the word ʺtheʺ in a given sentence.

Problem Description
This C# Program Finds the Frequency of the Word ʺtheʺ in a given Sentence.

Problem Solution
Here the frequency of ‘the’ in the given string is found.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex: we only loop once over the source, which reduces the cost of the method.
            string s1;
            Console.WriteLine("Enter the String : ");
            s1 = Console.ReadLine();
            Console.WriteLine(Counting.CountStringOccurrences(s1, "the"));
            Console.ReadLine();
        }
    }

    public static class Counting
    {
        public static int CountStringOccurrences(string text, string pattern)
        {
            int count = 0;
            int i = 0;
            while ((i = text.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                count++;
            }
            return count;
        }
    }
}
