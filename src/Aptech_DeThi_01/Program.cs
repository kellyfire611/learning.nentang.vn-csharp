using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aptech_DeThi_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cau1();
            //Cau2();
            Cau3();

            Console.ReadLine();
        }

        static void Cau3()
        {
            bool isValid = false;
            DateTime dtBirthDay = DateTime.MinValue; // 1900-01-01

            // Nhập liệu ngày tháng
            do
            {
                try
                {
                    // Input
                    Console.Write("Please input your birthday (Year/Month/Day): ");
                    string birthDay = Console.ReadLine();

                    dtBirthDay = DateTime.ParseExact(birthDay, "yyyy/MM/dd", CultureInfo.InvariantCulture);
                    isValid = true;
                    Console.WriteLine(String.Format("Correct! Your birthday: {0:yyyy/MM/dd}", birthDay));

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Please input your birthday with format yyyy/MM/dd.");
                }
            } while (isValid != true);

            // Calculate the age of the user
            // (Ngày hiện tại - ngày sinh) = số ngày bạn sống / 365
            //var time = DateTime.Now - dtBirthDay;
            //int totalDays = (int)Math.Ceiling(time.TotalDays);
            //Console.WriteLine("Totals day: " + totalDays);

            //if(totalDays <= 31)
            //{
            //    Console.WriteLine(String.Format("You are: {0} days", totalDays));
            //} 
            //else if(totalDays < 365)
            //{
            //    int month = (int)Math.Ceiling((decimal)totalDays / 30);
            //    Console.WriteLine(String.Format("You are: {0} days"));
            //}

            // Năm hiện tại - Năm sinh
            int age = DateTime.Now.Year - dtBirthDay.Year;
            
            // Validate age
            if(age < 0 || age > 135)
            {
                Console.WriteLine("Your age invalid. PLease check your birthday carefully...");
            } 
            else
            {
                Console.WriteLine("Your age: " + age);
            }

            // Check today is your birthday
            if(DateTime.Now.Year ==  dtBirthDay.Year
                && DateTime.Now.Month == dtBirthDay.Month
                && DateTime.Now.Day == dtBirthDay.Day)
            {
                Console.WriteLine("Happy birthday to you!");
            }

            // Sun sign (cung hoàng đạo)
            DateTime dtCompareAriesFrom = new DateTime(dtBirthDay.Year, 03, 21);
            DateTime dtCompareAriesTo = new DateTime(dtBirthDay.Year, 04, 19);
            DateTime dtCompareTaurusFrom = new DateTime(dtBirthDay.Year, 04, 20);
            DateTime dtCompareTaurusTo = new DateTime(dtBirthDay.Year, 05, 20);
            DateTime dtCompareGeminiFrom = new DateTime(dtBirthDay.Year, 05, 21);
            DateTime dtCompareGeminiTo = new DateTime(dtBirthDay.Year, 06, 20);
            DateTime dtCompareCancerFrom = new DateTime(dtBirthDay.Year, 06, 21);
            DateTime dtCompareCancerTo = new DateTime(dtBirthDay.Year, 07, 22);
            DateTime dtCompareLeoFrom = new DateTime(dtBirthDay.Year, 07, 23);
            DateTime dtCompareLeoTo = new DateTime(dtBirthDay.Year, 08, 22);
            DateTime dtCompareVirgoFrom = new DateTime(dtBirthDay.Year, 08, 23);
            DateTime dtCompareVirgoTo = new DateTime(dtBirthDay.Year, 09, 22);
            DateTime dtCompareLibraFrom = new DateTime(dtBirthDay.Year, 09, 23);
            DateTime dtCompareLibraTo = new DateTime(dtBirthDay.Year, 10, 22);

            if (DateTime.Compare(dtCompareAriesFrom, dtBirthDay) <= 0
                && DateTime.Compare(dtBirthDay, dtCompareAriesTo) <= 0)
            {
                Console.WriteLine("Your sun sign is: Aries");
            }
            else if (
                DateTime.Compare(dtCompareTaurusFrom, dtBirthDay) <= 0
                && DateTime.Compare(dtBirthDay, dtCompareTaurusTo) <= 0)
            {
                Console.WriteLine("Your sun sign is: Taurus");
            }
            else if (
                DateTime.Compare(dtCompareGeminiFrom, dtBirthDay) <= 0
                &&
                DateTime.Compare(dtBirthDay, dtCompareGeminiTo) <= 0)
            {
                Console.WriteLine("Your sun sign is: Gemini");
            }
            else if (
                DateTime.Compare(dtCompareCancerFrom, dtBirthDay) <= 0
                && DateTime.Compare(dtBirthDay, dtCompareCancerTo) <= 0)
            {
                Console.WriteLine("Your sun sign is: Cancer");
            }
            else if (
                DateTime.Compare(dtCompareLeoFrom, dtBirthDay) <= 0
                && DateTime.Compare(dtBirthDay, dtCompareLeoTo) <= 0)
            {
                Console.WriteLine("Your sun sign is: Leo");
            }
            else if (
                DateTime.Compare(dtCompareVirgoFrom, dtBirthDay) <= 0
                && DateTime.Compare(dtBirthDay, dtCompareVirgoTo) <= 0)
            {
                Console.WriteLine("Your sun sign is: Virgo");
            }
            else if (
                DateTime.Compare(dtCompareLibraFrom, dtBirthDay) <= 0
                && DateTime.Compare(dtBirthDay, dtCompareLibraTo) <= 0)
            {
                Console.WriteLine("Your sun sign is: Libra");
            }
            else
            {
                Console.WriteLine("Your sun sign is: NOT AVAILABLE !!!");
            }
        }

        static void Cau2()
        {
            // Khởi tạo mảng
            string[] arrNational = { "Egyptian", "Indian", "American", "Chinese", "Filipino" };
            // Display array
            Console.WriteLine("Your array contents: ");
            foreach (string str in arrNational)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine();
            Console.WriteLine();

            // Sắp xếp
            Console.WriteLine("Array after sorting: ");
            string[] arrNationalOrdered = arrNational.OrderBy(z => z).ToArray();
            foreach (string str in arrNationalOrdered)
            {
                Console.WriteLine(str);
            }
        }

        static void Cau1()
        {
            // Câu 1
            int[] arrNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Display array
            Console.WriteLine("Array numbers: ");
            foreach (int i in arrNumbers)
            {
                Console.Write(i);
                if (i != arrNumbers.Last()) // Nếu không phải là phần tử cuối cùng thì in dấu ,
                {
                    Console.Write(',');
                }
            }
            Console.WriteLine();

            // Modify array
            DoubleNumber(arrNumbers);
            Console.WriteLine("Array number after modified: ");
            foreach (int i in arrNumbers)
            {
                Console.Write(i);
                if (i != arrNumbers.Last()) // Nếu không phải là phần tử cuối cùng thì in dấu ,
                {
                    Console.Write(',');
                }
            }
        }

        static void DoubleNumber(int[] arr)
        {
            for(int i=0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * 2;
            }
        }
    }
}
