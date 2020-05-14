using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using jessur_lab4._2;

namespace Lab5_jr
{
     class Person2 : Person

    {

        private string facebook;

      
        public string Facebook
        {
            get
            {
                return facebook;
            }

            set
            {
                facebook = value;
            }

        }


        public string AddARecord()
        {
            //Init string var
            string strResult = "";

            //Make a connection object
            SqlConnection Conn = new SqlConnection();

            //Initialize it's properties
           // Conn.ConnectionString = @GetConnected();
            Conn.ConnectionString = @"Server=sql.neit.edu,4500;Database=SE245_JRosario;User Id=SE245_JRosario;Password=tuloave2020;";     //Set the Who/What/Where of DB

            //[SE245_JRosario].[dbo].[Person2] 
            //*******************************************************************************************************
            string strSQL = "INSERT INTO SE245_JRosario.dbo.Person2 ( Fname,  Lname, GPA, DOB, Salary, PhoneN, Hiredate, Facebook) VALUES (@Fname, @Lname, @GPA, @DOB, @Salary, @PhoneN, @Hiredate, @Facebook)";
            // Bark out our command
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;  //Commander knows what to say
            comm.Connection = Conn;     //Where's the phone?  Here it is

            //Fill in the paramters (Has to be created in same sequence as they are used in SQL Statement)
            comm.Parameters.AddWithValue("@Fname", Fname);
            comm.Parameters.AddWithValue("@Lname", Lname);
            comm.Parameters.AddWithValue("@GPA", GPA);
            comm.Parameters.AddWithValue("@DOB", DOB);
            comm.Parameters.AddWithValue("@Salary", Salary);
            comm.Parameters.AddWithValue("@PhoneN", PhoneN);
            comm.Parameters.AddWithValue("@HireDate", Hiredate);
            comm.Parameters.AddWithValue("@Facebook", Facebook);


            //*******************************************************************************************************

            //attempt to connect to the server
            try
            {
                Conn.Open();                                        //Open connection to DB - Think of dialing a friend on phone
                int intRecs = comm.ExecuteNonQuery();
                strResult = $"SUCCESS: Inserted {intRecs} records.";       //Report that we made the connection and added a record
                Conn.Close();                                       //Hanging up after phone call
            }
            catch (Exception err)                                   //If we got here, there was a problem connecting to DB
            {
                strResult = "ERROR: " + err.Message;                //Set feedback to state there was an error & error info
            }
            finally
            {

            }

            //Return resulting feedback string
            return strResult;
        }



        //private string GetConnected()
        //{
        //    return "Server=sql.neit.edu,4500;Database=SE245_JRosario;User Id=SE245_JRosario;Password=tuloave2020;";
        //}




        public Person2() : base()  //Calls the parents constructor
        {
            facebook = "";
            //dateRentalExpires = DateTime.Now.AddDays(14);
        }
    }
}
