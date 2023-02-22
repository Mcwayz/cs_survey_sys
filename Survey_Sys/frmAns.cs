using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Survey_Sys
{
    public partial class frmAns : Form
    {
        public frmAns()
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
            new adminDash().Show();
            this.Hide();
        }
        public void addAnswer()
        {
            if (cboQ.Text == "" && txtAnsNo.Text =="" && txtAns.Text == "")
            {
                MessageBox.Show("Enter Question No and Answer", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string question = "INSERT INTO answers_tbl VALUES ('" + txtAnsNo.Text + "','" + cboQ.Text + "','" + txtAns.Text + "')";
                cmd = new OleDbCommand(question, con);
                cmd.ExecuteNonQuery();
                con.Close();

                cboQ.SelectedIndex = 0;
                txtAns.Text = "";
                refreshData();
                MessageBox.Show("Answer Successfully Added", "Addition Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Calling the answer function
            addAnswer();
        }
        public void refreshData()
        {
            // TODO: This line of code loads data into the 'dBDataSet.question_tbl' table. You can move, or remove it, as needed.
            this.question_tblTableAdapter.Fill(this.dBDataSet.question_tbl);
            // TODO: This line of code loads data into the 'dBDataSet.answers_tbl' table. You can move, or remove it, as needed.
            this.answers_tblTableAdapter.Fill(this.dBDataSet.answers_tbl);
        }

        private void frmAns_Load(object sender, EventArgs e)
        {
            refreshData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtAnsNo.Text = row.Cells[0].Value.ToString();
                cboQ.Text = row.Cells[1].Value.ToString();
                txtAns.Text = row.Cells[2].Value.ToString();


            }
        }

        public void UpdateQ()
        {
            con.Open();
            string questionaire = "UPDATE answers_tbl SET question='" + txtAns.Text + "' WHERE answer_id='" + txtAnsNo.Text + "'";
            cmd = new OleDbCommand(questionaire, con);
            cmd.ExecuteNonQuery();
            con.Close();

            txtAns.Text = "";
            txtAnsNo.Text = "";

            refreshData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateQ();
        }
    }
}
