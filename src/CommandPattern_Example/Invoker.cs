using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CommandPattern_Example
{
    // The Invoker is associated with one or several commands. It sends a
    // request to the command.
    class Invoker
    {
        private ICommand _onStart;
        private ICommand _onFinish;

        public void SetOnStart(ICommand command)
        {
            this._onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            this._onFinish = command;
        }

        // The Invoker does not depend on concrete command or receiver classes.
        // The Invoker passes a request to a receiver indirectly, by executing a command.
        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");
            if(this._onStart is ICommand)
            {
                this._onStart.Execute();
            }

            Console.WriteLine("Invoker: ... doing something relly important...");

            Console.WriteLine("Invoker: Does anybody want something done after I finish?");
            if(this._onFinish is ICommand)
            {
                this._onFinish.Execute();
            }
        }
    }
}
