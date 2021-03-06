﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StudentManagamentSystem
{
    class Lecturer
    {
        // Lecturer ID with 8 digits (fixed)
        public int lecId { get; set; }
        // Lecturer name
        public string lecName { get; set; }
        // Lecturer date of birth
        public string lecDoB { get; set; }
        // Lecturer email
        public string lecEmail { get; set; }
        // Lecturer address
        public string lecAddress { get; set; }
        // Lecturer department (e.g., Computing, Business, etc)
        public string lecDept { get; set; }

        public Lecturer() { }

        public Lecturer(int id, string name, string dob, string email, string address, string dept)
        {
            this.lecId = id;
            this.lecName = name;
            this.lecDoB = dob;
            this.lecEmail = email;
            this.lecAddress = address;
            this.lecDept = dept;
        }

        public void ShowInputForm()
        {
            Console.ResetColor();
            Console.WriteLine("Input form LECTURER:");
            Console.WriteLine("Just ENTER for keep old value (if exist)");

            // Input ID field
            Console.WriteLine("ID like xxxxxxxx (x: is a digit)");
            Console.Write("ID ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("({0}):", this.lecId));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string inputId = Console.ReadLine();
            int id;
            bool isNumericId = int.TryParse(inputId, out id);
            if(!isNumericId)
            {
                id = 0;
            }
            this.lecId = String.IsNullOrEmpty(inputId) ? this.lecId : id;
            Console.ResetColor();

            // Input Name field
            Console.Write("Name ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("({0}):", this.lecName));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string name = Console.ReadLine();
            this.lecName = String.IsNullOrEmpty(name) ? this.lecName : name;
            Console.ResetColor();

            // Input DoB field
            Console.Write("DoB (dd/MM/yyyy) ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("({0}):", this.lecDoB));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string dob = Console.ReadLine();
            this.lecDoB = String.IsNullOrEmpty(dob) ? this.lecDoB : dob;
            Console.ResetColor();

            // Input Email field
            Console.Write("Email ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("({0}):", this.lecEmail));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string email = Console.ReadLine();
            this.lecEmail = String.IsNullOrEmpty(email) ? this.lecEmail : email;
            Console.ResetColor();

            // Input Address field
            Console.Write("Address ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("({0}):", this.lecAddress));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string address = Console.ReadLine();
            this.lecAddress = String.IsNullOrEmpty(address) ? this.lecAddress : address;
            Console.ResetColor();

            // Input Batch field
            Console.Write("Department ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("({0}):", this.lecDept));
            Console.ForegroundColor = ConsoleColor.Yellow;
            string dept = Console.ReadLine();
            this.lecDept = String.IsNullOrEmpty(dept) ? this.lecDept : dept;
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

        public string Validate()
        {
            string errorMessage = String.Empty;
            // Validate ID
            // Required rule
            string id = this.lecId.ToString();
            if (this.lecId == 0)
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
            if (String.IsNullOrEmpty(this.lecName))
            {
                errorMessage += "Name required. Please input some characters...\n";
            }

            // Validate DoB
            // Required rule
            if (String.IsNullOrEmpty(this.lecDoB))
            {
                errorMessage += "DoB required. Please input some characters...\n";
            }
            else
            {
                // Form like dd/MM/yyyy and valid date format
                DateTime d;
                DateTime.TryParseExact(this.lecDoB, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);
                if (d == DateTime.MinValue)
                {
                    errorMessage += "DoB not valid date. Please check it and input like dd/MM/yyyy ...\n";
                }
            }

            // Validate Email
            // Required rule
            if (String.IsNullOrEmpty(this.lecEmail))
            {
                errorMessage += "Email required. Please input some characters...\n";
            }
            else
            {
                // Form email
                var regex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                var match = regex.IsMatch(this.lecEmail) && !this.lecEmail.EndsWith(".");
                if (!match)
                {
                    errorMessage += "Email not correct form. Please check it...\n";
                }
            }

            // Validate Address
            // Required rule
            if (String.IsNullOrEmpty(this.lecAddress))
            {
                errorMessage += "Address required. Please input some characters...\n";
            }

            // Validate Dept
            // Required rule
            if (String.IsNullOrEmpty(this.lecDept))
            {
                errorMessage += "Department required. Please input some characters...\n";
            }

            return errorMessage;
        }

        public void ShowInfo()
        {
            Console.WriteLine(String.Format("Id: {0}|Name: {1}|DoB: {2}|Email: {3}|Address: {4}|Dept: {5}",
                this.lecId, this.lecName, this.lecDoB, this.lecEmail, this.lecAddress, this.lecDept));
        }
    }
}
