using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern_OrderPizzaSteak
{
    /// <summary>
    /// Command Interface
    /// </summary>
    interface ICommand
    {
        void Execute();
    }
}
