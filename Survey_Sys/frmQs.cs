using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Survey_Sys
{
    public partial class frmQs : Form
    {
        public frmQs()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|DB.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void button1_Click(object sender, EventArgs e)
        {
            new adminDash().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        public void addQuestion()
        {
            if (cboQ.Text == "" && txtQno.Text == "" && txtQues.Text == "")
            {
                MessageBox.Show("Question No, Questionaire No, and Question", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string question = "INSERT INTO question_tbl VALUES ('" + txtQno.Text + "','" + cboQ.SelectedValue.ToString() + "','" + txtQues.Text + "')";
                cmd = new OleDbCommand(question, con);
                cmd.ExecuteNonQuery();
                con.Close();

                cboQ.SelectedIndex = 0;
                txtQno.Text = "";
                txtQues.Text = "";

                MessageBox.Show("Question Successfully Added", "Addition Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //calling the Add Question function 
            addQuestion();
        }

        private void frmQs_Load(object sender, EventArgs e)
        {

            dataSourceRefresher();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtQno.Text = row.Cells[0].Value.ToString();
                cboQ.Text = row.Cells[1].Value.ToString();
                txtQues.Text = row.Cells[2].Value.ToString();


            }
        }

        public void dataSourceRefresher()
        {
            // TODO: This line of code loads data into the 'dBDataSet.questionaire_tbl' table. You can move, or remove it, as needed.
            this.questionaire_tblTableAdapter.Fill(this.dBDataSet.questionaire_tbl);
            // TODO: This line of code loads data into the 'dBDataSet.question_tbl' table. You can move, or remove it, as needed.
            this.question_tblTableAdapter.Fill(this.dBDataSet.question_tbl);
        }
        public void UpdateQ()
        {
            con.Open();
            string questionaire = "UPDATE question_tbl SET question='" + txtQues.Text + "' WHERE question_id='" + txtQno.Text + "'";
            cmd = new OleDbCommand(questionaire, con);
            cmd.ExecuteNonQuery();
            con.Close();

            txtQno.Text = "";
            txtQues.Text = "";
            dataSourceRefresher();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateQ();
        }
    }
}
