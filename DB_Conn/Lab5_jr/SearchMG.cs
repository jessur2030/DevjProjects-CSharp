using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_jr
{
    public partial class SearchMG : Form
    {
        public SearchMG()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchMG_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Person2 temp = new Person2();
            //Perform the search we created in EBook class and store the returned dataset
            DataSet ds = temp.SearchPerson2(txtFname.Text, txtLname.Text);

            //Display data (dataset)
            dgvResults.DataSource = ds;                                  //point datagrid to dataset
            dgvResults.DataMember = ds.Tables["Person2_Temp"].ToString();
        }

        private void dgvResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Gather the information (Gathers the row clicked, then chooses the first cell's data
            string strPerson2_ID = dgvResults.Rows[e.RowIndex].Cells[0].Value.ToString();

            //Display data in Pop-up
            MessageBox.Show(strPerson2_ID);

            //Convert the string over to an integer
            int intPerson2_ID = Convert.ToInt32(strPerson2_ID);

            //Create the editor form, passing it one EBook's ID and show it
            // NOTE THAT THE ID BEING PASSED WILL CALL THE OVERLOADED VERSION
            // OF THE CONSTRUCTOR...TELL IT, IN ESSENCE THAT WE ARE PULLING UP
            // RATHER THAN ADDING DATA 
            Form1 Editor = new Form1(intPerson2_ID);
            Editor.ShowDialog();
        }
        private void txtLname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
