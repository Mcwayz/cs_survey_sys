using System;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Survey_Sys
{
    public partial class frmQues : Form
    {
        public frmQues()
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

        public void addQuestionaire()
        {
            if(txtQno.Text == null && txtQname.Text == null && txtDesc.Text == null)
            {
                MessageBox.Show("Questionaire No, Questionaire Name, and Questionaire Description", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string questionaire = "INSERT INTO questionaire_tbl VALUES ('" + txtQno.Text + "','" + txtQname.Text + "','" + txtDesc.Text + "')";
                cmd = new OleDbCommand(questionaire, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtQno.Text = "";
                txtQname.Text = "";
                txtDesc.Text = "";
                dataSourceRefresher();

                MessageBox.Show("Questionaire Successfully Created", "Creation Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        
        }
        public void ClearData()
        {
            con.Open();
            string questionaire = "DELETE FROM questionaire_tbl;";
            cmd = new OleDbCommand(questionaire, con);
            cmd.ExecuteNonQuery();
            con.Close();

            txtQno.Text = "";
            txtQname.Text = "";
            txtDesc.Text = "";
            dataSourceRefresher();
        }

        public void ClearData1()
        {
            con.Open();
            string questionaire = "DELETE FROM response_tbl;";
            cmd = new OleDbCommand(questionaire, con);
            cmd.ExecuteNonQuery();
            con.Close();
            dataSourceRefresher();
        }
        public void ClearData2()
        {
            con.Open();
            string questionaire = "DELETE FROM question_tbl;";
            cmd = new OleDbCommand(questionaire, con);
            cmd.ExecuteNonQuery();
            con.Close();
            dataSourceRefresher();
        }
        public void ClearData3()
        {
            con.Open();
            string questionaire = "DELETE FROM answers_tbl;";
            cmd = new OleDbCommand(questionaire, con);
            cmd.ExecuteNonQuery();
            con.Close();
            dataSourceRefresher();
        }

        public void dataSourceRefresher()
        {
            // TODO: This line of code loads data into the 'dBDataSet.questionaire_tbl' table. You can move, or remove it, as needed.
            this.questionaire_tblTableAdapter.Fill(this.dBDataSet.questionaire_tbl);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            ClearData(); //calling the clear data function
            ClearData1(); //calling the clear data function
            ClearData2(); //calling the clear data function
            ClearData3(); //calling the clear data function

            addQuestionaire(); //calling the add questionaire function
        }

        private void frmQues_Load(object sender, EventArgs e)
        {
            dataSourceRefresher();
        }



        private void dataQuestionaire_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataQuestionaire.Rows[e.RowIndex];
                txtQno.Text = row.Cells[0].Value.ToString();
                txtQname.Text = row.Cells[1].Value.ToString();
                txtDesc.Text = row.Cells[2].Value.ToString();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        public void UpdateQ()
        {
            con.Open();
            string questionaire = "UPDATE questionaire_tbl SET question='"+txtQname.Text+"','"+txtDesc.Text+ "' WHERE questionaire_id='"+txtQno.Text+"'";
            cmd = new OleDbCommand(questionaire, con);
            cmd.ExecuteNonQuery();
            con.Close();

            txtQno.Text = "";
            txtQname.Text = "";
            txtDesc.Text = "";
            dataSourceRefresher();
        }


        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateQ();
        }
    }
}
