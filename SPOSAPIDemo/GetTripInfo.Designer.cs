namespace SPOSAPIDemo
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
            this.txterr_msg = new System.Windows.Forms.TextBox();
            this.txterr_num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.voyage_date = new System.Windows.Forms.Label();
            this.trip_id = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBox3.Location = new System.Drawing.Point(-1, 83);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(569, 252);
            this.groupBox3.TabIndex = 10;
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
            this.departure_status.MinimumWidth = 6;
            this.departure_status.Name = "departure_status";
            this.departure_status.ReadOnly = true;
            this.departure_status.Width = 125;
            // 
            // arrival_status
            // 
            this.arrival_status.HeaderText = "arrival_status";
            this.arrival_status.MinimumWidth = 6;
            this.arrival_status.Name = "arrival_status";
            this.arrival_status.ReadOnly = true;
            this.arrival_status.Width = 125;
            // 
            // checkin_status
            // 
            this.checkin_status.HeaderText = "checkin_status";
            this.checkin_status.MinimumWidth = 6;
            this.checkin_status.Name = "checkin_status";
            this.checkin_status.ReadOnly = true;
            this.checkin_status.Width = 125;
            // 
            // pre_imm_status
            // 
            this.pre_imm_status.HeaderText = "pre_imm_status";
            this.pre_imm_status.MinimumWidth = 6;
            this.pre_imm_status.Name = "pre_imm_status";
            this.pre_imm_status.ReadOnly = true;
            this.pre_imm_status.Width = 125;
            // 
            // boarding_status
            // 
            this.boarding_status.HeaderText = "boarding_status";
            this.boarding_status.MinimumWidth = 6;
            this.boarding_status.Name = "boarding_status";
            this.boarding_status.ReadOnly = true;
            this.boarding_status.Width = 125;
            // 
            // boarding_time
            // 
            this.boarding_time.HeaderText = "boarding_time";
            this.boarding_time.MinimumWidth = 6;
            this.boarding_time.Name = "boarding_time";
            this.boarding_time.ReadOnly = true;
            this.boarding_time.Width = 125;
            // 
            // boarding_close_time
            // 
            this.boarding_close_time.HeaderText = "boarding_close_time";
            this.boarding_close_time.MinimumWidth = 6;
            this.boarding_close_time.Name = "boarding_close_time";
            this.boarding_close_time.ReadOnly = true;
            this.boarding_close_time.Width = 125;
            // 
            // pre_imm_time
            // 
            this.pre_imm_time.HeaderText = "pre_imm_time";
            this.pre_imm_time.MinimumWidth = 6;
            this.pre_imm_time.Name = "pre_imm_time";
            this.pre_imm_time.ReadOnly = true;
            this.pre_imm_time.Width = 125;
            // 
            // pontoon_status
            // 
            this.pontoon_status.HeaderText = "pontoon_status";
            this.pontoon_status.MinimumWidth = 6;
            this.pontoon_status.Name = "pontoon_status";
            this.pontoon_status.ReadOnly = true;
            this.pontoon_status.Width = 125;
            // 
            // trip_date
            // 
            this.trip_date.HeaderText = "trip_date";
            this.trip_date.MinimumWidth = 6;
            this.trip_date.Name = "trip_date";
            this.trip_date.ReadOnly = true;
            this.trip_date.Width = 125;
            // 
            // stb
            // 
            this.stb.HeaderText = "stb";
            this.stb.MinimumWidth = 6;
            this.stb.Name = "stb";
            this.stb.ReadOnly = true;
            this.stb.Width = 125;
            // 
            // stu
            // 
            this.stu.HeaderText = "stu";
            this.stu.MinimumWidth = 6;
            this.stu.Name = "stu";
            this.stu.ReadOnly = true;
            this.stu.Width = 125;
            // 
            // atb
            // 
            this.atb.HeaderText = "atb";
            this.atb.MinimumWidth = 6;
            this.atb.Name = "atb";
            this.atb.ReadOnly = true;
            this.atb.Width = 125;
            // 
            // atu
            // 
            this.atu.HeaderText = "atu";
            this.atu.MinimumWidth = 6;
            this.atu.Name = "atu";
            this.atu.ReadOnly = true;
            this.atu.Width = 125;
            // 
            // etb
            // 
            this.etb.HeaderText = "etb";
            this.etb.MinimumWidth = 6;
            this.etb.Name = "etb";
            this.etb.ReadOnly = true;
            this.etb.Width = 125;
            // 
            // etu
            // 
            this.etu.HeaderText = "etu";
            this.etu.MinimumWidth = 6;
            this.etu.Name = "etu";
            this.etu.ReadOnly = true;
            this.etu.Width = 125;
            // 
            // vessel_id
            // 
            this.vessel_id.HeaderText = "vessel_id";
            this.vessel_id.MinimumWidth = 6;
            this.vessel_id.Name = "vessel_id";
            this.vessel_id.ReadOnly = true;
            this.vessel_id.Width = 125;
            // 
            // vessel_name
            // 
            this.vessel_name.HeaderText = "vessel_name";
            this.vessel_name.MinimumWidth = 6;
            this.vessel_name.Name = "vessel_name";
            this.vessel_name.ReadOnly = true;
            this.vessel_name.Width = 125;
            // 
            // checked_in
            // 
            this.checked_in.HeaderText = "checked_in";
            this.checked_in.MinimumWidth = 6;
            this.checked_in.Name = "checked_in";
            this.checked_in.ReadOnly = true;
            this.checked_in.Width = 125;
            // 
            // total_checked_in
            // 
            this.total_checked_in.HeaderText = "total_checked_in";
            this.total_checked_in.MinimumWidth = 6;
            this.total_checked_in.Name = "total_checked_in";
            this.total_checked_in.ReadOnly = true;
            this.total_checked_in.Width = 125;
            // 
            // pre_imm
            // 
            this.pre_imm.HeaderText = "pre_imm";
            this.pre_imm.MinimumWidth = 6;
            this.pre_imm.Name = "pre_imm";
            this.pre_imm.ReadOnly = true;
            this.pre_imm.Width = 125;
            // 
            // total_pre_imm
            // 
            this.total_pre_imm.HeaderText = "total_pre_imm";
            this.total_pre_imm.MinimumWidth = 6;
            this.total_pre_imm.Name = "total_pre_imm";
            this.total_pre_imm.ReadOnly = true;
            this.total_pre_imm.Width = 125;
            // 
            // boarding
            // 
            this.boarding.HeaderText = "boarding";
            this.boarding.MinimumWidth = 6;
            this.boarding.Name = "boarding";
            this.boarding.ReadOnly = true;
            this.boarding.Width = 125;
            // 
            // total_boarding
            // 
            this.total_boarding.HeaderText = "total_boarding";
            this.total_boarding.MinimumWidth = 6;
            this.total_boarding.Name = "total_boarding";
            this.total_boarding.ReadOnly = true;
            this.total_boarding.Width = 125;
            // 
            // pontoon
            // 
            this.pontoon.HeaderText = "pontoon";
            this.pontoon.MinimumWidth = 6;
            this.pontoon.Name = "pontoon";
            this.pontoon.ReadOnly = true;
            this.pontoon.Width = 125;
            // 
            // total_pontoon
            // 
            this.total_pontoon.HeaderText = "total_pontoon";
            this.total_pontoon.MinimumWidth = 6;
            this.total_pontoon.Name = "total_pontoon";
            this.total_pontoon.ReadOnly = true;
            this.total_pontoon.Width = 125;
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
            // GetTripInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 344);
            this.Controls.Add(this.trip_id);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.voyage_date);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Name = "GetTripInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Trip Info";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label trip_id;
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
        private System.Windows.Forms.TextBox txterr_msg;
        private System.Windows.Forms.TextBox txterr_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label voyage_date;
        //private System.Windows.Forms.Label trip_id;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn etu;
        //private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn etb;
        //private System.Windows.Forms.GroupBox groupBox3;
        //private System.Windows.Forms.DataGridView dataGridView2;
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
    }
}