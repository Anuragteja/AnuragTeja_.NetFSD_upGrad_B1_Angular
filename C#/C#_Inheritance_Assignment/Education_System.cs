using System;

namespace Inheritance_Assignment
{
    // Base Class
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public double Marks { get; set; }
        public Student(int id, string name, double marks)
        {
            StudentId = id;
            Name = name;
            Marks = marks;
        }
        public virtual string CalculateGrade()
        {
            return Marks > 50 ? "Pass" : "Fail";
        }
    }
    public class SchoolStudent : Student
    {
        public SchoolStudent(int id, string name, double marks)
            : base(id, name, marks) { }

        public override string CalculateGrade()
        {
            return Marks > 40 ? "Pass" : "Fail";
        }
    }
    public class CollegeStudent : Student
    {
        public CollegeStudent(int id, string name, double marks)
            : base(id, name, marks) { }

        public override string CalculateGrade()
        {
            return Marks > 50 ? "Pass" : "Fail";
        }
    }
    public class OnlineStudent : Student
    {
        public OnlineStudent(int id, string name, double marks)
            : base(id, name, marks) { }

        public override string CalculateGrade()
        {
            return Marks > 60 ? "Pass" : "Fail";
        }
    }
    internal class Education_System
    {
        static void Main()
        {
            Student[] students = new Student[]
            {
                new SchoolStudent(1, "Ravi", 45),
                new CollegeStudent(2, "Anu", 55),
                new OnlineStudent(3, "John", 58),
                new SchoolStudent(4, "Priya", 35)
            };

            foreach (Student s in students)
            {
                Console.WriteLine($"ID: {s.StudentId}, Name: {s.Name}, Marks: {s.Marks}, Grade: {s.CalculateGrade()}");
            }
        }
    }
}