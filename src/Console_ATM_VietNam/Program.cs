using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console_ATM_VietNam
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 15000000, deposit, withdraw;
            int choice, pin = 0;
            bool continueAsk = true;
            Console.Write("Enter Your Pin Number: ");
            pin = int.Parse(Console.ReadLine());
            if(pin != 1234)
            {
                Console.WriteLine("Sorry, dont correct PIN number. Please try again!");
                Console.Read();
                return;
            }
            while (continueAsk)
            {
                Console.WriteLine("********Welcome to ATM Service**************");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Withdraw Cash");
                Console.WriteLine("3. Deposit Cash");
                Console.WriteLine("4. Quit");
                Console.WriteLine("*********************************************");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(" YOUR BALANCE IN Rs : {0} ", amount);
                        break;
                    case 2:
                        Console.WriteLine(" ENTER THE AMOUNT TO WITHDRAW: ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 10000 != 0)
                        {
                            Console.WriteLine(" PLEASE ENTER THE AMOUNT IN MULTIPLES OF 100");
                        }
                        else if (withdraw > (amount - 50000)) // Số tiền tối thiểu còn trong tài khoản (sau khi rút tiền) phải > 50000
                        {
                            Console.WriteLine(" INSUFFICENT BALANCE");
                        }
                        else
                        {
                            CacPhuongAnRutTien(withdraw);
                            amount = amount - withdraw;
                            Console.WriteLine(" PLEASE COLLECT CASH");
                            Console.WriteLine(" YOUR CURRENT BALANCE IS {0}", amount);
                        }
                        break;
                    case 3:
                        Console.WriteLine(" ENTER THE AMOUNT TO DEPOSIT");
                        deposit = int.Parse(Console.ReadLine());
                        amount = amount + deposit;
                        Console.WriteLine("YOUR BALANCE IS {0}", amount);
                        break;
                    case 4:
                        Console.WriteLine(" THANK U USING ATM");
                        continueAsk = false;
                        break;
                }
            }
            Console.WriteLine(" THANKS FOR USING OUT ATM SERVICE");
            Console.Read();
        }

        /// <summary>
        /// Tính toán phương án rút tiền theo các mệnh giá 500000đ, 200000đ, 100000đ, 50000đ, 20000đ, 10000đ
        /// </summary>
        /// <param name="withdraw">Số tiền cần rút</param>
        private static void CacPhuongAnRutTien(int withdraw)
        {
            // Chỉ được rút tối thiểu số tiền là bội số của 10000đ
            if (withdraw % 10000 != 0)
            {
                Console.WriteLine("So tien rut phai la boi so cua 10000d");
                return;
            }

            // Các mệnh giá tiền có thể đưa cho người dùng khi rút số tiền `withdraw`
            // 500000, 200000, 100000, 50000, 20000, 10000
            //    x1     x2      x3      x4     x5     x6
            // Phương trình rút tiền:
            // 500000*x1 + 200000*x2 + 100000*x3 + 50000*x4 + 20000*x5 + 10000*x6 = `withdraw`
            Console.WriteLine("Cac phuong an thoi tien co the co: ");
            int x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0, x6 = 0;
            while (x1 <= (withdraw / 500000))
            {
                while (x2 <= (withdraw / 200000))
                {
                    while (x3 <= (withdraw / 100000))
                    {
                        while (x4 <= (withdraw / 50000))
                        {
                            while (x5 <= (withdraw / 20000))
                            {
                                while (x6 <= (withdraw / 10000))
                                {
                                    if (500000 * x1 + 200000 * x2 + 100000 * x3 + 50000 * x4 + 20000 * x5 + 10000 * x6 == withdraw)
                                    {
                                        Console.WriteLine("500000={0} to; 200000={1} to; 100000={2} to; 50000={3} to; 20000={4} to; 10000={5} to", x1, x2, x3, x4, x5, x6);
                                    }
                                    x6++;
                                }
                                x6 = 0;
                                x5++;
                            }
                            x5 = 0;
                            x4++;
                        }
                        x4 = 0;
                        x3++;
                    }
                    x3 = 0;
                    x2++;
                }
                x2 = 0;
                x1++;
            }
        }
    }
}
