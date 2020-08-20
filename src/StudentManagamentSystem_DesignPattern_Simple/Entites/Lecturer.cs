using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StudentManagamentSystem_DesignPattern_Simple.Entities
{
    public class Lecturer : Person
    {
        // Lecturer department (e.g., Computing, Business, etc)
        public string Dept { get; set; }

        public Lecturer() : base()
        { 
        }

        public Lecturer(string id, string name, string dob, string email, string address, string dept)
        {
            this.Id = id;
            this.Name = name;
            this.DoB = dob;
            this.Email = email;
            this.Address = address;
            this.Dept = dept;
        }

        public override void ShowInputForm()
        {
            Console.ResetColor();
            Console.WriteLine("Input form LECTURER:");
            Console.WriteLine("Just ENTER for keep old value (if exist)");

            // Input ID field
            Console.WriteLine("ID like xxxxxxxx (x: is a digit)");
            Console.Write("ID ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("({0}):", this.Id));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string inputId = Console.ReadLine();

            this.Id = String.IsNullOrEmpty(inputId) ? this.Id : inputId;
            Console.ResetColor();

            // Input Name field
            Console.Write("Name ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("({0}):", this.Name));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string name = Console.ReadLine();
            this.Name = String.IsNullOrEmpty(name) ? this.Name : name;
            Console.ResetColor();

            // Input DoB field
            Console.Write("DoB (dd/MM/yyyy) ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("({0}):", this.DoB));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string dob = Console.ReadLine();
            this.DoB = String.IsNullOrEmpty(dob) ? this.DoB : dob;
            Console.ResetColor();

            // Input Email field
            Console.Write("Email ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("({0}):", this.Email));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string email = Console.ReadLine();
            this.Email = String.IsNullOrEmpty(email) ? this.Email : email;
            Console.ResetColor();

            // Input Address field
            Console.Write("Address ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("({0}):", this.Address));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string address = Console.ReadLine();
            this.Address = String.IsNullOrEmpty(address) ? this.Address : address;
            Console.ResetColor();

            // Input Batch field
            Console.Write("Department ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("({0}):", this.Dept));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string dept = Console.ReadLine();
            this.Dept = String.IsNullOrEmpty(dept) ? this.Dept : dept;
            Console.ResetColor();

            // Validate
            string errorMessage = this.Validate();
            if (!String.IsNullOrEmpty(errorMessage)) // Has error message of Validation (Invalid)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERR! Has some errors when validate input fields. Please check and try again!!!");
                Console.Write(errorMessage);
                ShowInputForm();
                return;
            }

            // Valid
            Console.WriteLine("Lecturer info just inputed:");
            this.ShowInfo();
        }

        public override string Validate()
        {
            string errorMessage = String.Empty;
            // Validate ID
            // Required rule
            string id = this.Id.ToString();
            if (String.IsNullOrEmpty(this.Id) || this.Id == "0")
            {
                errorMessage += "ID required. Please input some characters...\n";
            }
            else if (id.Length != 8)
            {
                errorMessage += "ID only 8 digit characters. Please input some characters...\n";
            }
            else
            {
                // Form like GTxxxxx or GCxxxxx (x: is a digit)
                string patternId = @"(\d){7}";
                var match = Regex.Match(id, patternId, RegexOptions.IgnoreCase);
                if (!match.Success) // Not match
                {
                    errorMessage += "ID must like form xxxxxxxx (x: is a digit). Please check it...\n";
                }
            }

            // Validate Name
            // Required rule
            if (String.IsNullOrEmpty(this.Name))
            {
                errorMessage += "Name required. Please input some characters...\n";
            }

            // Validate DoB
            // Required rule
            if (String.IsNullOrEmpty(this.DoB))
            {
                errorMessage += "DoB required. Please input some characters...\n";
            }
            else
            {
                // Form like dd/MM/yyyy and valid date format
                DateTime d;
                DateTime.TryParseExact(this.DoB, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);
                if (d == DateTime.MinValue)
                {
                    errorMessage += "DoB not valid date. Please check it and input like dd/MM/yyyy ...\n";
                }
            }

            // Validate Email
            // Required rule
            if (String.IsNullOrEmpty(this.Email))
            {
                errorMessage += "Email required. Please input some characters...\n";
            }
            else
            {
                // Form email
                var regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                var match = regex.IsMatch(this.Email) && !this.Email.EndsWith(".");
                if (!match)
                {
                    errorMessage += "Email not correct form. Please check it...\n";
                }
            }

            // Validate Address
            // Required rule
            if (String.IsNullOrEmpty(this.Address))
            {
                errorMessage += "Address required. Please input some characters...\n";
            }

            // Validate Dept
            // Required rule
            if (String.IsNullOrEmpty(this.Dept))
            {
                errorMessage += "Department required. Please input some characters...\n";
            }

            return errorMessage;
        }

        public override void ShowInfo()
        {
            Console.WriteLine(String.Format("Id: {0}|Name: {1}|DoB: {2}|Email: {3}|Address: {4}|Dept: {5}",
                this.Id, this.Name, this.DoB, this.Email, this.Address, this.Dept));
        }
    }
}
