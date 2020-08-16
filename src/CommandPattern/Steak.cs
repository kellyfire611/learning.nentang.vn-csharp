using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern_OrderPizzaSteak
{
    class Steak : ICommand
    {
        // Receiver
        private SteakChef chef;

        public Steak()
        {
            this.chef = new SteakChef();
        }

        public void Execute()
        {
            chef.MakeSteak();
        }
    }
}
