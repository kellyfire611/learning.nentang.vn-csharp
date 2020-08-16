using StudentManagamentSystem_DesignPattern.Entities;
using StudentManagamentSystem_DesignPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagamentSystem_DesignPattern.Commands
{
    public class LecturerCommand : ICommand
    {
        private readonly LecturerReceiver _lecturerReceiver;
        private readonly CommandAction _lecturerAction;

        // Contect data

        public LecturerCommand(LecturerReceiver receiver, CommandAction action)
        {
            this._lecturerReceiver = receiver;
            this._lecturerAction = action;
        }

        public void ExecuteAction()
        {
            switch (_lecturerAction)
            {
                case CommandAction.Add:
                    this._lecturerReceiver.Add();
                    break;
                case CommandAction.ViewAll:
                    this._lecturerReceiver.ViewAll();
                    break;
                case CommandAction.Search:
                    this._lecturerReceiver.Search();
                    break;
                case CommandAction.Delete:
                    this._lecturerReceiver.Delete();
                    break;
                case CommandAction.Update:
                    this._lecturerReceiver.Update();
                    break;
                default:
                    break;
            }
        }
    }
}
