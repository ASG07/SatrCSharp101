using System;
using System.Collections.Generic;

namespace Satr_1
{
    public class Student
    {
        public string Name { get; set; }
        public double Marks { get; set; }

        public override string ToString() => $"Name: {Name} \t Mark: {Marks} \t {(Marks >= 60 ? "Passed" : "Failed")}";
    }

    class Program
    {
        static void Main(string[] args)
        {

            Student Ahmed = new Student();
            List<Student> studentsList = new List<Student>();

            while (true)
            {
                Console.Write("Enter Student Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Student Marks: ");
                string markString = Console.ReadLine();

                double mark;
                bool valid = double.TryParse(markString, out mark);
                if (valid && mark <= 100 && mark >= 0)
                {
                    AddStudent(name, mark, studentsList);

                    foreach (var student in studentsList)
                    {
                        //add color to the text based on whether the student failed or passed
                        if (student.ToString().Contains("Failed")) Console.ForegroundColor = ConsoleColor.Red; else Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine(student.ToString(), Console.ForegroundColor);
                    }
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"{markString} is not a correct mark");
                }
                Console.WriteLine("\n");
            }
        }

        private static void AddStudent(string name, double mark, List<Student> studentsList)
        {
            studentsList.Add(new Student { Name = name, Marks = mark });
        }
    }

    
}
