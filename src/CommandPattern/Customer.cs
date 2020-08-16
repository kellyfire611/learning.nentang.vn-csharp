using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern_OrderPizzaSteak
{
    /// <summary>
    /// Client
    /// </summary>
    class Customer
    {
        private Waiter waiter;
        
        public Customer(Waiter waiter)
        {
            this.waiter = waiter;
        }

        public void Request(string request)
        {
            ICommand command;
            if(request.ToLower().Equals("pizza"))
            {
                command = new Pizza();
            } else
            {
                command = new Steak();
            }
            waiter.TakeCommand(command);
        }
    }
}
