
namespace Survey_Sys
{
    partial class frmResponse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAns1 = new System.Windows.Forms.TextBox();
            this.txtAns4 = new System.Windows.Forms.TextBox();
            this.txtAns3 = new System.Windows.Forms.TextBox();
            this.txtAns2 = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataResponse = new System.Windows.Forms.DataGridView();
            this.responseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.q1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.q2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.q3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.q4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsetblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new Survey_Sys.DBDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.response_tblTableAdapter = new Survey_Sys.DBDataSetTableAdapters.response_tblTableAdapter();
            this.btnChart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataResponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsetblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAns1);
            this.groupBox1.Controls.Add(this.btnChart);
            this.groupBox1.Controls.Add(this.txtAns4);
            this.groupBox1.Controls.Add(this.txtAns3);
            this.groupBox1.Controls.Add(this.txtAns2);
            this.groupBox1.Controls.Add(this.txtNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(680, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtAns1
            // 
            this.txtAns1.Location = new System.Drawing.Point(98, 100);
            this.txtAns1.Name = "txtAns1";
            this.txtAns1.Size = new System.Drawing.Size(116, 20);
            this.txtAns1.TabIndex = 10;
            // 
            // txtAns4
            // 
            this.txtAns4.Location = new System.Drawing.Point(98, 351);
            this.txtAns4.Name = "txtAns4";
            this.txtAns4.Size = new System.Drawing.Size(116, 20);
            this.txtAns4.TabIndex = 8;
            // 
            // txtAns3
            // 
            this.txtAns3.Location = new System.Drawing.Point(98, 265);
            this.txtAns3.Name = "txtAns3";
            this.txtAns3.Size = new System.Drawing.Size(116, 20);
            this.txtAns3.TabIndex = 7;
            // 
            // txtAns2
            // 
            this.txtAns2.Location = new System.Drawing.Point(98, 181);
            this.txtAns2.Name = "txtAns2";
            this.txtAns2.Size = new System.Drawing.Size(116, 20);
            this.txtAns2.TabIndex = 6;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(98, 19);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(116, 20);
            this.txtNo.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Response No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Question 4 Ans :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Question 3 Ans :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question 2 Ans :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Question 1 Ans :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chart1);
            this.groupBox2.Controls.Add(this.dataResponse);
            this.groupBox2.Location = new System.Drawing.Point(220, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 502);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dataResponse
            // 
            this.dataResponse.AutoGenerateColumns = false;
            this.dataResponse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataResponse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.responseidDataGridViewTextBoxColumn,
            this.q1DataGridViewTextBoxColumn,
            this.q2DataGridViewTextBoxColumn,
            this.q3DataGridViewTextBoxColumn,
            this.q4DataGridViewTextBoxColumn});
            this.dataResponse.DataSource = this.responsetblBindingSource;
            this.dataResponse.Location = new System.Drawing.Point(10, 19);
            this.dataResponse.Name = "dataResponse";
            this.dataResponse.Size = new System.Drawing.Size(437, 197);
            this.dataResponse.TabIndex = 0;
            this.dataResponse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataResponse_CellContentClick);
            // 
            // responseidDataGridViewTextBoxColumn
            // 
            this.responseidDataGridViewTextBoxColumn.DataPropertyName = "response_id";
            this.responseidDataGridViewTextBoxColumn.HeaderText = "response_id";
            this.responseidDataGridViewTextBoxColumn.Name = "responseidDataGridViewTextBoxColumn";
            // 
            // q1DataGridViewTextBoxColumn
            // 
            this.q1DataGridViewTextBoxColumn.DataPropertyName = "Q1";
            this.q1DataGridViewTextBoxColumn.HeaderText = "Q1";
            this.q1DataGridViewTextBoxColumn.Name = "q1DataGridViewTextBoxColumn";
            // 
            // q2DataGridViewTextBoxColumn
            // 
            this.q2DataGridViewTextBoxColumn.DataPropertyName = "Q2";
            this.q2DataGridViewTextBoxColumn.HeaderText = "Q2";
            this.q2DataGridViewTextBoxColumn.Name = "q2DataGridViewTextBoxColumn";
            // 
            // q3DataGridViewTextBoxColumn
            // 
            this.q3DataGridViewTextBoxColumn.DataPropertyName = "Q3";
            this.q3DataGridViewTextBoxColumn.HeaderText = "Q3";
            this.q3DataGridViewTextBoxColumn.Name = "q3DataGridViewTextBoxColumn";
            // 
            // q4DataGridViewTextBoxColumn
            // 
            this.q4DataGridViewTextBoxColumn.DataPropertyName = "Q4";
            this.q4DataGridViewTextBoxColumn.HeaderText = "Q4";
            this.q4DataGridViewTextBoxColumn.Name = "q4DataGridViewTextBoxColumn";
            // 
            // responsetblBindingSource
            // 
            this.responsetblBindingSource.DataMember = "response_tbl";
            this.responsetblBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Consumer Responses";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(604, 544);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 9;
            this.button2.Text = "Logout >";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "< Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // response_tblTableAdapter
            // 
            this.response_tblTableAdapter.ClearBeforeFill = true;
            // 
            // btnChart
            // 
            this.btnChart.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.Location = new System.Drawing.Point(10, 441);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(204, 49);
            this.btnChart.TabIndex = 9;
            this.btnChart.Text = "Reload Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(10, 222);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Response";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(437, 273);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // frmResponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(701, 576);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmResponse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResponse";
            this.Load += new System.EventHandler(this.frmResponse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataResponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsetblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataResponse;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAns4;
        private System.Windows.Forms.TextBox txtAns3;
        private System.Windows.Forms.TextBox txtAns2;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtAns1;
        private System.Windows.Forms.Label label1;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource responsetblBindingSource;
        private DBDataSetTableAdapters.response_tblTableAdapter response_tblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn responseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn q1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn q2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn q3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn q4DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}