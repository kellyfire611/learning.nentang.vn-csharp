using StudentManagamentSystem_DesignPattern.Entities;
using StudentManagamentSystem_DesignPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagamentSystem_DesignPattern.Commands
{
    public class StudentCommand : ICommand
    {
        private readonly StudentReceiver _studentReceiver;
        private readonly CommandAction _studentAction;

        // Contect data
        private List<Student> ListStudents;

        public StudentCommand(StudentReceiver receiver, CommandAction action)
        {
            this._studentReceiver = receiver;
            this._studentAction = action;
        }

        public void ExecuteAction()
        {
            switch (_studentAction)
            {
                case CommandAction.Add:
                    this._studentReceiver.Add();
                    break;
                case CommandAction.ViewAll:
                    this._studentReceiver.ViewAll();
                    break;
                case CommandAction.Search:
                    this._studentReceiver.Search();
                    break;
                case CommandAction.Delete:
                    this._studentReceiver.Delete();
                    break;
                case CommandAction.Update:
                    this._studentReceiver.Update();
                    break;
                default:
                    break;
            }
        }
    }
}
