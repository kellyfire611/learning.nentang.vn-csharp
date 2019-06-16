using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeacherAndStudentOOP
{
    class Person
    {
        protected int age;

        public void Greet()
        {
            Console.WriteLine("Hello");
        }

        public void SetAge(int n)
        {
            age = n;
        }
    }

    class Student : Person
    {
        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} years old", age);
        }
    }

    class Teacher : Person
    {
        private string subject;

        public void Explain()
        {
            Console.WriteLine("Explanation begins");
        }
    }

    class StudentAndTeacherTest
    {
        static void Main()
        {
            bool debug = false;

            Person myPerson = new Person();
            myPerson.Greet();

            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();

            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();

            if (debug)
                Console.ReadLine();
            Console.ReadKey();
        }
    }
}
