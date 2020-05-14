using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using jessur_lab4._2;
using System.Text.RegularExpressions;

namespace Lab5_jr
{
   public class Person
    {

        private string fname;
        private string lname;
        //private double gpa;
        private DateTime dob;
        private double salary;
        private string phoneN;//Fields for Name and ID
        private DateTime hiredate;


        protected string feedback;

        //public Person()//Default constructor
        //{
        //}
        //public Person(string fname)
        //{
        //    this.Fname = fname;
        //    this.Lname = lname;
        //    this.GPA = gpa;
        //    this.DOB = dob;
        //    this.Salary = salary;
        //    this.PhoneN = phoneN;
        //    this.Hiredate = hiredate;

        //}

        //public Person(string fname, string lname, string gpa, string dob,
        //    string salary, string phoneN, string hiredate)  //constructor
        //{
        //    this.Fname = fname;
        //    this.Lname = lname;
        //    this.GPA = gpa;
        //    this.DOB = dob;
        //    this.Salary = salary;
        //    this.PhoneN = phoneN;
        //    this.Hiredate = hiredate;
        //}






        public string Fname   //property for fname
        {
            get
            {

                return fname;
            }
            set
            {
                fname = value;
            }
        }

        public string Lname   //property for lname
        {
            get
            {

                return lname;
            }
            set
            {
                lname = value;
            }
        }


        //public double GPA
        //{
        //    get
        //    {
        //        return gpa;
        //    }

        //    set
        //    {
        //        double grdptavg = Convert.ToDouble(GPA);
        //        //Check for ValidLength
        //        //ssn < 100000000 || ssn > 999999999
        //        if (grdptavg <= 0 || grdptavg <= 4)
        //        {
        //            gpa = value;
        //        }
        //        else
        //        {
        //            //Store an error msg in Feedback
        //            feedback += "\nERROR: Sorry you entered an invalid entry.";
        //        }
        //    }
        //    }
        ////street2
        public double Salary
        {
            get
            {
                return salary;
            }

            
            set
            {
                int moneyAvg = Convert.ToInt32(value);
                //Check for ValidLength
                if (Validate.IsMinimumAmount(moneyAvg, 1) == true)
                {
                    salary = value;
                }
                else
                {
                    //Store an error msg in Feedback
                    feedback += "\nERROR: Sorry you entered an invalid entry: try again EXP: $1000.";
                }
            }
        }

        public DateTime DOB
        {
            get
            {
                return dob;
            }

            set
            {
               // DateTime DateOFB = DateTime.Now.Date;
                if (Validate.IsAFutureDate(value) == false)
                {
                    dob = value;
                }
                else
                {
                    //Future Date...Store error msg in feedback
                    feedback += "\nERROR: You cannot enter future dates";
                }
            }
        }
        //City

        //public int PhoneN
        //{
        //    get
        //    {
        //        return phoneN;
        //    }

        //    set
        //    {
        //        //if we have the miimum number of pages needed...
        //        if (value >= 0 && value <= phoneN)
        //        {
        //            phoneN = value;  //store the # of pages
        //        }
        //        else
        //        {
        //            //Store an error msg in Feedback
        //            feedback += "\nERROR: Sorry you entered an invalid page # for a bookmark.";
        //        }
        //    }
        //}

        public string PhoneN //property for ID
        {
            get
            {
                return phoneN;
            }
            set
            {

                phoneN = value;
            }

        }


        //public string PhoneN
        //{
        //    get
        //    {
        //        return phoneN;
        //    }



        //    set
        //    {
        //        ///int phone = Convert.ToInt32(value);
        //        //Check for ValidLength
        //        //IsValidphone
        //        //Check for ValidLength
        //        if (Validate.IsValidphone(value))
        //        {
        //            phoneN = value;
        //        }
        //        else
        //        {
        //            //Store an error msg in Feedback
        //            feedback += "\nERROR: Sorry you entered an invalid phone number.";
        //        }
        //    }
        //}



        public DateTime Hiredate //property for ID
        {
            get
            {
                return hiredate;
            }
            set
            {
                DateTime hireD = Convert.ToDateTime(value);
                if (Validate.IsAFutureDate(hireD) == false)
                {
                    hiredate = value;
                }
                else
                {
                    //Store an error msg in Feedback
                    feedback += "\nERROR: You must enter a valid date.";
                }

            }

        }


        public string Feedback
        {
            get { return feedback; }

        }

        public Person()
        {
            //Initialize so that there are no nulls, especially feedback
            fname = "";
            lname = "";
           // gpa = 0.0;
            dob = DateTime.Parse("1/1/1500");
            salary = 0.0;
            phoneN = "";
            hiredate = DateTime.Parse("1/1/15");
            
            feedback = "";
        }

    

    }

}


