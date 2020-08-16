using StudentManagamentSystem_DesignPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagamentSystem_DesignPattern.Receivers
{
    public class LecturerReceiver : Receiver
    {
        public List<Lecturer> ListLecturers;

        public LecturerReceiver(List<Lecturer> lst)
        {
            ListLecturers = lst;
        }

        public void Add()
        {
            // Add new Lecturer menu
            // Create new object Lecturer
            Lecturer newLecturer = new Lecturer();
            newLecturer.ShowInputForm();

            // Add object Lecturer to List
            ListLecturers.Add(newLecturer);
        }

        public void ViewAll()
        {
            // View all Lecturers menu
            // Empty list -> show waring message
            if (ListLecturers == null || ListLecturers.Count == 0)
            {
                Console.WriteLine("List Lecturers is empty. Please choose menu 1 to add new Lecturer");
                return;
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
        }

        public void Search()
        {
            // Search Lecturer menu
            // Empty list -> show waring message
            if (ListLecturers == null || ListLecturers.Count == 0)
            {
                Console.WriteLine("List Lecturers is empty. Please choose menu 1 to add new Lecturer");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Input keyword for search name of Lecturer: ");
            string keyword = Console.ReadLine();
            if (String.IsNullOrEmpty(keyword))
            {
                Console.WriteLine("Please input keyword for search Lecturer.");
                return;
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
        }

        public void Delete()
        {
            // Delete Lecturer menu
            // Empty list -> show waring message
            if (ListLecturers == null || ListLecturers.Count == 0)
            {
                Console.WriteLine("List Lecturers is empty. Please choose menu 1 to add new Lecturer");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Input ID for delete Lecturer: ");
            string inputIdForDelete = Console.ReadLine();
            int idForDelete = 0;
            if (String.IsNullOrEmpty(inputIdForDelete))
            {
                Console.WriteLine("Please input ID for delete Lecturer.");
                return;
            }
            else
            {
                bool isNumericId = int.TryParse(inputIdForDelete, out idForDelete);
                if (!isNumericId)
                {
                    idForDelete = 0;
                    Console.WriteLine("ID must have numberic. Please input ID for update Lecturer.");
                    return;
                }
            }

            // Search by id
            Lecturer LecturerForDeleteFounded = null;
            foreach (Lecturer lec in ListLecturers)
            {
                if (lec.Id.Equals(inputIdForDelete))
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
        }

        public void Update()
        {
            // Update Lecturer menu
            // Empty list -> show waring message
            if (ListLecturers == null || ListLecturers.Count == 0)
            {
                Console.WriteLine("List Lecturers is empty. Please choose menu 1 to add new Lecturer");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Input ID for update Lecturer: ");
            string inputIdForUpdate = Console.ReadLine();
            int idForUpdate = 0;
            if (String.IsNullOrEmpty(inputIdForUpdate))
            {
                Console.WriteLine("Please input ID for update Lecturer.");
                return;
            }
            else
            {
                bool isNumericId = int.TryParse(inputIdForUpdate, out idForUpdate);
                if (!isNumericId)
                {
                    idForUpdate = 0;
                    Console.WriteLine("ID must have numberic. Please input ID for update Lecturer.");
                    return;
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
        }
    }
}
