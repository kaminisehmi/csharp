using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Student
    {
        public string Name;
        public int rollno;

        public override string ToString()
        {
            return $"Name is: {Name} and Rollno is: {rollno}";
        }
    }


    internal class Program5
    {
        static void Main()
        {
            // Student student = new Student();
            //Console.WriteLine(student);
            //List of objects
            List<Student> obj1 = new List<Student>
            {
                new Student { Name = "A", rollno = 101 },
                new Student { Name = "B", rollno = 102 },
                new Student { Name = "C", rollno = 103 }
            };
            foreach (var course in obj1)
            {
                Console.WriteLine($"{course.Name} and {course.rollno}");
            }
        }
    }
}
