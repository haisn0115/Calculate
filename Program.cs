using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalStudents = 0;
            int Ac = 0, Bc = 0, Cc = 0, Sc = 0, Fc = 0;

            string ContinueEnterMarks;

            do
            {
                try
                {
                    Console.Write("Enter Student Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Marks (out of 100): ");
                    int marks = Convert.ToInt32(Console.ReadLine());

                    string grade = "F";
                    if (marks > 75)
                        grade = "A";
                    else if (marks > 65)
                        grade = "B";
                    else if (marks > 55)
                        grade = "C";
                    else if (marks >= 45)
                        grade = "S";

                    // Count grade
                    switch (grade)
                    {
                        case "A": Ac++; break;
                        case "B": Bc++; break;
                        case "C": Cc++; break;
                        case "S": Sc++; break;
                        case "F": Fc++; break;
                    }

                    totalStudents++;
                    Console.WriteLine("Student: " + name + ", Grade: " + grade);
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input! Please enter numeric marks.");
                    Console.ReadLine();
                }

                // Handle invalid input for "Do you want to enter another student?"
                bool validInput = false;
                do
                {
                    Console.Write("Do you want to enter another student? (y/n): ");
                    ContinueEnterMarks = Console.ReadLine().ToLower();

                    if (ContinueEnterMarks == "y" || ContinueEnterMarks == "n")
                    {
                        validInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter 'y' for yes or 'n' for no.");
                    }
                } while (!validInput);

            }while (ContinueEnterMarks == "y");

            // Summary Report
            Console.WriteLine("\n--- Summary Report ---");
            Console.WriteLine("Total Students: " + totalStudents);
            Console.WriteLine("A Grades: " + Ac);
            Console.WriteLine("B Grades: " + Bc);
            Console.WriteLine("C Grades: " + Cc);
            Console.WriteLine("S Grades: " + Sc);
            Console.WriteLine("F Grades: " + Fc);





            Console.WriteLine("\nThank you for using the Grade Calculator!");
            Console.ReadLine();
        }
    }
}
