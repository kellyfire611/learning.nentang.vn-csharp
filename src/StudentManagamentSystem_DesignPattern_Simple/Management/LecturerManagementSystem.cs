using StudentManagamentSystem_DesignPattern_Simple.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagamentSystem_DesignPattern_Simple.Management
{
    public class LecturerManagementSystem : IManagementSystem
    {
        public static List<Lecturer> ListLecturers = new List<Lecturer>();

        public string Start()
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
                            if (!String.IsNullOrEmpty(lec.Name)
                                && lec.Name.Contains(keyword))
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
                            if (lec.Id.Equals(idForDelete))
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
                            if (lec.Id.Equals(idForUpdate))
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
                    case "6": // Back to min menu
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
