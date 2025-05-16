/* Build a console app where a student enters their name, ID, and department, and the app generates a structured ID card. Use:
Classes & Objects
Constructor
Simple validation
Console input/output */

/* === SMART STUDENT ID CARD SYSTEM ===

Enter student name: Kamini Sehmi
Enter student ID: 101
Enter department: Software Development

--- Student ID Card ---
Name: Kamini Sehmi
ID: 101
Department: Software Development
-------------------------*/



using System;

namespace SmartCampus
{
    class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Department { get; set; }

        public Student(string name, int id, string department)
        {
            Name = name;
            ID = id;
            Department = department;
        }

        public void DisplayIDCard()
        {
            Console.WriteLine("\n--- Student ID Card ---");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine("-------------------------");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SMART STUDENT ID CARD SYSTEM ===\n");

            // Pre-filled input for demo
            string name = "Kamini Sehmi";
            int id = 101;
            string department = "Software Development";

            // Create object
            Student student = new Student(name, id, department);

            // Display student info
            student.DisplayIDCard();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadLine();
        }
    }
}
