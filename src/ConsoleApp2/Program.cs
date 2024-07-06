using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vietcombank vietcombank = new Vietcombank();
            //vietcombank.NumberAccount = "0111000999";
            //vietcombank.Amount = 100;
            //vietcombank.ShowOwner();
            //vietcombank.Deposit(500);
            //vietcombank.WithDraw(200);
            //vietcombank.CheckBalance();

            //Console.WriteLine("------------------------------");

            //Agribank agribank = new Agribank();
            //agribank.SeriesID = "708657";
            //agribank.TotalNumber = 2000;
            //agribank.Deposit(500);
            //agribank.WithDraw(300);
            //agribank.CheckBalance();
            //agribank.WithDraw(100);
            //agribank.ShowOwner();

            IBankService bankService = null;
            Console.Write("Ban dang muon su dung ngan hang nao de giao dich voi chung toi:");
            string soThichKhachHang = Console.ReadLine();

            if(soThichKhachHang == "VCB")
            {
                bankService = new Vietcombank();
            } else if(soThichKhachHang == "ARG")
            {
                bankService = new Agribank();
            }

            bankService.Input();
            bankService.ShowOwner();
            bankService.Deposit(500);
            bankService.CheckBalance();
            bankService.WithDraw(100);

            Console.Read();
        }
    }
}
