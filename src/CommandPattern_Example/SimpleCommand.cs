using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern_Example
{
    /// <summary>
    /// Concrete command
    /// </summary>
    class SimpleCommand : ICommand
    {
        private string _payload = string.Empty;

        public SimpleCommand(string payload)
        {
            this._payload = payload;
        }

        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({this._payload})");
        }
    }
}
