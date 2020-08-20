using StudentManagamentSystem_DesignPattern_Simple.Creator;
using StudentManagamentSystem_DesignPattern_Simple.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagamentSystem_DesignPattern_Simple
{
    public class Menu
    {
        private static Menu _instance;

        // Hidden constructor
        private Menu() { }

        /// <summary>
        /// Get Menu instance
        /// </summary>
        /// <returns>Menu instance</returns>
        public static Menu GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Menu();
            }
            return _instance;
        }

        /// <summary>
        /// Show Main menu
        /// </summary>
        public void ShowMainMenu()
        {
            // Main menu
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===============================");
            Console.WriteLine("1. Manage Students");
            Console.WriteLine("2. Manage Lecturers");
            Console.WriteLine("3. Exit");
            Console.WriteLine("===============================");

            // User choose
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Please choose: ");
            string userChoose = String.Empty;
            userChoose = Console.ReadLine();
            Console.ResetColor();

            switch (userChoose)
            {
                case "1":
                    // Start App Student Management
                    ApplicationStudent appStudentCreator = new ApplicationStudent();
                    IManagementSystem appStudent = appStudentCreator.MakeApp();
                    string appStudentResult = appStudent.Start();
                    if(appStudentResult == "6")
                    {
                        ShowMainMenu();
                    }
                    break;
                case "2":
                    // Start App Lecturer Management
                    ApplicationLecturer appLecturerCreator = new ApplicationLecturer();
                    IManagementSystem appLecturer = appLecturerCreator.MakeApp();
                    string appLecturerResult = appLecturer.Start();
                    if (appLecturerResult == "6")
                    {
                        ShowMainMenu();
                    }
                    break;
                case "3":
                    // Exit program
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Not correct command. Please input only number (1, 2 or 3)");
                    ShowMainMenu();
                    break;
            }
        }
    }
}
