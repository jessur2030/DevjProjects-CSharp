using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Lab5_jr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();




        }

        //public PersonList List1 = new PersonList();
        //int Count;
        ///****************
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Form1(int intPerson2_ID)
        {
            InitializeComponent();  //Creates and init's all form objects

            //Gather info about this one person and store it in a datareader
            Person2 temp = new Person2();
            SqlDataReader dr = temp.FindOnePerson2(intPerson2_ID);

            //Use that info to fill out the form
            //Loop thru the records stored in the reader 1 record at a time
            // Note that since this is based on one person's ID, then we
            //  should only have one record
            while (dr.Read())
            {
                //Take the Name(s) from the datareader and copy them
                // into the appropriate text fields
                txtFname.Text = dr["Fname"].ToString();
                txtLname.Text = dr["Lname"].ToString();
                //txtEmail.Text = dr["GPA"].ToString();
           
                txtSalary.Text = dr["Salary"].ToString();
                txtPhone_N.Text = dr["PhoneN_N"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                lblPerson2_ID.Text = dr["Person2_ID"].ToString();

                dtpDOB.Value = DateTime.Parse(dr["DOB"].ToString());
                dtpHireDate.Value = DateTime.Parse(dr["HireDate"].ToString());

                //We added this one to store the ID in a new label
                lblPerson2_ID.Text = dr["Person2_ID"].ToString();
            }


        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            Person2 temp = new Person2();


            temp.Fname = txtFname.Text;
            temp.Lname = txtLname.Text;
            temp.PhoneN = txtPhone_N.Text;
            temp.Email = txtEmail.Text;

            //Getting te dates from the datetime pickers
            temp.DOB = dtpDOB.Value;
            temp.Hiredate = dtpHireDate.Value;



            double dblSalary;
            bool blnResult = Double.TryParse(txtSalary.Text, out dblSalary);

            if (blnResult == false)
            {
                lblFeedback.Text += "Sorry invalid entry.  Please try again. (Ex: $214) ";
            }
            else
            {
                temp.Salary = dblSalary;
            }
            //**************************************************************************


            //**************************************************************************
            //get the string from Bookmark page # textboxes,convert to ints, set their values
            //**************************************************************************
            //double dblGPA;
            //blnResult = Double.TryParse(txtEmail.Text, out dblGPA);

            //if (blnResult == false)
            //{
            //    lblFeedback.Text += "Sorry invalid entry.   Please try again. (Ex: 0-4) ";
            //}
            //else
            //{
            //    temp.GPA = dblGPA;
            //}



            //int intPhone;
            //blnResult = Int32.TryParse(txtPhone.Text, out intPhone);

            //if (blnResult == false)
            //{
            //    lblFeedback.Text += "Sorry incorrect phone #.  Please try again. (Ex: 8005168282) ";
            //}
            //else
            //{
            //    temp.PhoneN = intPhone;
            //}
            ////**************************************************************************


            if (!temp.Feedback.Contains("ERROR:"))
            {
                lblFeedback.Text = temp.AddARecord();   //if no errors weh setting values, then perform the insertion into db
            }
            else
            {
                lblFeedback.Text = temp.Feedback;       //else...dispay the error msg
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

