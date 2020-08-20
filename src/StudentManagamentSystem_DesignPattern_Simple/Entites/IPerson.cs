using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagamentSystem_DesignPattern_Simple.Entities
{
    public interface IPerson
    {
        void ShowInputForm();
        string Validate();
        void ShowInfo();
    }
}
