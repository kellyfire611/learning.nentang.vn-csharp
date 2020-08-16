using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StudentManagamentSystem_DesignPattern.Entities
{
    public abstract class Person : IPerson
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string DoB { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Person() { }

        public virtual void ShowInputForm()
        {
        }

        public virtual string Validate()
        {
            return String.Empty;
        }

        public virtual void ShowInfo()
        {
        }
    }
}
