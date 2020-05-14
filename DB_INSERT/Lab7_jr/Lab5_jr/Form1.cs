using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Lab5_jr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public PersonList List1 = new PersonList();
        int Count;
        ///****************
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            Person2 temp = new Person2();


            temp.Fname = txtFname.Text;
            temp.Lname = txtLname.Text;
            temp.PhoneN = txtPhone_N.Text;
            temp.Facebook = txtFacebook.Text;

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
            double dblGPA;
            blnResult = Double.TryParse(txtGPA.Text, out dblGPA);

            if (blnResult == false)
            {
                lblFeedback.Text += "Sorry invalid entry.   Please try again. (Ex: 0-4) ";
            }
            else
            {
                temp.GPA = dblGPA;
            }



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
    }
}

