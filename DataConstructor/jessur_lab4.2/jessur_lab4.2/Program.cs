using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jessur_lab4._2
{
    class Program
    {

       class Person
        {
            public string Fname ;
            public string Mname;
            public string Lname;
            public string street1;
            public string street2;
            public string City;
            public string State;
            public string PhoneN;
            public string ZipCode;
            public string Email;

        }
            static void Main(string[] args)
        {

                //bool blnResult = false;

                Person temp = new Person();

                Console.Write("\n Please enter your first name:  ");
                temp.Fname = Console.ReadLine();
            

                Console.Write("\n Please enter your middle name: ");
                temp.Mname = Console.ReadLine();

                Console.Write("\n Please enter your last name: ");
                temp.Lname = Console.ReadLine();

                Console.Write("\n Please enter street1: ");
                temp.street1 = Console.ReadLine();

                Console.Write("\n Please enter street2: ");
                temp.street2 = Console.ReadLine();

                Console.Write("\n Please enter your city: ");
                temp.City = Console.ReadLine();

                Console.Write("\n Please enter your state: ");
                temp.State = Console.ReadLine();

                Console.Write("\n Please enter your zip code: ");
                temp.ZipCode = Console.ReadLine();

                Console.Write("\n Please enter your phone number: ");
                temp.PhoneN = Console.ReadLine();

                Console.Write("\n Please enter your email: ");
                temp.Email = Console.ReadLine();



                Console.Write("\n\nPerson Information:");

                Console.Write($"\nFirst Name: {temp.Fname }");
                Console.Write($"\nMiddle Name: {temp.Mname}");
                Console.Write($"\nLast Name: {temp.Lname}");
                Console.Write($"\nStreet1: {temp.street1}");
                Console.Write($"\nStreet2: {temp.street2}");
                Console.Write($"\nSCity: {temp.City}");
                Console.Write($"\nZip code: {temp.ZipCode}");
                Console.Write($"\nPhone number: {temp.PhoneN}");
                Console.Write($"\nEmail: {temp.Email}");


                Console.WriteLine("n\n\nPress any key to continue");
                Console.ReadKey();






            }
        }
    }
