using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern_OrderPizzaSteak
{
    class Pizza : ICommand
    {
        // Receiver
        private PizzaChef chef;

        public Pizza()
        {
            this.chef = new PizzaChef();
        }

        public void Execute()
        {
            chef.MakePizza();
        }
    }
}
