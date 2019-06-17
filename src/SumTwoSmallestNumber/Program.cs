using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumTwoSmallestNumber
{
    class Program
    {
        //SumSmallest([19, 5, 42, 2, 77]) ➞ 7
        //SumSmallest([10, 343445353, 3453445, 3453545353453]) ➞ 3453455
        //SumSmallest([2, 9, 6, -1]) ➞ 8
        //SumSmallest([879, 953, 694, -847, 342, 221, -91, -723, 791, -587]) ➞ 563
        //SumSmallest([3683, 2902, 3951, -475, 1617, -2385]) ➞ 4519
        public static int SumSmallest(List<int> lstNumber)
        {
            return lstNumber.Where(z => z > 0).OrderBy(z => z).Take(2).Sum();
        }

        static void Main(string[] args)
        {
            List<int> lstNumber = new List<int>();
            bool isContinue = true;
            do
            {
                Console.Write("Input number (enter N for quit): ");
                string input = Console.ReadLine();
                if(input == "N")
                {
                    isContinue = false;
                    break;
                }

                int numberInput = Convert.ToInt32(input);
                lstNumber.Add(numberInput);
            } while (isContinue);

            Console.WriteLine("Sum of Two smallest number is: {0}", SumSmallest(lstNumber));

            Console.ReadKey();
        }
    }
}
