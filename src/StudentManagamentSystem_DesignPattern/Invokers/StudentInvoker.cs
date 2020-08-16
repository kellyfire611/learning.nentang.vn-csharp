using StudentManagamentSystem_DesignPattern.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagamentSystem_DesignPattern.Invokers
{
    public class StudentInvoker
    {
        private readonly List<ICommand> _commands;
        private ICommand _command;

        public StudentInvoker()
        {
            _commands = new List<ICommand>();
        }

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void Invoke()
        {
            _commands.Add(_command);
            _command.ExecuteAction();
        }
    }
}
