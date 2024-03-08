namespace SPOSAPIDemo
{
    partial class SubmitCheckIn
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.out_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.out_str = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boarding_pass_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pax_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txterr_msg = new System.Windows.Forms.TextBox();
            this.txterr_num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmitCheckIn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.txterr_msg);
            this.groupBox3.Controls.Add(this.txterr_num);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 70);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1351, 340);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "API Response";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.out_num,
            this.out_str,
            this.boarding_pass_number,
            this.pax_id});
            this.dataGridView2.Location = new System.Drawing.Point(27, 67);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1318, 267);
            this.dataGridView2.TabIndex = 4;
            // 
            // out_num
            // 
            this.out_num.HeaderText = "out_num";
            this.out_num.MinimumWidth = 6;
            this.out_num.Name = "out_num";
            this.out_num.ReadOnly = true;
            this.out_num.Width = 125;
            // 
            // out_str
            // 
            this.out_str.HeaderText = "out_str";
            this.out_str.MinimumWidth = 6;
            this.out_str.Name = "out_str";
            this.out_str.ReadOnly = true;
            this.out_str.Width = 125;
            // 
            // boarding_pass_number
            // 
            this.boarding_pass_number.HeaderText = "boarding_pass_number";
            this.boarding_pass_number.MinimumWidth = 6;
            this.boarding_pass_number.Name = "boarding_pass_number";
            this.boarding_pass_number.ReadOnly = true;
            this.boarding_pass_number.Width = 180;
            // 
            // pax_id
            // 
            this.pax_id.HeaderText = "pax_id";
            this.pax_id.MinimumWidth = 6;
            this.pax_id.Name = "pax_id";
            this.pax_id.ReadOnly = true;
            this.pax_id.Width = 125;
            // 
            // txterr_msg
            // 
            this.txterr_msg.Location = new System.Drawing.Point(328, 30);
            this.txterr_msg.Name = "txterr_msg";
            this.txterr_msg.ReadOnly = true;
            this.txterr_msg.Size = new System.Drawing.Size(174, 22);
            this.txterr_msg.TabIndex = 3;
            // 
            // txterr_num
            // 
            this.txterr_num.Location = new System.Drawing.Point(85, 27);
            this.txterr_num.Name = "txterr_num";
            this.txterr_num.ReadOnly = true;
            this.txterr_num.Size = new System.Drawing.Size(174, 22);
            this.txterr_num.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "err_msg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "err_num";
            // 
            // btnSubmitCheckIn
            // 
            this.btnSubmitCheckIn.Location = new System.Drawing.Point(1190, 18);
            this.btnSubmitCheckIn.Name = "btnSubmitCheckIn";
            this.btnSubmitCheckIn.Size = new System.Drawing.Size(151, 29);
            this.btnSubmitCheckIn.TabIndex = 6;
            this.btnSubmitCheckIn.Text = "Submit Check In";
            this.btnSubmitCheckIn.UseVisualStyleBackColor = true;
            this.btnSubmitCheckIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt3);
            this.groupBox1.Controls.Add(this.btnSubmitCheckIn);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt2);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1351, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voyage Details";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(480, 21);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(313, 22);
            this.txt3.TabIndex = 5;
            this.txt3.Text = "501447";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "pax_details";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(273, 21);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(95, 22);
            this.txt2.TabIndex = 3;
            this.txt2.Text = "20240307";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(71, 21);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(79, 22);
            this.txt1.TabIndex = 2;
            this.txt1.Text = "HFF124";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "voyage_date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "trip_id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(795, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(361, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "* list pax detail id, separate by comma \',\'. Ex: 501447, 501448";
            // 
            // SubmitCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 422);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "SubmitCheckIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Submit CheckIn";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn out_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn out_str;
        private System.Windows.Forms.DataGridViewTextBoxColumn boarding_pass_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn pax_id;
        private System.Windows.Forms.TextBox txterr_msg;
        private System.Windows.Forms.TextBox txterr_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmitCheckIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}