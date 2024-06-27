using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLecturerManagement
{
    public class Lecturer : Person
    {
        public string Department { get;set; }
        public Lecturer() { }
        public Lecturer(string pID, string pName, string pDateOfBirth,
            string pEmail, string pAddress, string pDepartment)
            : base(pID, pName, pDateOfBirth, pEmail, pAddress)
        {
            this.Department = pDepartment;
        }
        public override void Introduce()
        {
            base.Introduce();
            Console.WriteLine("Department: " + this.Department);
        }
        public override bool Input()
        {
            // 1. Nhập liệu
            base.Input();
            string temp;
            Console.Write(String.Format("Please input ID ({0}): ", this.ID));
            temp = Console.ReadLine();
            if(temp != "") {
                this.ID = temp;
            }

            Console.Write(String.Format("Please input Name ({0}): ", this.Name));
            temp = Console.ReadLine();
            if (temp != "")
            {
                this.Name = temp;
            }

            Console.Write(String.Format("Please input Date of Birth (dd/mm/yyyy) ({0}): "
                , this.DateOfBirth));
            temp = Console.ReadLine();
            if (temp != "")
            {
                this.DateOfBirth = temp;
            }

            Console.Write(String.Format("Please input Email ({0}): ", this.Email));
            temp = Console.ReadLine();
            if (temp != "")
            {
                this.Email = temp;
            }

            Console.Write(String.Format("Please input Address ({0}): ", this.Address));
            temp = Console.ReadLine();
            if (temp != "")
            {
                this.Address = temp;
            }

            Console.Write(String.Format("Please input Department ({0}): ", this.Department));
            temp = Console.ReadLine();
            if (temp != "")
            {
                this.Department = temp;
            }

            // 2. Kiểm tra dữ liệu có hợp lệ hay không?
            string error = this.Validate();
            if(error == "") // Input validate okey !
            {
                Console.WriteLine("Data input okey. Thank you!");
                return true;
            }
            else
            {
                Console.WriteLine("Data input not correct, please check..");
                Console.WriteLine(error);
                return false;
            }
        }
        private string Validate()
        {
            string error = string.Empty;
            // 1. Kiểm tra dữ liệu thuộc tính ID
            // Rule 1: required (bắt buộc nhập)
            if(this.ID == "")
            {
                error += "ID required. Please input again...";
            }
            // Rule 2: equal (độ dài phải = 8 ký tự)
            else if(this.ID.Length != 8) 
            {
                error += "ID must have 8 digits. Please check...";
            }
            
            // 2. Kiểm tra dữ liệu thuộc tính Date of Birth
            // Rule 1: required (bắt buộc nhập)
            if(String.IsNullOrEmpty( this.DateOfBirth) )
            {
                error += "Date of Birth required. Please input again...";
            }
            // Rule 2: equal (độ dài phải = 10 ký tự)
            else if(this.DateOfBirth.Length != 10)
            {
                error += "Date of Birth must have 10 characters. Please check..";
            }

            // 3....
            return error;
        }
    }
}
