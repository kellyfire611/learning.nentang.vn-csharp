/*
C# Program to Display the ATM Transaction
This is a C# Program to display the atm transaction.

Problem Description
This C# Program Displays the ATM Transaction.

Problem Solution
Here The types of ATM transaction are
1) Balance checking
2) Cash withdrawal
3) Cash deposition.
You can opt any of the above transaction according to your need of transaction.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lession10
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 1000, deposit, withdraw;
            int choice, pin = 0;
            bool continueAsk = true;
            Console.WriteLine("Enter Your Pin Number ");
            pin = int.Parse(Console.ReadLine());
            while (continueAsk)
            {
                Console.WriteLine("********Welcome to ATM Service**************");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Withdraw Cash");
                Console.WriteLine("3. Deposit Cash");
                Console.WriteLine("4. Quit");
                Console.WriteLine("*********************************************");
                Console.WriteLine("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(" YOUR BALANCE IN Rs : {0} ", amount);
                        break;
                    case 2:
                        Console.WriteLine(" ENTER THE AMOUNT TO WITHDRAW: ");
                        withdraw = int.Parse(Console.ReadLine());
                        if (withdraw % 100 != 0)
                        {
                            Console.WriteLine(" PLEASE ENTER THE AMOUNT IN MULTIPLES OF 100");
                        }
                        else if (withdraw > (amount - 500))
                        {
                            Console.WriteLine(" INSUFFICENT BALANCE");
                        }
                        else
                        {
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
    }
}
