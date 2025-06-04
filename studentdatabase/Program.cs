using System;
using System.Collections.Generic;

// 1️⃣ IRegistrable Interface
public interface IRegistrable
{
    void Register();
}

// 2️⃣ Person Base Class
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public Person(string firstName, string lastName, string email)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Student: {FirstName} {LastName}");
        Console.WriteLine($"Email: {Email}");
    }
}

// 3️⃣ Student Class (Inherits Person, Implements IRegistrable)
public class Student : Person, IRegistrable
{
    public string StudentID { get; set; }
    public List<Course> EnrolledCourses { get; set; }

    public Student(string firstName, string lastName, string email, string studentID)
        : base(firstName, lastName, email)
    {
        StudentID = studentID;
        EnrolledCourses = new List<Course>();
    }

    public void Register()
    {
        Console.WriteLine("Student registered successfully!");
    }

    public void EnrollInCourse(Course course)
    {
        EnrolledCourses.Add(course);
        Console.WriteLine("Student enrolled successfully!");
    }

    public void DisplayEnrollments()
    {
        Console.WriteLine($"--- Student Report ---");
        Console.WriteLine($"Student: {FirstName} {LastName} ({StudentID})");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine("Enrolled Courses:");

        if (EnrolledCourses.Count == 0)
        {
            Console.WriteLine("No courses enrolled.");
        }
        else
        {
            int count = 1;
            foreach (var course in EnrolledCourses)
            {
                Console.Write($"{count}. ");
                course.DisplayCourseInfo();
                count++;
            }
        }
    }
}

// 4️⃣ Course Class
public class Course
{
    public string CourseCode { get; set; }
    public string CourseName { get; set; }
    public int CreditHours { get; set; }

    public Course(string courseCode, string courseName, int creditHours)
    {
        CourseCode = courseCode;
        CourseName = courseName;
        CreditHours = creditHours;
    }

    public void DisplayCourseInfo()
    {
        Console.WriteLine($"{CourseCode} - {CourseName} ({CreditHours} Credit Hours)");
    }
}

// 🚀 Main Program
class Program
{
    static List<Student> students = new List<Student>();
    static List<Course> courses = new List<Course>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n** Welcome to Student Registration System **");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Course");
            Console.WriteLine("3. Enroll Student in Course");
            Console.WriteLine("4. View Student Report");
            Console.WriteLine("5. Exit");

            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddStudent();
                    break;
                case "2":
                    AddCourse();
                    break;
                case "3":
                    EnrollStudent();
                    break;
                case "4":
                    ViewStudentReport();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }
        }
    }

    static void AddStudent()
    {
        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Console.Write("Enter Student ID: ");
        string studentID = Console.ReadLine();

        Student newStudent = new Student(firstName, lastName, email, studentID);
        newStudent.Register();
        students.Add(newStudent);
    }

    static void AddCourse()
    {
        Console.Write("Enter Course Code: ");
        string courseCode = Console.ReadLine();

        Console.Write("Enter Course Name: ");
        string courseName = Console.ReadLine();

        Console.Write("Enter Credit Hours: ");
        int creditHours = int.Parse(Console.ReadLine());

        Course newCourse = new Course(courseCode, courseName, creditHours);
        courses.Add(newCourse);
        Console.WriteLine("Course added successfully!");
    }

    static void EnrollStudent()
    {
        Console.Write("Enter Student ID: ");
        string studentID = Console.ReadLine();

        Student student = students.Find(s => s.StudentID == studentID);

        if (student == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        Console.Write("Enter Course Code: ");
        string courseCode = Console.ReadLine();

        Course course = courses.Find(c => c.CourseCode == courseCode);

        if (course == null)
        {
            Console.WriteLine("Course not found.");
            return;
        }

        student.EnrollInCourse(course);
    }

    static void ViewStudentReport()
    {
        Console.Write("Enter Student ID: ");
        string studentID = Console.ReadLine();

        Student student = students.Find(s => s.StudentID == studentID);

        if (student == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        student.DisplayEnrollments();
    }
}