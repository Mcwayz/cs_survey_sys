using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Survey_Sys
{
    public partial class frmResponse : Form
    {
        public frmResponse()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|DB.mdb");
    

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
      
        public void chartData()
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                string query = "SELECT * FROM response_tbl";
                cmd.CommandText = query;

                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    chart1.Series["Response"].Points.AddXY(reader["Q1"].ToString(), reader["Q2"].ToString(), reader["Q3"].ToString(), reader["Q4"].ToString());
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Chart Retrival Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmResponse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBDataSet.response_tbl' table. You can move, or remove it, as needed.
            this.response_tblTableAdapter.Fill(this.dBDataSet.response_tbl);

        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            chartData();
        }

        private void dataResponse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = dataResponse.Rows[e.RowIndex];
                txtNo.Text = row.Cells[0].Value.ToString();
                txtAns1.Text = row.Cells[1].Value.ToString();
                txtAns2.Text = row.Cells[2].Value.ToString();
                txtAns3.Text = row.Cells[3].Value.ToString();
                txtAns4.Text = row.Cells[4].Value.ToString();

            }

        }
    }
}
