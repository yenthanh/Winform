namespace WindowsFormsApp1
{
    partial class GetTripInfo
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
            this.txterr_msg = new System.Windows.Forms.TextBox();
            this.txterr_num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.voyage_date = new System.Windows.Forms.Label();
            this.trip_id = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.trip_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gate_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departure_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrival_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkin_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pre_imm_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boarding_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boarding_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boarding_close_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pre_imm_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontoon_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trip_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vessel_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vessel_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checked_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_checked_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pre_imm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_pre_imm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boarding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_boarding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontoon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_pontoon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.txterr_msg);
            this.groupBox3.Controls.Add(this.txterr_num);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(569, 252);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Get Trip Info";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trip_code,
            this.origin,
            this.destination,
            this.gate_id,
            this.departure_status,
            this.arrival_status,
            this.checkin_status,
            this.pre_imm_status,
            this.boarding_status,
            this.boarding_time,
            this.boarding_close_time,
            this.pre_imm_time,
            this.pontoon_status,
            this.trip_date,
            this.stb,
            this.stu,
            this.atb,
            this.atu,
            this.etb,
            this.etu,
            this.vessel_id,
            this.vessel_name,
            this.checked_in,
            this.total_checked_in,
            this.pre_imm,
            this.total_pre_imm,
            this.boarding,
            this.total_boarding,
            this.pontoon,
            this.total_pontoon});
            this.dataGridView2.Location = new System.Drawing.Point(6, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(555, 175);
            this.dataGridView2.TabIndex = 4;
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
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(360, 15);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(174, 22);
            this.txt2.TabIndex = 8;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(86, 12);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(174, 22);
            this.txt1.TabIndex = 7;
            // 
            // voyage_date
            // 
            this.voyage_date.AutoSize = true;
            this.voyage_date.Location = new System.Drawing.Point(267, 18);
            this.voyage_date.Name = "voyage_date";
            this.voyage_date.Size = new System.Drawing.Size(87, 16);
            this.voyage_date.TabIndex = 6;
            this.voyage_date.Text = "voyage_date";
            // 
            // trip_id
            // 
            this.trip_id.AutoSize = true;
            this.trip_id.Location = new System.Drawing.Point(25, 18);
            this.trip_id.Name = "trip_id";
            this.trip_id.Size = new System.Drawing.Size(43, 16);
            this.trip_id.TabIndex = 5;
            this.trip_id.Text = "trip_id";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Get Trip Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trip_code
            // 
            this.trip_code.HeaderText = "trip_code";
            this.trip_code.MinimumWidth = 6;
            this.trip_code.Name = "trip_code";
            this.trip_code.ReadOnly = true;
            this.trip_code.Width = 125;
            // 
            // origin
            // 
            this.origin.HeaderText = "origin";
            this.origin.MinimumWidth = 6;
            this.origin.Name = "origin";
            this.origin.ReadOnly = true;
            this.origin.Width = 125;
            // 
            // destination
            // 
            this.destination.HeaderText = "destination";
            this.destination.MinimumWidth = 6;
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            this.destination.Width = 125;
            // 
            // gate_id
            // 
            this.gate_id.HeaderText = "gate_id";
            this.gate_id.MinimumWidth = 6;
            this.gate_id.Name = "gate_id";
            this.gate_id.ReadOnly = true;
            this.gate_id.Width = 125;
            // 
            // departure_status
            // 
            this.departure_status.HeaderText = "departure_status";
            this.departure_status.Name = "departure_status";
            this.departure_status.ReadOnly = true;
            // 
            // arrival_status
            // 
            this.arrival_status.HeaderText = "arrival_status";
            this.arrival_status.Name = "arrival_status";
            this.arrival_status.ReadOnly = true;
            // 
            // checkin_status
            // 
            this.checkin_status.HeaderText = "checkin_status";
            this.checkin_status.Name = "checkin_status";
            this.checkin_status.ReadOnly = true;
            // 
            // pre_imm_status
            // 
            this.pre_imm_status.HeaderText = "pre_imm_status";
            this.pre_imm_status.Name = "pre_imm_status";
            this.pre_imm_status.ReadOnly = true;
            // 
            // boarding_status
            // 
            this.boarding_status.HeaderText = "boarding_status";
            this.boarding_status.Name = "boarding_status";
            this.boarding_status.ReadOnly = true;
            // 
            // boarding_time
            // 
            this.boarding_time.HeaderText = "boarding_time";
            this.boarding_time.Name = "boarding_time";
            this.boarding_time.ReadOnly = true;
            // 
            // boarding_close_time
            // 
            this.boarding_close_time.HeaderText = "boarding_close_time";
            this.boarding_close_time.Name = "boarding_close_time";
            this.boarding_close_time.ReadOnly = true;
            // 
            // pre_imm_time
            // 
            this.pre_imm_time.HeaderText = "pre_imm_time";
            this.pre_imm_time.Name = "pre_imm_time";
            this.pre_imm_time.ReadOnly = true;
            // 
            // pontoon_status
            // 
            this.pontoon_status.HeaderText = "pontoon_status";
            this.pontoon_status.Name = "pontoon_status";
            this.pontoon_status.ReadOnly = true;
            // 
            // trip_date
            // 
            this.trip_date.HeaderText = "trip_date";
            this.trip_date.Name = "trip_date";
            this.trip_date.ReadOnly = true;
            // 
            // stb
            // 
            this.stb.HeaderText = "stb";
            this.stb.Name = "stb";
            this.stb.ReadOnly = true;
            // 
            // stu
            // 
            this.stu.HeaderText = "stu";
            this.stu.Name = "stu";
            this.stu.ReadOnly = true;
            // 
            // atb
            // 
            this.atb.HeaderText = "atb";
            this.atb.Name = "atb";
            this.atb.ReadOnly = true;
            // 
            // atu
            // 
            this.atu.HeaderText = "atu";
            this.atu.Name = "atu";
            this.atu.ReadOnly = true;
            // 
            // etb
            // 
            this.etb.HeaderText = "etb";
            this.etb.Name = "etb";
            this.etb.ReadOnly = true;
            // 
            // etu
            // 
            this.etu.HeaderText = "etu";
            this.etu.Name = "etu";
            this.etu.ReadOnly = true;
            // 
            // vessel_id
            // 
            this.vessel_id.HeaderText = "vessel_id";
            this.vessel_id.Name = "vessel_id";
            this.vessel_id.ReadOnly = true;
            // 
            // vessel_name
            // 
            this.vessel_name.HeaderText = "vessel_name";
            this.vessel_name.Name = "vessel_name";
            this.vessel_name.ReadOnly = true;
            // 
            // checked_in
            // 
            this.checked_in.HeaderText = "checked_in";
            this.checked_in.Name = "checked_in";
            this.checked_in.ReadOnly = true;
            // 
            // total_checked_in
            // 
            this.total_checked_in.HeaderText = "total_checked_in";
            this.total_checked_in.Name = "total_checked_in";
            this.total_checked_in.ReadOnly = true;
            // 
            // pre_imm
            // 
            this.pre_imm.HeaderText = "pre_imm";
            this.pre_imm.Name = "pre_imm";
            this.pre_imm.ReadOnly = true;
            // 
            // total_pre_imm
            // 
            this.total_pre_imm.HeaderText = "total_pre_imm";
            this.total_pre_imm.Name = "total_pre_imm";
            this.total_pre_imm.ReadOnly = true;
            // 
            // boarding
            // 
            this.boarding.HeaderText = "boarding";
            this.boarding.Name = "boarding";
            this.boarding.ReadOnly = true;
            // 
            // total_boarding
            // 
            this.total_boarding.HeaderText = "total_boarding";
            this.total_boarding.Name = "total_boarding";
            this.total_boarding.ReadOnly = true;
            // 
            // pontoon
            // 
            this.pontoon.HeaderText = "pontoon";
            this.pontoon.Name = "pontoon";
            this.pontoon.ReadOnly = true;
            // 
            // total_pontoon
            // 
            this.total_pontoon.HeaderText = "total_pontoon";
            this.total_pontoon.Name = "total_pontoon";
            this.total_pontoon.ReadOnly = true;
            // 
            // GetTripInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.voyage_date);
            this.Controls.Add(this.trip_id);
            this.Name = "GetTripInfo";
            this.Text = "GetTripInfo";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txterr_msg;
        private System.Windows.Forms.TextBox txterr_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label voyage_date;
        private System.Windows.Forms.Label trip_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn trip_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn origin;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn gate_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn departure_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrival_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkin_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn pre_imm_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn boarding_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn boarding_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn boarding_close_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn pre_imm_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontoon_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn trip_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn stb;
        private System.Windows.Forms.DataGridViewTextBoxColumn stu;
        private System.Windows.Forms.DataGridViewTextBoxColumn atb;
        private System.Windows.Forms.DataGridViewTextBoxColumn atu;
        private System.Windows.Forms.DataGridViewTextBoxColumn etb;
        private System.Windows.Forms.DataGridViewTextBoxColumn etu;
        private System.Windows.Forms.DataGridViewTextBoxColumn vessel_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vessel_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn checked_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_checked_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn pre_imm;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_pre_imm;
        private System.Windows.Forms.DataGridViewTextBoxColumn boarding;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_boarding;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontoon;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_pontoon;
    }
}