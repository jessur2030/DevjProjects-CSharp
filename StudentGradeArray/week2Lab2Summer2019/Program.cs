using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2Lab2Summer2019
{
    class Program
    {
        static void Main(string[] args)
        {


            //Declare variables 
            String strStudents, strgrade;
            Double dblletterGrade = 0, dblTotal = 0;
            Double dblLabGrade = 5;
            Int32 intStudents;
            bool blnDetermine = false;



            Console.WriteLine("Hello There! Welcome to the student grades calculator");

            Console.WriteLine("How many students are you going to enter: ");
            strStudents = Console.ReadLine();
            intStudents = Int32.Parse(strStudents);

            //Array of students
            Double[] dblAveGrades = new Double[intStudents];


            //loop for students names


            double[] grades = new double[5];

            for (int i = 1; i <= intStudents; i++)
            {
                dblTotal = 0;
                do
                {
                    Console.WriteLine("Please enter the student name: ");
                    strStudents = Console.ReadLine();
                    Console.WriteLine("Hello " + strStudents + "  Let's calculate your grades!");


                    //array of 5 lab grades
                    //loop lab grades
                    for (int j = 0; j < 5; j++)

                    {
                        Console.Write("Please enter Student lab grade #" + (j + 1) + ": ");
                        strgrade = Console.ReadLine();
                        blnDetermine = Double.TryParse(strgrade, out dblLabGrade);


                        //  dblletterGrade = CalcAvg(dblLabGrade);
                        if (blnDetermine == false)
                        {
                            Console.WriteLine("\n\nSorry, but you did not enter a valid number in digits: Ex 1234 ");
                        }
                        else

                        {
                            grades[j] += dblLabGrade;
                            dblTotal += dblLabGrade;
                        }
                    }
                    dblletterGrade = CalcAvg(ref dblTotal);
                    Console.WriteLine("Your letter grade is ---> " + DetermineGrade(dblTotal));
                    Console.WriteLine("Your Average grade is -->" + (dblletterGrade));
                } while (blnDetermine == false);

            }
            for (var i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Average Student grade for lab#" + (i + 1) + ": " + grades[i] / intStudents);
            }

            Console.WriteLine("\n\nPress Any Key to Continue");
            Console.ReadKey();
        }

        //calculations
        static double CalcAvg(ref Double Grade1)
        {
            return (Grade1) / 5;
        }

        //assign letter grades
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
