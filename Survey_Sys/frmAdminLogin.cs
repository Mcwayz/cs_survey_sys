using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey_Sys
{
    public partial class frmAdminLogin : Form
    {
        public frmAdminLogin()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|DB.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public void loginUser()
        {
            
            con.Open();
            string login = "SELECT * FROM user_tbl WHERE username= '" + txtUsername.Text + "' and usr_password= '" + txtPass.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();


            if (dr.Read() == true)
            {
                MessageBox.Show("Welcome, Login Successful", "Login Successful", MessageBoxButtons.OK,MessageBoxIcon.Information);
                new adminDash().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPass.Text = "";
                txtUsername.Focus();
            }


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "")
            {
                MessageBox.Show("Please Enter Username","Username Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loginUser();
            }
            
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
