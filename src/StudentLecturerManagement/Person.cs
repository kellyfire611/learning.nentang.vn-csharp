using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLecturerManagement
{
    public abstract class Person
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Email { get; set;}
        public string Address { get; set; }
        public Person() { }
        public Person(string pID, string pName, string pDateOfBirth, 
            string pEmail, string pAddress)
        {
            this.ID = pID;
            this.Name = pName;
            this.DateOfBirth = pDateOfBirth;
            this.Email = pEmail;
            this.Address = pAddress;
        }
        public virtual void Introduce()
        {
            Console.WriteLine("ID: " + this.ID);
            Console.WriteLine("Name: " + this.Name);
            Console.WriteLine("DateOfBirth: " + this.DateOfBirth);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("Address: " + this.Address);
        }
        public virtual bool Input()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Begin INPUT...");
            return true;
        }
    }
}
