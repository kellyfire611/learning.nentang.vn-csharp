using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern_Example
{
    /// <summary>
    /// The Receiver classes contain some important business logic. They know how
    /// to perform all kinds of operations, associated with carrying out a
    /// request. In fact, any class may serve as a Receiver.
    /// </summary>
    public class Receiver
    {
        public void DoSomething(string a)
        {
            Console.WriteLine($"Receiver: Working on ({a}.)");
        }

        public void DoSomethingElse(string b)
        {
            Console.WriteLine($"Receiver: Also working on ({b}.)");
        }
    }
}
