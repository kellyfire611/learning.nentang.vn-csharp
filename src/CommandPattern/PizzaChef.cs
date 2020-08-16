using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern_OrderPizzaSteak
{
    /// <summary>
    /// Receiver
    /// </summary>
    class PizzaChef
    {
        public void MakePizza()
        {
            Console.WriteLine("I'm making pizza");
        }
    }
}
