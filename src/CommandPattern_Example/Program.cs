using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client conde can parameterize an invoker with any commands.
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say, Hi"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send Email", "Save Report"));

            invoker.DoSomethingImportant();

            Console.ReadLine();
        }
    }
}
