using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Survey_Sys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|DB.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        public void loginUser()
        {
            con.Open();
            string login = "SELECT * FROM user_tbl WHERE username= '" + txtUsername.Text + "' AND usr_password= '" + txtPass.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
               MessageBox.Show("Welcome, Login Successful", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
               con.Close();
               new frmWelcome().Show();
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

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please Enter Username", "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPass.Text == "")
            {
                MessageBox.Show("Please Enter Password", "Username Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //calling the login function 
                loginUser();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new frmAdminLogin().Show();
            this.Hide();
        }
    }
}
