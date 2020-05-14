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

        private string email;


        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                //Is the email format proper?
                if (Validate.IsValidEmail(value))
                {
                    email = value;      //Yes...store it
                }
                else
                {
                    feedback += "\nERROR: Invalid email."; //Else...leve feedback error msg
                }
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
            string strSQL = "INSERT INTO SE245_JRosario.dbo.Person_4 ( Fname,  Lname, DOB, Salary, PhoneN, Email, Hiredate) VALUES (@Fname, @Lname, @DOB, @Salary, @PhoneN, @Email, @Hiredate)";
            // Bark out our command
            SqlCommand comm = new SqlCommand();
            comm.CommandText = strSQL;  //Commander knows what to say
            comm.Connection = Conn;     //Where's the phone?  Here it is

            //Fill in the paramters (Has to be created in same sequence as they are used in SQL Statement)
            comm.Parameters.AddWithValue("@Fname", Fname);
            comm.Parameters.AddWithValue("@Lname", Lname);
       
            comm.Parameters.AddWithValue("@DOB", DOB);
            comm.Parameters.AddWithValue("@Salary", Salary);
            comm.Parameters.AddWithValue("@PhoneN", PhoneN);
            comm.Parameters.AddWithValue("@Email", Email);
            comm.Parameters.AddWithValue("@HireDate", Hiredate);
           


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



        public DataSet SearchPerson2(String strFname, String strLname)
        {
            //Create a dataset to return filled
            DataSet ds = new DataSet();


            //Create a command for our SQL statement
            SqlCommand comm = new SqlCommand();


            //Write a Select Statement to perform Search
            String strSQL = "SELECT Person2_ID, Fname, Lname FROM SE245_JRosario.dbo.Person_4 WHERE 0=0";

            //If the First/Last Name is filled in include it as search criteria
            if (strFname.Length > 0)
            {
                strSQL += " AND Fname LIKE @Fname";
                comm.Parameters.AddWithValue("@Fname", "%" + strFname + "%");
            }
            if (strLname.Length > 0)
            {
                strSQL += " AND Lname LIKE @Lname";
                comm.Parameters.AddWithValue("@Lname", "%" + strLname + "%");
            }


            //Create DB tools and Configure
            //*********************************************************************************************
            SqlConnection conn = new SqlConnection();
            //Create the who, what where of the DB
            string strConn = @GetConnected();
            conn.ConnectionString = strConn;

            //Fill in basic info to command object
            comm.Connection = conn;     //tell the commander what connection to use
            comm.CommandText = strSQL;  //tell the command what to say

            //Create Data Adapter
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = comm;    //commander needs a translator(dataAdapter) to speak with datasets

            //*********************************************************************************************

            //Get Data
            conn.Open();                //Open the connection (pick up the phone)
            da.Fill(ds, "Person2_Temp");     //Fill the dataset with results from database and call it "EBooks_Temp"
            conn.Close();               //Close the connection (hangs up phone)

            //Return the data
            return ds;
        }







        //NEW  - Method that returns a Data Reader filled with all the data
        // of one EBook.  This one EBook is specified by the ID passed
        // to this function
        public SqlDataReader FindOnePerson2(int intPerson2_ID)
        {
            //Create and Initialize the DB Tools we need
            SqlConnection conn = new SqlConnection();
            SqlCommand comm = new SqlCommand();

            //My Connection String
            string strConn = GetConnected();

            //My SQL command string to pull up one EBook's data
            string sqlString =
           "SELECT * FROM SE245_JRosario.dbo.Person_4 WHERE Person2_ID = @Person2_ID;";

            //Tell the connection object the who, what, where, how
            conn.ConnectionString = strConn;

            //Give the command object info it needs
            comm.Connection = conn;
            comm.CommandText = sqlString;
            comm.Parameters.AddWithValue("@Person2_ID", intPerson2_ID);

            //Open the DataBase Connection and Yell our SQL Command
            conn.Open();

            //Return some form of feedback
            return comm.ExecuteReader();   //Return the dataset to be used by others (the calling form)

        }










        //**************************************************************************************
        //  NEW - Utility function so that one string controls all SQL Server Login info
        //**************************************************************************************
        //private string GetConnected()
        //{
        //    return "Server=sql.neit.edu,4500;Database=SE245_SLAMBERT;User Id=SE245_JBIANCOV2;Password=SE245;";
        //}




        private string GetConnected()
        {
            return "Server=sql.neit.edu,4500;Database=SE245_JRosario;User Id=SE245_JRosario;Password=tuloave2020;";
        }




        public Person2() : base()  //Calls the parents constructor
        {
          email = "";
            //dateRentalExpires = DateTime.Now.AddDays(14);
        }
    }
}
