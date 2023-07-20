using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marksheet
{
    internal class Program
    {

    }
class Student
        {
            public string Name { get; set; }
            public int MathScore { get; set; }
            public int ScienceScore { get; set; }
            public int EnglishScore { get; set; }
            public int TotalScore { get; set; }
        }

        class Program1
        {
            static void Main(string[] args)
            {
                List<Student> students = new List<Student>();

                // Adding student details
                students.Add(new Student { Name = "archana", MathScore = 80, ScienceScore = 90, EnglishScore = 85 });
                students.Add(new Student { Name = "jayashri", MathScore = 75, ScienceScore = 95, EnglishScore = 80 });
                students.Add(new Student { Name = "rajlak", MathScore = 85, ScienceScore = 80, EnglishScore = 90 });
                students.Add(new Student { Name = "niki", MathScore = 95, ScienceScore = 85, EnglishScore = 75 });
                students.Add(new Student { Name = "jai", MathScore = 90, ScienceScore = 75, EnglishScore = 85 });

                bool exitProgram = false;

                while (!exitProgram)
                {
                    // Calculating total score for each student
                    foreach (var student in students)
                    {
                        student.TotalScore = student.MathScore + student.ScienceScore + student.EnglishScore;
                    }

                    // Displaying the marksheet
                    Console.WriteLine("Student Marksheet");
                    Console.WriteLine("=================");
                    Console.WriteLine("Name\tMath\tScience\tEnglish\tTotal");

                    foreach (var student in students)
                    {
                        Console.WriteLine($"{student.Name}\t{student.MathScore}\t{student.ScienceScore}\t{student.EnglishScore}\t{student.TotalScore}");
                    }

                    Console.WriteLine("\nDo you want to exit the program? (Y/N)");
                    string userInput = Console.ReadLine();

                    if (userInput.Equals("Y", StringComparison.OrdinalIgnoreCase))
                        exitProgram = true;
                }
            }
        }

    }

