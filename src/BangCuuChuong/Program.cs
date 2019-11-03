using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BangCuuChuong
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("=== BANG CUU CHUONG ===");
            
            // Thu thập thông tin Người dùng
            Console.Write("Ban muon in ra bao nhieu bang cuu chuong? ");
            num = Convert.ToInt32(Console.ReadLine());

            // In bảng cửu chương
            // Vòng lặp thứ 1 => lặp từ 1 đến num
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("--- Cuu chuong {0} ---", i);
                // Vòng lặp con nằm bên trong => lặp từ 1 -> 10
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, (i * j));
                }
                Console.WriteLine("--- Ket thuc cuu chuong ---");
            }

            // Dừng màn hình
            Console.ReadLine();
        }
    }
}
