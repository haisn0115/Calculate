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
            int st1 = 0, st2 = 0, st3 = 0, st4 = 0, st5 = 0;

            string ContinueEnterMarks;

            do
            {
                try
                {
                    Console.Write("Enter Student Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Enter Marks (out of 100): ");
                    int marks = Convert.ToInt32(Console.ReadLine());

                    string grade ="F";
                    if (marks > 75)
                        grade = "A";
                    else if (marks > 65)
                        grade = "B";
                    else if (marks > 55)
                        grade = "C";
                    else if (marks >= 45)
                        grade = "S";
                    else 
                        grade ="F";

                    //  grade Counting
                    switch (grade)
                    {
                        case "A": st1++; break;
                        case "B": st2++; break;
                        case "C": st3++; break;
                        case "S": st4++; break;
                        case "F": st5++; break;
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
            Console.WriteLine("A Grades: " + st1);
            Console.WriteLine("B Grades: " + st2);
            Console.WriteLine("C Grades: " + st3);
            Console.WriteLine("S Grades: " + st4);
            Console.WriteLine("F Grades: " + st5);





            Console.WriteLine("\nThank you for using the Grade Calculator!");
            Console.ReadLine();
        }
    }
}
