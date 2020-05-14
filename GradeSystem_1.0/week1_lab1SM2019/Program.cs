using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_lab1SM2019
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declare variables 
            String strfname, strgrade1, strgrade2, strgrade3, strgrade4;
            Double dblGrade1, dblGrade2, dblGrade3, dblGrade4, dblletterGrade = 0;
           

            Console.WriteLine("Hello There! Welcome to the student grades calculator");

            Console.WriteLine("Please enter your first name: ");
            strfname = Console.ReadLine();                      

           
            Console.WriteLine("Hello " + strfname + "  Let's calculate your grades!");


            Console.Write("Please enter the first grade: ");   //Prompt for the first grade
            strgrade1 = Console.ReadLine();

            Console.Write("Please enter the second grade: ");   //Prompt for the second grade
            strgrade2 = Console.ReadLine();

            Console.Write("Please enter the third grade: ");   //Prompt for the third grade:
            strgrade3 = Console.ReadLine();

            Console.Write("Please enter the fourth grade: ");   //Prompt for the fourth grade
            strgrade4 = Console.ReadLine();

            dblGrade1 = Convert.ToDouble(strgrade1);
            dblGrade2 = Convert.ToDouble(strgrade2);
            dblGrade3 = Convert.ToDouble(strgrade3);
            dblGrade4 = Convert.ToDouble(strgrade4);


            dblletterGrade = CalcAvg(dblGrade1, dblGrade2, dblGrade3, dblGrade4);
            dblletterGrade = CalcAvg(dblGrade1, dblGrade2, dblGrade3, dblGrade4);

            Console.WriteLine("Your letter grade is ---> " + DetermineGrade(dblletterGrade));
            Console.WriteLine("Your Average grade is -->" + (dblletterGrade));
            Console.WriteLine("\n\nPress Any Key to Continue");
            Console.ReadKey();
        }

        //calculations

        static double CalcAvg(Double Grade1, Double Grade2, Double Grade3, Double Grade4)
        {
            return (Grade1 + Grade2 + Grade3 + Grade4) / 4;
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
