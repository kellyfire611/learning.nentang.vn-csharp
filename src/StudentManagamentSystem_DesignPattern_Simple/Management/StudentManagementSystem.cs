using StudentManagamentSystem_DesignPattern_Simple.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagamentSystem_DesignPattern_Simple.Management
{
    public class StudentManagementSystem : IManagementSystem
    {
        public static List<Student> ListStudents = new List<Student>();

        public string Start()
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

                switch (userChoose)
                {
                    case "1": // Add new Student menu
                              // Create new object Student
                        Student newStudent = new Student();
                        newStudent.ShowInputForm();

                        // Add object Student to List
                        ListStudents.Add(newStudent);
                        break;
                    case "2": // View all students menu
                              // Empty list -> show waring message
                        if (ListStudents == null || ListStudents.Count == 0)
                        {
                            Console.WriteLine("List students is empty. Please choose menu 1 to add new Student");
                            break;
                        }

                        // Loop and show all students info
                        int index = 1;
                        Console.WriteLine("--------------------------");
                        Console.WriteLine(String.Format("Total Students [{0}]", ListStudents.Count));
                        foreach (Student std in ListStudents)
                        {
                            Console.WriteLine(String.Format("Information Student [{0}]", index));
                            std.ShowInfo();
                            index++;
                        }
                        Console.WriteLine("--------------------------");
                        Console.WriteLine();
                        break;
                    case "3": // Search student menu
                              // Empty list -> show waring message
                        if (ListStudents == null || ListStudents.Count == 0)
                        {
                            Console.WriteLine("List students is empty. Please choose menu 1 to add new Student");
                            break;
                        }

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("Input keyword for search name of student: ");
                        string keyword = Console.ReadLine();
                        if (String.IsNullOrEmpty(keyword))
                        {
                            Console.WriteLine("Please input keyword for search student.");
                            break;
                        }

                        // Search by name
                        Student studentFounded = null;
                        foreach (Student std in ListStudents)
                        {
                            if (!String.IsNullOrEmpty(std.Name)
                                && std.Name.Contains(keyword))
                            {
                                studentFounded = std;
                            }
                        }

                        // Not found
                        Console.ResetColor();
                        if (studentFounded == null)
                        {
                            Console.WriteLine("Student not found!");
                        }
                        else // Founded
                        {
                            Console.WriteLine("Student information founded:");
                            studentFounded.ShowInfo();
                        }

                        break;
                    case "4": // Delete student menu
                              // Empty list -> show waring message
                        if (ListStudents == null || ListStudents.Count == 0)
                        {
                            Console.WriteLine("List students is empty. Please choose menu 1 to add new Student");
                            break;
                        }

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("Input ID for delete student: ");
                        string idForDelete = Console.ReadLine();
                        if (String.IsNullOrEmpty(idForDelete))
                        {
                            Console.WriteLine("Please input ID for delete student.");
                            break;
                        }

                        // Search by name
                        Student studentForDeleteFounded = null;
                        foreach (Student std in ListStudents)
                        {
                            if (!String.IsNullOrEmpty(std.Id)
                                && std.Id.Equals(idForDelete))
                            {
                                studentForDeleteFounded = std;
                            }
                        }

                        // Not found
                        Console.ResetColor();
                        if (studentForDeleteFounded == null)
                        {
                            Console.WriteLine("Student not found!");
                        }
                        else // Founded
                        {
                            Console.WriteLine("Student deleted successfully!");
                            ListStudents.Remove(studentForDeleteFounded);
                        }

                        break;
                    case "5": // Update student menu
                        // Empty list -> show waring message
                        if (ListStudents == null || ListStudents.Count == 0)
                        {
                            Console.WriteLine("List students is empty. Please choose menu 1 to add new Student");
                            break;
                        }

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("Input ID for update student: ");
                        string idForUpdate = Console.ReadLine();
                        if (String.IsNullOrEmpty(idForUpdate))
                        {
                            Console.WriteLine("Please input ID for update student.");
                            break;
                        }

                        // Search by name
                        Student studentForUpdateFounded = null;
                        foreach (Student std in ListStudents)
                        {
                            if (!String.IsNullOrEmpty(std.Id)
                                && std.Id.Equals(idForUpdate))
                            {
                                studentForUpdateFounded = std;
                            }
                        }

                        // Not found
                        Console.ResetColor();
                        if (studentForUpdateFounded == null)
                        {
                            Console.WriteLine("Student not found!");
                        }
                        else // Founded
                        {
                            studentForUpdateFounded.ShowInputForm();
                            Console.WriteLine("Student updated successfully!");
                        }
                        break;
                    case "6": // Back to main menu
                        break;
                    default:
                        Console.WriteLine("Not correct command. Please input only number (1, 2, 3, 4, 5 or 6)");
                        Start();
                        break;
                }
            } while (userChoose != "6");

            return userChoose;
        }
    }
}
