using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey_Sys
{
    public partial class frmUserDash : Form
    {
        public frmUserDash()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|DB.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public String Qs1, Qs2, Qs3, Qs4;

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        //function that queries  question 1
        public void question1()
        {
            string Q1 = "Q1";
            con.Open();
            string question1 = "SELECT * FROM question_tbl WHERE question_id= '" + Q1 + "'";
            cmd = new OleDbCommand(question1, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                lblQ1.Text = dr["question"].ToString();

            }
            con.Close();
        }

        //function that queries  question 2
        public void question2()
        {
            string Q2 = "Q2";
            con.Open();
            string question2 = "SELECT * FROM question_tbl WHERE question_id= '" + Q2 + "'";
            cmd = new OleDbCommand(question2, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                lblQ2.Text = dr["question"].ToString();

            }
            con.Close();
        }

        //function that queries  question 3
        public void question3()
        {
            string Q3 = "Q3";
            con.Open();
            string question3 = "SELECT * FROM question_tbl WHERE question_id= '" + Q3 + "'";
            cmd = new OleDbCommand(question3, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                lblQ3.Text = dr["question"].ToString();

            }
            con.Close();
        }

        //function that queries  question 4
        public void question4()
        {
            string Q4 = "Q4";
            con.Open();
            string question3 = "SELECT * FROM question_tbl WHERE question_id= '" + Q4 + "'";
            cmd = new OleDbCommand(question3, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                lblQ4.Text = dr["question"].ToString();

            }
            con.Close();
        }

        //function that calls all question functions
        public void questions()
        {
            question1();
            question2();
            question3();
            question4();
        }

        //function that calls all answer functions
        public void answers()
        {
            Q1A1();
            Q1A2();
            Q3A1();
            Q3A2();
            Q3A3();
            Q3A4();
            Q3A5();
            AnsQ2();
            AnsQ4();

        }

        //function that queries  answers
        public void Q1A1()
        {
            string Q1 = "Q1";
            string A1 = "A1";
            con.Open();
            string answers = "SELECT * FROM answers_tbl WHERE question_id= '" + Q1 + "' AND answer_id= '" + A1 + "'";
            cmd = new OleDbCommand(answers, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                rad1.Text = dr["answer"].ToString();

            }
            con.Close();
        }


        //function that queries  answers
        public void Q1A2()
        {
            string Q1 = "Q1";
            string A2 = "A2";
            con.Open();
            string answers = "SELECT * FROM answers_tbl WHERE question_id= '" + Q1 + "' AND answer_id= '" + A2 + "'";
            cmd = new OleDbCommand(answers, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                rad2.Text = dr["answer"].ToString();

            }
            con.Close();
        }

        //function that queries  answers
        public void Q3A1()
        {
            string Q3 = "Q3";
            string A1 = "A6";
            con.Open();
            string answers = "SELECT * FROM answers_tbl WHERE question_id= '" + Q3 + "' AND answer_id= '" + A1 + "'";
            cmd = new OleDbCommand(answers, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                chk1.Text = dr["answer"].ToString();

            }
            con.Close();
        }

        //function that queries  answers
        public void Q3A2()
        {
            string Q3 = "Q3";
            string A2 = "A7";
            con.Open();
            string answers = "SELECT * FROM answers_tbl WHERE question_id= '" + Q3 + "' AND answer_id= '" + A2 + "'";
            cmd = new OleDbCommand(answers, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                chk2.Text = dr["answer"].ToString();

            }
            con.Close();
        }


        //function that queries  answers
        public void Q3A3()
        {
            string Q3 = "Q3";
            string A3 = "A8";
            con.Open();
            string answers = "SELECT * FROM answers_tbl WHERE question_id= '" + Q3 + "' AND answer_id= '" + A3 + "'";
            cmd = new OleDbCommand(answers, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                chk3.Text = dr["answer"].ToString();

            }
            con.Close();
        }

        //function that queries  answers
        public void Q3A4()
        {
            string Q3 = "Q3";
            string A4 = "A9";
            con.Open();
            string answers = "SELECT * FROM answers_tbl WHERE question_id= '" + Q3 + "' AND answer_id= '" + A4 + "'";
            cmd = new OleDbCommand(answers, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                chk5.Text = dr["answer"].ToString();

            }
            con.Close();
        }

        //function that queries  answers
        public void Q3A5()
        {
            string Q3 = "Q3";
            string A5 = "A10";
            con.Open();
            string answers = "SELECT * FROM answers_tbl WHERE question_id= '" + Q3 + "' AND answer_id= '" + A5 + "'";
            cmd = new OleDbCommand(answers, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                chk4.Text = dr["answer"].ToString();

            }
            con.Close();
        }

        //function that queries  answers
        public void AnsQ2()
        {
            string Q2 = "Q2";
            con.Open();
            string answers = "SELECT * FROM answers_tbl WHERE question_id= '" + Q2 +"'";
            cmd = new OleDbCommand(answers, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                
                cboQ2.Items.Add(dr["answer"].ToString());

            }
            con.Close();
        }

        //function that queries  answers
        public void AnsQ4()
        {
            string Q4 = "Q4";
            con.Open();
            string answers = "SELECT * FROM answers_tbl WHERE question_id= '" + Q4 + "'";
            cmd = new OleDbCommand(answers, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cboQ4.Items.Add(dr["answer"].ToString());
            }
            con.Close();
        }

        public void respond()
        {
               Random rd = new Random();
                int rand_num = rd.Next(100, 200);
                con.Open();
                string response = "INSERT INTO response_tbl VALUES ('" + rand_num + "','" + Qs1 + "','" + Qs2 + "','" + Qs3 + "','" + Qs4 + "')";
                cmd = new OleDbCommand(response, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thank you for your feedback", "Feedback", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (chk1.Checked == false && chk2.Checked == false && chk3.Checked == false && chk4.Checked == false && chk5.Checked == false)
            {
                MessageBox.Show("Please Answer All Questions", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (rad1.Checked == false && rad2.Checked == false)
            {
                MessageBox.Show("Please Answer All Questions", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cboQ2.SelectedItem == null && cboQ4.SelectedItem == null)
            {
                MessageBox.Show("Please Answer All Questions", "Missing Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //calling the respond function
                respond();
                new frmWelcome().Show();
                this.Hide();
            }
        }

        private void frmUserDash_Load(object sender, EventArgs e)
        {
            questions();
            answers();
        }

        private void rad1_CheckedChanged(object sender, EventArgs e)
        {
            if(rad1.Checked == true)
            {
                rad2.Checked = false;
                Qs1 = "Yes";
            }
        }

        private void rad2_CheckedChanged(object sender, EventArgs e)
        {
            if (rad2.Checked == true)
            {
                rad1.Checked = false;
                Qs1 = "No";
            }
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            if(chk1.Checked == true)
            {
                Qs3 = "Strongly Disagree";
                chk2.Checked = false;
                chk3.Checked = false;
                chk4.Checked = false;
                chk5.Checked = false;
            }
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2.Checked == true)
            {
                Qs3 = "Disagree";
                chk1.Checked = false;
                chk3.Checked = false;
                chk4.Checked = false;
                chk5.Checked = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cboQ2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Qs2 = cboQ2.SelectedItem.ToString();
        }

        private void cboQ4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Qs4 = cboQ4.SelectedItem.ToString();
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3.Checked == true)
            {
                Qs3 = "Neutral";
                chk2.Checked = false;
                chk1.Checked = false;
                chk4.Checked = false;
                chk5.Checked = false;
            }
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            if (chk4.Checked == true)
            {
                Qs3 = "Agree";
                chk2.Checked = false;
                chk3.Checked = false;
                chk1.Checked = false;
                chk5.Checked = false;
            }
        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            if (chk5.Checked == true)
            {
                Qs3 = "Strongly Agree";
                chk2.Checked = false;
                chk3.Checked = false;
                chk4.Checked = false;
                chk1.Checked = false;
            }
        }
    }
}
