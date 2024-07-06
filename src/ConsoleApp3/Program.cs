using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Đọc nội dung trong file
            string content = File.ReadAllText("data.txt");
            string patternEmail = @"email:\w+@(gmail.com|ctu.edu.vn)";

            string patternSoDienThoai = @"\d\d\d\d\d\d\d\d\d";
            
            // Trích xuất (extract) email
            MatchCollection mc = Regex.Matches(content, patternEmail);
            Console.WriteLine("Email trich xuat duoc:\n ");
            foreach (Match m in mc) {
                Console.WriteLine(m.ToString());
            }

            // Trích xuất (extract) số điện thoại
            string patternTel = @"tel:\d{6,}";
            MatchCollection mc2 = Regex.Matches(content, patternTel);
            Console.WriteLine("SDT trich xuat duoc: ");
            foreach (Match m in mc2)
            {
                Console.WriteLine(m.ToString());
            }

            // Replace Bad word
            string patternBadword = @"(Given|editor|no)";
            MatchCollection mc3 = Regex.Matches(content, patternBadword);
            Console.WriteLine("SDT trich xuat duoc: ");
            foreach (Match m in mc3)
            {
                Console.WriteLine(String.Format("Thay the badword [{0}] thanh ******", m));
                content = content.Replace(m.ToString(), "*****");
            }

            Console.WriteLine("Noi dung da thay the:");
            Console.WriteLine(content);

            Console.Read();
        }
    }
}
