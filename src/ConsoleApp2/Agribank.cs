using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Agribank : IBankService
    {
        public string SeriesID { get; set; }
        public decimal TotalNumber { get; set; }
        public void Input()
        {
            Console.WriteLine("[ARG] QUY KHACH vui long chon so tai khoan dep de mo: ");
            this.SeriesID = Console.ReadLine();
            Console.WriteLine("[ARG] QUY KHACH muon nap lan dau bao nhieu tien: ");
            this.TotalNumber = decimal.Parse(Console.ReadLine());
        }

        public decimal CheckBalance()
        {
            Console.WriteLine("[ARG] Thao tac kiem tra tai khoan cua QUY KHACH...");
            Console.WriteLine("[ARG] Tong so tien dang co: " + this.TotalNumber);
            return this.TotalNumber;
        }

        public bool Deposit(decimal amount)
        {
            Console.WriteLine("[ARG] Thao tac nap tien...");
            Console.WriteLine("[ARG] Ban dang nap so tien: " + amount);
            this.TotalNumber += amount;
            Console.WriteLine("[ARG] Tong so tien dang co: " + this.TotalNumber);

            return true;
        }

        public void ShowOwner()
        {
            Console.WriteLine("[ARG] So tai khoan QUY KHACH: " + this.SeriesID);
            Console.WriteLine("[ARG] Tong so tien dang co: " + this.TotalNumber);
        }

        public bool WithDraw(decimal amount)
        {
            Console.WriteLine("[ARG] Thao tac rut tien...");
            Console.WriteLine("[ARG] Ban dang rut so tien: " + amount);
            this.TotalNumber -= amount;
            Console.WriteLine("[ARG] Tong so tien dang co: " + this.TotalNumber);

            return true;
        }
    }
}
