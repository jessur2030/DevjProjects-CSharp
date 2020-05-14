
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_project
{
    class Program
    {
        public const int allPeriods = 5;

        public static List<Student> studentList = new List<Student>();

        public static void Main(string[] args)
        {
            ShowMenu();
        }

        public static void ShowAverages()
        {
            Console.Clear();
            Console.WriteLine("----------------------------\r");
            Console.WriteLine("*** Grade Average System ***\r");
            Console.WriteLine("----------------------------\r");
            Console.WriteLine("         AVERAGE LIST       \r");
            Console.WriteLine("----------------------------\r\n");

            if (studentList.Count > 0)
            {
                int count = 0;
                foreach (Student student in studentList)
                {
                    count++;

                    Console.WriteLine("____________________________\r");
                    Console.WriteLine(string.Format("Studen #{0}: {1} \r", count, student.GetName()));
                    Console.WriteLine(string.Format("Average: {0} ", student.CalculateAverage()));
                    Console.WriteLine(string.Format("Letter Grade: {0} ", DetermineGrade(student.CalculateAverage())));
                    Console.WriteLine("____________________________\r\n");
                }
            }
            else
            {
                Console.WriteLine("Sorry, student averages list is empty!\r");
            }
        }

        public static void ShowMenu()
        {
            Console.WriteLine("*** Grade average system ***\r");
            Console.WriteLine("------------------------\n");

            // Ask the user to choose an option
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add average");
            Console.WriteLine("\tv - View averages");
            Console.WriteLine("\te - Exit\n");
            Console.Write("Your option? ");

            // Use a switch statement to do the math
            switch (Console.ReadLine())
            {
                case "a":
                    CatchGrades();
                    break;
                case "v":
                    ShowAverages();
                    break;
                case "e":
                    Console.Write("Good bye!!\n");
                    break;
            }
            // Wait for the user to respond before closing
            Console.Write("Press any key to close the console app...");
            Console.ReadKey();
        }

        public static string DetermineGrade(double average)
        {
            if (average >= 90)
            {
                return "A";
            }
            else if (average >= 80 && average < 90)
            {
                return "B";
            }
            else if (average >= 70 && average < 80)
            {
                return "C";
            }
            else
            {
                return "D";
            }
        }

        public static void CatchGrades()
        {
            string name;
            List<Grade> gradeList = new List<Grade>();

            Console.Clear();

            // What's your name?
            Console.WriteLine("What's your name?");
            name = Console.ReadLine();
            Console.WriteLine("\nPlease enter your grades!\n");

            //Creating new Object Student...
            Student student = new Student(ref name);

            for (int period = 1; period <= allPeriods; period++)
            {
                double grade = 0;

                Console.WriteLine("Enter your grade for Lab #" + period);
                grade = Convert.ToDouble(Console.ReadLine());

                //Adding current grade to List
                gradeList.Add(new Grade(ref period, ref grade));
            }

            student.SetGradeList(gradeList);
            studentList.Add(student);

            double avg = student.CalculateAverage();

            //Showing student grade average...
            Console.WriteLine("Hi again " + name + " your average is: " + avg + ", Grade Letter: " + DetermineGrade(avg) + "\n\n");
        
            //display the avg of all lab grades
            //for (var i = 0; i < allPeriods; i++)
            //{
            //    Console.WriteLine("Average Student grade for lab#" + (i + 1) + ": " + allPeriods / grade);
            //}


            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();

            ShowMenu();

        }


    }

    class Student
    {
        string name;
        List<Grade> gradeList = new List<Grade>();

        public double CalculateAverage()
        {
            double acumulatedGrade = 0;
            for (int i = 0; i < this.gradeList.Count; i++)
            {
                acumulatedGrade += this.gradeList[i].GetGrade();
            }
            return acumulatedGrade / this.gradeList.Count;
        }

        public Student(ref string name)
        {
            this.name = name;
        }

        public void SetName( ref string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetGradeList(List<Grade> gradeList)
        {
            this.gradeList = gradeList;
        }

        public List<Grade> GetGradeList()
        {
            return this.gradeList;
        }
    }

    class Grade
    {
        int period;
        double grade;

        public Grade(ref int period, ref double grade)
        {
            this.period = period;
            this.grade = grade;
        }

        public double GetGrade()
        {
            return this.grade;
        }




        static double CalcAvg(double grade)
        {
            return (grade) / 5;
        }
        //assign letter grade
        static string DetermineGrade(double avg)
        {
            if (avg >= 90)
            {
                return "A";
            }
            else if (avg >= 80)
            {
                return "B";
            }
            else if (avg >= 70)
            {
                return "C";
            }

            else if (avg >= 60)
                return "D";

            else
            {
                return "F";
            }
        }
    }
}