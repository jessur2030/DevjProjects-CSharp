using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jessur_lab4._3
{
    class Program
    {

        class Person
        {
            private string fname;
            public string Fname
            {
                get { return fname; }
                set { fname = value; }
            }
            private string mname;
            public string Mname
            {
                get { return mname; }
                set { mname = value; }
            }

            private string lname;
            public string Lname
            {
                get { return lname; }
                set { lname = value; }
            }
         
            private string street1;
            public string Street1
            {
                get{ return street1; }
                set { street1 = value; }
            }
     
            private string street2;
            public string Street2
            {
                get { return street2; }
                set { street2 = value; }
            }

            private string city;
            public string City
            {
                get { return city; }
                set { city = value; }
            }
            private string state;
            public string State
            {
                get { return state; }
                set { state = value; }
            }
            private string phoneN;
            public string PhoneN
            {
                get { return phoneN; }
                set { phoneN = value; }
            }
            private string zipCode;
            public string ZipCode
            {
                get { return zipCode; }
                set { zipCode = value; }
            }
            private string email;
            public string Email
            {
                get { return email; }
                set { email = value; }
            }

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
            temp.Street1 = Console.ReadLine();

            Console.Write("\n Please enter street2: ");
            temp.Street2 = Console.ReadLine();

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

            Console.Write($"\nFirst Name: {temp.Fname + " " + "Poopy"}");
            Console.Write($"\nMiddle Name: {temp.Mname}");
            Console.Write($"\nLast Name: {temp.Lname}");
            Console.Write($"\nStreet1: {temp.Street1}");
            Console.Write($"\nStreet2: {temp.Street2}");
            Console.Write($"\nSCity: {temp.City}");
            Console.Write($"\nZip code: {temp.ZipCode}");
            Console.Write($"\nPhone number: {temp.PhoneN}");
            Console.Write($"\nEmail: {temp.Email}");


            Console.WriteLine("n\n\nPress any key to continue");
            Console.ReadKey();






        }
    }
}
