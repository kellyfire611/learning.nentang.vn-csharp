using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IBankService
    {
        decimal CheckBalance();
        bool WithDraw(decimal amount);
        bool Deposit(decimal amount);
        void ShowOwner();
        void Input();
    }
}
