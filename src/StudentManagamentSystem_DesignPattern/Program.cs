using StudentManagamentSystem_DesignPattern.Commands;
using StudentManagamentSystem_DesignPattern.Entities;
using StudentManagamentSystem_DesignPattern.Invokers;
using StudentManagamentSystem_DesignPattern.Receivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagamentSystem_DesignPattern
{
    class Program
    {
        public static List<Student> ListStudents;
        public static List<Lecturer> ListLecturers;

        static void ShowMainMenu()
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
                    // Show Sub menu Student Management
                    ShowSubMenuStudentManagement();
                    break;
                case "2":
                    // Show Sub menu Lecturer Management
                    ShowSubMenuLecturerManagement();
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

        static void ShowSubMenuStudentManagement()
        {
            string userChoose = String.Empty;
            Console.Clear();
            do
            {
                // Sub menu Student Management
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("====STUDENT MANAGEMENT MENU====");
                Console.WriteLine("===============================");
                Console.WriteLine("1. Add new Student");
                Console.WriteLine("2. View all Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Update Student");
                Console.WriteLine("6. Back to main menu");
                Console.WriteLine("===============================");

                // User choose
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Please choose: ");
                userChoose = Console.ReadLine();
                Console.ResetColor();

                // Initialize command
                StudentReceiver studentReciever = new StudentReceiver(Program.ListStudents);
                StudentInvoker studentInvoker = new StudentInvoker();

                switch (userChoose)
                {
                    case "1": // Add new Student menu
                              // Create new object Student
                        ExecuteStudent(studentInvoker, new StudentCommand(studentReciever, CommandAction.Add));
                        break;
                    case "2": // View all students menu
                              // Empty list -> show waring message
                        ExecuteStudent(studentInvoker, new StudentCommand(studentReciever, CommandAction.ViewAll));
                        break;
                    case "3": // Search student menu
                              // Empty list -> show waring message
                        ExecuteStudent(studentInvoker, new StudentCommand(studentReciever, CommandAction.Search));
                        break;
                    case "4": // Delete student menu
                              // Empty list -> show waring message
                        ExecuteStudent(studentInvoker, new StudentCommand(studentReciever, CommandAction.Delete));
                        break;
                    case "5": // Update student menu
                        // Empty list -> show waring message
                        ExecuteStudent(studentInvoker, new StudentCommand(studentReciever, CommandAction.Update));
                        break;
                    case "6": // Back to main menu
                        ShowMainMenu();
                        break;
                    default:
                        Console.WriteLine("Not correct command. Please input only number (1, 2, 3, 4, 5 or 6)");
                        ShowSubMenuStudentManagement();
                        break;
                }
            } while (userChoose != "6");
        }

        static void ShowSubMenuLecturerManagement()
        {
            string userChoose = String.Empty;
            Console.Clear();
            do
            {
                // Sub menu Lecturer Management
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("====LECTURER MANAGEMENT MENU===");
                Console.WriteLine("===============================");
                Console.WriteLine("1. Add new Lecturer");
                Console.WriteLine("2. View all Lecturers");
                Console.WriteLine("3. Search Lecturer");
                Console.WriteLine("4. Delete Lecturer");
                Console.WriteLine("5. Update Lecturer");
                Console.WriteLine("6. Back to main menu");
                Console.WriteLine("===============================");

                // User choose
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Please choose: ");
                userChoose = Console.ReadLine();
                Console.ResetColor();

                // Initialize command
                LecturerReceiver lecturerReciever = new LecturerReceiver(Program.ListLecturers);
                LecturerInvoker lecturerInvoker = new LecturerInvoker();

                switch (userChoose)
                {
                    case "1": // Add new Lecturer menu
                              // Create new object Lecturer
                        ExecuteLecturer(lecturerInvoker, new LecturerCommand(lecturerReciever, CommandAction.Add));
                        break;
                    case "2": // View all Lecturers menu
                              // Empty list -> show waring message
                        ExecuteLecturer(lecturerInvoker, new LecturerCommand(lecturerReciever, CommandAction.ViewAll));
                        break;
                    case "3": // Search Lecturer menu
                              // Empty list -> show waring message
                        ExecuteLecturer(lecturerInvoker, new LecturerCommand(lecturerReciever, CommandAction.Search));
                        break;
                    case "4": // Delete Lecturer menu
                              // Empty list -> show waring message
                        ExecuteLecturer(lecturerInvoker, new LecturerCommand(lecturerReciever, CommandAction.Delete));
                        break;
                    case "5": // Update Lecturer menu
                              // Empty list -> show waring message
                        ExecuteLecturer(lecturerInvoker, new LecturerCommand(lecturerReciever, CommandAction.Update));
                        break;
                    case "6": // Back to main menu
                        ShowMainMenu();
                        break;
                    default:
                        Console.WriteLine("Not correct command. Please input only number (1, 2, 3, 4, 5 or 6)");
                        ShowSubMenuStudentManagement();
                        break;
                }
            } while (userChoose != "6");
        }

        static void Main(string[] args)
        {
            // Initial list Students and Lecturers
            ListStudents = new List<Student>();
            ListLecturers = new List<Lecturer>();

            // Show main menu
            ShowMainMenu();

            // Wait console for read
            Console.Read();
        }

        private static void ExecuteStudent(StudentInvoker invoker, ICommand command)
        {
            invoker.SetCommand(command);
            invoker.Invoke();
        }

        private static void ExecuteLecturer(LecturerInvoker invoker, ICommand command)
        {
            invoker.SetCommand(command);
            invoker.Invoke();
        }
    }
}
