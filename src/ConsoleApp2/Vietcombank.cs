using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Vietcombank: IBankService
    {
        public string NumberAccount { get; set; }
        public decimal Amount { get; set; }
        public void Input()
        {
            Console.WriteLine("[VCB] Moi ban nhap so tai khoan: ");
            this.NumberAccount = Console.ReadLine();
            Console.WriteLine("[VCB] Moi ban nhap so tien dang co: ");
            this.Amount = decimal.Parse(Console.ReadLine());
        }

        public decimal CheckBalance()
        {
            Console.WriteLine("[VCB] Nghiep vu kiem tra tai khoan...");
            return this.Amount;
        }

        public bool Deposit(decimal amount)
        {
            Console.WriteLine("[VCB] Nghiep vu goi tien...");
            this.Amount += amount;
            Console.WriteLine("[VCB] So tien dang co trong tai khoan: " + this.Amount);

            return true;
        }

        public void ShowOwner()
        {
            Console.WriteLine("[VCB] Nghiep vu show thong tin tai khoan...");
            Console.WriteLine("[VCB] So tai khoan cua ban la: " + this.NumberAccount);
            Console.WriteLine("[VCB] So tien dang co trong tai khoan: " + this.Amount);
        }

        public bool WithDraw(decimal amount)
        {
            Console.WriteLine("[VCB] Nghiep vu rut tien...");
            Console.WriteLine("[VCB] Ban da rut: " + amount);
            this.Amount -= amount;
            Console.WriteLine("[VCB] So tien con lai trong tai khoan la: " + this.Amount);

            return true;
        }
    }
}
