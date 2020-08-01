using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StudentManagamentSystem
{
    class Student
    {
        // The student ID of the form like GTxxxxx or GCxxxxx (x: is a digit)
        public string stdId { get; set; }
        // Student name
        public string stdName { get; set; }
        // Student date of birth
        public string stdDoB { get; set; }
        // Student email
        public string stdEmail { get; set; }
        // Student address
        public string stdAddress { get; set; }
        // The batch (class) of the student
        public string stdBatch { get; set; }

        public Student() { }

        public Student(string id, string name, string dob, string email, string address, string batch)
        {
            this.stdId = id;
            this.stdName = name;
            this.stdDoB = dob;
            this.stdEmail = email;
            this.stdAddress = address;
            this.stdBatch = batch;
        }

        public void ShowInputForm()
        {
            Console.ResetColor();
            Console.WriteLine("Input form STUDENT:");
            Console.WriteLine("Just ENTER for keep old value (if exist)");

            // Input ID field
            Console.WriteLine("ID like GTxxxxx or GCxxxxx (x: is a digit)");
            Console.Write("ID ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("({0}):", this.stdId));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string id = Console.ReadLine();
            this.stdId = String.IsNullOrEmpty(id) ? this.stdId : id;
            Console.ResetColor();

            // Input Name field
            Console.Write("Name ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("({0}):", this.stdName));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string name = Console.ReadLine();
            this.stdName = String.IsNullOrEmpty(name) ? this.stdName : name;
            Console.ResetColor();

            // Input DoB field
            Console.Write("DoB (dd/MM/yyyy) ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("({0}):", this.stdDoB));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string dob = Console.ReadLine();
            this.stdDoB = String.IsNullOrEmpty(dob) ? this.stdDoB : dob;
            Console.ResetColor();

            // Input Email field
            Console.Write("Email ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("({0}):", this.stdEmail));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string email = Console.ReadLine();
            this.stdEmail = String.IsNullOrEmpty(email) ? this.stdEmail : email;
            Console.ResetColor();

            // Input Address field
            Console.Write("Address ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("({0}):", this.stdAddress));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string address = Console.ReadLine();
            this.stdAddress = String.IsNullOrEmpty(address) ? this.stdAddress : address;
            Console.ResetColor();

            // Input Batch field
            Console.Write("Batch ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("({0}):", this.stdBatch));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string batch = Console.ReadLine();
            this.stdBatch = String.IsNullOrEmpty(batch) ? this.stdBatch : batch;
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
            Console.WriteLine("Student info just inputed:");
            this.ShowInfo();
        }

        public string Validate()
        {
            string errorMessage = String.Empty;
            // Validate ID
            // Required rule
            if (String.IsNullOrEmpty(this.stdId))
            {
                errorMessage += "ID required. Please input some characters...\n";
            }
            else if (this.stdId.Length != 7)
            {
                errorMessage += "ID only 7 characters. Please input some characters...\n";
            }
            else
            {
                // Form like GTxxxxx or GCxxxxx (x: is a digit)
                string patternId = @"[GT|GC]\d\d\d\d\d";
                var match = Regex.Match(this.stdId, patternId, RegexOptions.IgnoreCase);
                if (!match.Success) // Not match
                {
                    errorMessage += "ID must like form  GTxxxxx or GCxxxxx (x: is a digit). Please check it...\n";
                }
            }

            // Validate Name
            // Required rule
            if (String.IsNullOrEmpty(this.stdName))
            {
                errorMessage += "Name required. Please input some characters...\n";
            }

            // Validate DoB
            // Required rule
            if (String.IsNullOrEmpty(this.stdDoB))
            {
                errorMessage += "DoB required. Please input some characters...\n";
            }
            else
            {
                // Form like dd/MM/yyyy and valid date format
                DateTime d;
                DateTime.TryParseExact(this.stdDoB, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);
                if (d == DateTime.MinValue)
                {
                    errorMessage += "DoB not valid date. Please check it and input like dd/MM/yyyy ...\n";
                }
            }

            // Validate Email
            // Required rule
            if (String.IsNullOrEmpty(this.stdEmail))
            {
                errorMessage += "Email required. Please input some characters...\n";
            }
            else
            {
                // Form email
                var regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                var match = regex.IsMatch(this.stdEmail) && !this.stdEmail.EndsWith(".");
                if (!match)
                {
                    errorMessage += "Email not correct form. Please check it...\n";
                }
            }

            // Validate Address
            // Required rule
            if (String.IsNullOrEmpty(this.stdAddress))
            {
                errorMessage += "Address required. Please input some characters...\n";
            }

            // Validate Batch
            // Required rule
            if (String.IsNullOrEmpty(this.stdBatch))
            {
                errorMessage += "Batch required. Please input some characters...\n";
            }

            return errorMessage;
        }

        public void ShowInfo()
        {
            Console.WriteLine(String.Format("Id: {0}|Name: {1}|DoB: {2}|Email: {3}|Address: {4}|Batch: {5}",
                this.stdId, this.stdName, this.stdDoB, this.stdEmail, this.stdAddress, this.stdBatch));
        }
    }
}
