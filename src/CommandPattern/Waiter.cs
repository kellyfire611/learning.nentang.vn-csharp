using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern_OrderPizzaSteak
{
    /// <summary>
    /// Invoker
    /// </summary>
    class Waiter
    {
        public void TakeCommand(ICommand command)
        {
            Console.WriteLine("Waiter take new command [{0}]", command.ToString());
            command.Execute();
        }
    }
}
