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
    public partial class UIControl : Form
    {
        public UIControl()
        {
            InitializeComponent();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form1 temp = new Form1();
            temp.Show();
        }

        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            SearchMG temp = new SearchMG();
            temp.Show();
        }

        private void UIControl_Load(object sender, EventArgs e)
        {

        }
    }
}
