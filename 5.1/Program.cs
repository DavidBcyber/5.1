using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1
{
    internal class Program
    {
        // using the data to manage students grades
        static List<string> student = new List<string>(); // list of grades
        static void Main(string[] args)
        {
            int grade = 0; // user input

            //user gets ask what differnt type of method whould they like to use
            Console.WriteLine("Welcome to grade managament application");

            while (true) // loop
            {

                Console.WriteLine("1. Add Grade\n " +
                   "2. Remove Graden\n " +
                   "3. Display Grade\n " +
                   "4. Calculate Average\n " +
                   "5. Find Highest & Lowesr Grade\n " +
                   "6. Exit\n");

                Console.WriteLine("Enter your choice:");
                grade = Convert.ToInt32(Console.ReadLine());
                // import of the menu

                switch (grade)
                {
                    case 1:
                        // add grade
                        AddGrade();
                        break;
                    case 2:
                        // remove grade
                        RemoveGrade();
                        break;
                    case 3:
                        // display grade
                        DisplayGrade();
                        break;
                    case 4:
                        // average
                        AverageGrade();
                        break;
                    case 5:
                        //highest and lowest grade
                        HighestandLowestGrade();
                        break;
                    case 6:
                        //Exit
                        return; // leave site
                    default:
                        //invaild grade
                        Console.WriteLine("Invaild Option");
                        break;
                }



            }
        }
        // way to add grade
        static void AddGrade()
        {
            Console.WriteLine("Enter Grade to add");
            string grade = Console.ReadLine();

            student.Add(grade); // add grade to the system
            Console.WriteLine(grade + "Grade added successfully");
        }
        static void RemoveGrade()
        {
            Console.WriteLine("Enter the grade to be removed");
            string grade = Console.ReadLine();
            if (student.Contains(grade))
            {
                student.Remove(grade);
                Console.WriteLine(grade + "is removed form the system");
            }
            else
            {
                Console.WriteLine(grade + "is not in the system");
            }


        }
        static void DisplayGrade()
        {
            Console.WriteLine("Here is all grades");
            foreach (string student in student)
            {
                Console.WriteLine("*"+ student);
            }
        }
        static void AverageGrade()
        {
            var arr = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            double grade = Queryable.Average(arr.AsQueryable());
            Console.WriteLine("Average = " + grade);
        }
        static void HighestandLowestGrade()
        {
            int[] grade = new int[100];


            int max = grade[0];
            int min = grade[0];

            foreach (var number in grade)
            {
                if (number > max)
                {
                    max = number;
                }

                if (number < min)
                {
                    min = number;
                }
            }

            Console.WriteLine($"The max value for grade is: {max}");
            Console.WriteLine($"the min value for grade is: {min}");
        }
    }
}