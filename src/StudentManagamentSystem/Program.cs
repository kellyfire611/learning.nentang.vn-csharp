using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagamentSystem
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
                            if (!String.IsNullOrEmpty(std.stdName)
                                && std.stdName.Contains(keyword))
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
                            if (!String.IsNullOrEmpty(std.stdId)
                                && std.stdId.Equals(idForDelete))
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
                            if (!String.IsNullOrEmpty(std.stdId)
                                && std.stdId.Equals(idForUpdate))
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

                switch (userChoose)
                {
                    case "1": // Add new Lecturer menu
                              // Create new object Lecturer
                        Lecturer newLecturer = new Lecturer();
                        newLecturer.ShowInputForm();

                        // Add object Lecturer to List
                        ListLecturers.Add(newLecturer);
                        break;
                    case "2": // View all Lecturers menu
                              // Empty list -> show waring message
                        if (ListLecturers == null || ListLecturers.Count == 0)
                        {
                            Console.WriteLine("List Lecturers is empty. Please choose menu 1 to add new Lecturer");
                            break;
                        }

                        // Loop and show all Lecturers info
                        int index = 1;
                        Console.WriteLine("--------------------------");
                        Console.WriteLine(String.Format("Total Lecturers [{0}]", ListLecturers.Count));
                        foreach (Lecturer lec in ListLecturers)
                        {
                            Console.WriteLine(String.Format("Information Lecturer [{0}]", index));
                            lec.ShowInfo();
                            index++;
                        }
                        Console.WriteLine("--------------------------");
                        Console.WriteLine();
                        break;
                    case "3": // Search Lecturer menu
                              // Empty list -> show waring message
                        if (ListLecturers == null || ListLecturers.Count == 0)
                        {
                            Console.WriteLine("List Lecturers is empty. Please choose menu 1 to add new Lecturer");
                            break;
                        }

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("Input keyword for search name of Lecturer: ");
                        string keyword = Console.ReadLine();
                        if (String.IsNullOrEmpty(keyword))
                        {
                            Console.WriteLine("Please input keyword for search Lecturer.");
                            break;
                        }

                        // Search by name
                        Lecturer LecturerFounded = null;
                        foreach (Lecturer lec in ListLecturers)
                        {
                            if (!String.IsNullOrEmpty(lec.lecName)
                                && lec.lecName.Contains(keyword))
                            {
                                LecturerFounded = lec;
                            }
                        }

                        // Not found
                        Console.ResetColor();
                        if (LecturerFounded == null)
                        {
                            Console.WriteLine("Lecturer not found!");
                        }
                        else // Founded
                        {
                            Console.WriteLine("Lecturer information founded:");
                            LecturerFounded.ShowInfo();
                        }

                        break;
                    case "4": // Delete Lecturer menu
                              // Empty list -> show waring message
                        if (ListLecturers == null || ListLecturers.Count == 0)
                        {
                            Console.WriteLine("List Lecturers is empty. Please choose menu 1 to add new Lecturer");
                            break;
                        }

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("Input ID for delete Lecturer: ");
                        string inputIdForDelete = Console.ReadLine();
                        int idForDelete = 0;
                        if (String.IsNullOrEmpty(inputIdForDelete))
                        {
                            Console.WriteLine("Please input ID for delete Lecturer.");
                            break;
                        }
                        else
                        {
                            bool isNumericId = int.TryParse(inputIdForDelete, out idForDelete);
                            if (!isNumericId)
                            {
                                idForDelete = 0;
                                Console.WriteLine("ID must have numberic. Please input ID for update Lecturer.");
                                break;
                            }
                        }

                        // Search by id
                        Lecturer LecturerForDeleteFounded = null;
                        foreach (Lecturer lec in ListLecturers)
                        {
                            if (lec.lecId.Equals(idForDelete))
                            {
                                LecturerForDeleteFounded = lec;
                            }
                        }

                        // Not found
                        Console.ResetColor();
                        if (LecturerForDeleteFounded == null)
                        {
                            Console.WriteLine("Lecturer not found!");
                        }
                        else // Founded
                        {
                            Console.WriteLine("Lecturer deleted successfully!");
                            ListLecturers.Remove(LecturerForDeleteFounded);
                        }

                        break;
                    case "5": // Update Lecturer menu
                        // Empty list -> show waring message
                        if (ListLecturers == null || ListLecturers.Count == 0)
                        {
                            Console.WriteLine("List Lecturers is empty. Please choose menu 1 to add new Lecturer");
                            break;
                        }

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("Input ID for update Lecturer: ");
                        string inputIdForUpdate = Console.ReadLine();
                        int idForUpdate = 0;
                        if (String.IsNullOrEmpty(inputIdForUpdate))
                        {
                            Console.WriteLine("Please input ID for update Lecturer.");
                            break;
                        }
                        else
                        {
                            bool isNumericId = int.TryParse(inputIdForUpdate, out idForUpdate);
                            if (!isNumericId)
                            {
                                idForUpdate = 0;
                                Console.WriteLine("ID must have numberic. Please input ID for update Lecturer.");
                                break;
                            }
                        }

                        // Search by id
                        Lecturer LecturerForUpdateFounded = null;
                        foreach (Lecturer lec in ListLecturers)
                        {
                            if (lec.lecId.Equals(idForUpdate))
                            {
                                LecturerForUpdateFounded = lec;
                            }
                        }

                        // Not found
                        Console.ResetColor();
                        if (LecturerForUpdateFounded == null)
                        {
                            Console.WriteLine("Lecturer not found!");
                        }
                        else // Founded
                        {
                            LecturerForUpdateFounded.ShowInputForm();
                            Console.WriteLine("Lecturer updated successfully!");
                        }
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
    }
}
