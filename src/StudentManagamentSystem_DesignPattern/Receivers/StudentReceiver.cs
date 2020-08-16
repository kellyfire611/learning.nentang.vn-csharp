using StudentManagamentSystem_DesignPattern.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagamentSystem_DesignPattern.Receivers
{
    public class StudentReceiver : Receiver
    {
        public List<Student> ListStudents;

        public StudentReceiver(List<Student> lst)
        {
            ListStudents = lst;
        }

        public void Add()
        {
            // Add new Student menu
            // Create new object Student
            Student newStudent = new Student();
            newStudent.ShowInputForm();

            // Add object Student to List
            ListStudents.Add(newStudent);
        }

        public void ViewAll()
        {
            // View all students menu
            // Empty list -> show waring message
            if (ListStudents == null || ListStudents.Count == 0)
            {
                Console.WriteLine("List students is empty. Please choose menu 1 to add new Student");
                return;
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
            return;
        }

        public void Search()
        {
            // Search student menu
            // Empty list -> show waring message
            if (ListStudents == null || ListStudents.Count == 0)
            {
                Console.WriteLine("List students is empty. Please choose menu 1 to add new Student");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Input keyword for search name of student: ");
            string keyword = Console.ReadLine();
            if (String.IsNullOrEmpty(keyword))
            {
                Console.WriteLine("Please input keyword for search student.");
                return;
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
        }

        public void Delete()
        {
            // Delete student menu
            // Empty list -> show waring message
            if (ListStudents == null || ListStudents.Count == 0)
            {
                Console.WriteLine("List students is empty. Please choose menu 1 to add new Student");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Input ID for delete student: ");
            string idForDelete = Console.ReadLine();
            if (String.IsNullOrEmpty(idForDelete))
            {
                Console.WriteLine("Please input ID for delete student.");
                return;
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

            return;
        }

        public void Update()
        {
            // Update student menu
            // Empty list -> show waring message
            if (ListStudents == null || ListStudents.Count == 0)
            {
                Console.WriteLine("List students is empty. Please choose menu 1 to add new Student");
                return;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write("Input ID for update student: ");
            string idForUpdate = Console.ReadLine();
            if (String.IsNullOrEmpty(idForUpdate))
            {
                Console.WriteLine("Please input ID for update student.");
                return;
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
        }
    }
}
