using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern_OrderPizzaSteak
{
    /// <summary>
    /// Receiver
    /// </summary>
    class SteakChef
    {
        public void MakeSteak()
        {
            Console.WriteLine("I'm making steak");
        }
    }
}
