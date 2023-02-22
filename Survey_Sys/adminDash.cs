using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey_Sys
{
    public partial class adminDash : Form
    {
        public adminDash()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btnQs_Click(object sender, EventArgs e)
        {
            new frmQs().Show();
            this.Hide();
        }

        private void btnAns_Click(object sender, EventArgs e)
        {
            new frmAns().Show();
            this.Hide();
        }

        private void btnResponse_Click(object sender, EventArgs e)
        {
            new frmResponse().Show();
            this.Hide();
        }

        private void btnQues_Click(object sender, EventArgs e)
        {
            new frmQues().Show();
            this.Hide();
        }
    }
}
