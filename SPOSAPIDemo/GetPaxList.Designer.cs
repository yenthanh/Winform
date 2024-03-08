namespace SPOSAPIDemo
{
    partial class GetPaxList
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
            this.voyage_date = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txterr_msg = new System.Windows.Forms.TextBox();
            this.txterr_num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trip_id = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.pax_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticket_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.travel_document_exp_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country_issue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country_residence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_travel_flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pre_imm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.immigration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boarding = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontoon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancelled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transfer_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baggage_tag_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ntl_flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_min_pax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_booking_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Economy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pax_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.security_program_flag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bag_allowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additional_baggage_allowance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membership_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.source_check_in = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boarding_pass_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // voyage_date
            // 
            this.voyage_date.AutoSize = true;
            this.voyage_date.Location = new System.Drawing.Point(314, 13);
            this.voyage_date.Name = "voyage_date";
            this.voyage_date.Size = new System.Drawing.Size(87, 16);
            this.voyage_date.TabIndex = 24;
            this.voyage_date.Text = "voyage_date";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.txterr_msg);
            this.groupBox3.Controls.Add(this.txterr_num);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(-1, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1364, 366);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Get Pax List";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pax_id,
            this.passport_number,
            this.ticket_number,
            this.last_name,
            this.first_name,
            this.gender,
            this.nationality,
            this.dob,
            this.travel_document_exp_date,
            this.country_issue,
            this.country_residence,
            this.destination,
            this.group_travel_flag,
            this.date_created,
            this.create_by,
            this.date_updated,
            this.updated_by,
            this.checkin,
            this.pre_imm,
            this.immigration,
            this.boarding,
            this.pontoon,
            this.cancelled,
            this.remarks,
            this.transfer_from,
            this.baggage_tag_number,
            this.ntl_flag,
            this.last_min_pax,
            this.customer_booking_code,
            this.Economy,
            this.pax_type,
            this.security_program_flag,
            this.bag_allowance,
            this.additional_baggage_allowance,
            this.membership_no,
            this.source_check_in,
            this.ssr,
            this.passport_type,
            this.boarding_pass_number});
            this.dataGridView2.Location = new System.Drawing.Point(6, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1352, 292);
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
            // trip_id
            // 
            this.trip_id.AutoSize = true;
            this.trip_id.Location = new System.Drawing.Point(12, 13);
            this.trip_id.Name = "trip_id";
            this.trip_id.Size = new System.Drawing.Size(43, 16);
            this.trip_id.TabIndex = 23;
            this.trip_id.Text = "trip_id";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(451, 10);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(174, 22);
            this.txt2.TabIndex = 26;
            this.txt2.Text = "20240307";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(105, 10);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(159, 22);
            this.txt1.TabIndex = 25;
            this.txt1.Text = "HFF124";
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1031, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 33);
            this.button1.TabIndex = 28;
            this.button1.Text = "Get Pax List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(675, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "include_cancel";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(822, 10);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(159, 22);
            this.txt3.TabIndex = 27;
            this.txt3.Text = "\r\n0";
            // 
            // pax_id
            // 
            this.pax_id.HeaderText = "pax_id";
            this.pax_id.MinimumWidth = 6;
            this.pax_id.Name = "pax_id";
            this.pax_id.ReadOnly = true;
            this.pax_id.Width = 125;
            // 
            // passport_number
            // 
            this.passport_number.HeaderText = "passport_number";
            this.passport_number.MinimumWidth = 6;
            this.passport_number.Name = "passport_number";
            this.passport_number.ReadOnly = true;
            this.passport_number.Width = 125;
            // 
            // ticket_number
            // 
            this.ticket_number.HeaderText = "ticket_number";
            this.ticket_number.MinimumWidth = 6;
            this.ticket_number.Name = "ticket_number";
            this.ticket_number.ReadOnly = true;
            this.ticket_number.Width = 125;
            // 
            // last_name
            // 
            this.last_name.HeaderText = "last_name";
            this.last_name.MinimumWidth = 6;
            this.last_name.Name = "last_name";
            this.last_name.ReadOnly = true;
            this.last_name.Width = 125;
            // 
            // first_name
            // 
            this.first_name.HeaderText = "first_name";
            this.first_name.MinimumWidth = 6;
            this.first_name.Name = "first_name";
            this.first_name.ReadOnly = true;
            this.first_name.Width = 125;
            // 
            // gender
            // 
            this.gender.HeaderText = "gender";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 125;
            // 
            // nationality
            // 
            this.nationality.HeaderText = "nationality";
            this.nationality.MinimumWidth = 6;
            this.nationality.Name = "nationality";
            this.nationality.ReadOnly = true;
            this.nationality.Width = 125;
            // 
            // dob
            // 
            this.dob.HeaderText = "dob";
            this.dob.MinimumWidth = 6;
            this.dob.Name = "dob";
            this.dob.ReadOnly = true;
            this.dob.Width = 125;
            // 
            // travel_document_exp_date
            // 
            this.travel_document_exp_date.HeaderText = "travel_document_exp_date";
            this.travel_document_exp_date.MinimumWidth = 6;
            this.travel_document_exp_date.Name = "travel_document_exp_date";
            this.travel_document_exp_date.ReadOnly = true;
            this.travel_document_exp_date.Width = 125;
            // 
            // country_issue
            // 
            this.country_issue.HeaderText = "country_issue";
            this.country_issue.MinimumWidth = 6;
            this.country_issue.Name = "country_issue";
            this.country_issue.ReadOnly = true;
            this.country_issue.Width = 125;
            // 
            // country_residence
            // 
            this.country_residence.HeaderText = "country_residence";
            this.country_residence.MinimumWidth = 6;
            this.country_residence.Name = "country_residence";
            this.country_residence.ReadOnly = true;
            this.country_residence.Width = 125;
            // 
            // destination
            // 
            this.destination.HeaderText = "destination";
            this.destination.MinimumWidth = 6;
            this.destination.Name = "destination";
            this.destination.ReadOnly = true;
            this.destination.Width = 125;
            // 
            // group_travel_flag
            // 
            this.group_travel_flag.HeaderText = "group_travel_flag";
            this.group_travel_flag.MinimumWidth = 6;
            this.group_travel_flag.Name = "group_travel_flag";
            this.group_travel_flag.ReadOnly = true;
            this.group_travel_flag.Width = 125;
            // 
            // date_created
            // 
            this.date_created.HeaderText = "date_created";
            this.date_created.MinimumWidth = 6;
            this.date_created.Name = "date_created";
            this.date_created.ReadOnly = true;
            this.date_created.Width = 125;
            // 
            // create_by
            // 
            this.create_by.HeaderText = "create_by";
            this.create_by.MinimumWidth = 6;
            this.create_by.Name = "create_by";
            this.create_by.ReadOnly = true;
            this.create_by.Width = 125;
            // 
            // date_updated
            // 
            this.date_updated.HeaderText = "date_updated";
            this.date_updated.MinimumWidth = 6;
            this.date_updated.Name = "date_updated";
            this.date_updated.ReadOnly = true;
            this.date_updated.Width = 125;
            // 
            // updated_by
            // 
            this.updated_by.HeaderText = "updated_by";
            this.updated_by.MinimumWidth = 6;
            this.updated_by.Name = "updated_by";
            this.updated_by.ReadOnly = true;
            this.updated_by.Width = 125;
            // 
            // checkin
            // 
            this.checkin.HeaderText = "checkin";
            this.checkin.MinimumWidth = 6;
            this.checkin.Name = "checkin";
            this.checkin.ReadOnly = true;
            this.checkin.Width = 125;
            // 
            // pre_imm
            // 
            this.pre_imm.HeaderText = "pre_imm";
            this.pre_imm.MinimumWidth = 6;
            this.pre_imm.Name = "pre_imm";
            this.pre_imm.ReadOnly = true;
            this.pre_imm.Width = 125;
            // 
            // immigration
            // 
            this.immigration.HeaderText = "immigration";
            this.immigration.MinimumWidth = 6;
            this.immigration.Name = "immigration";
            this.immigration.ReadOnly = true;
            this.immigration.Width = 125;
            // 
            // boarding
            // 
            this.boarding.HeaderText = "boarding";
            this.boarding.MinimumWidth = 6;
            this.boarding.Name = "boarding";
            this.boarding.ReadOnly = true;
            this.boarding.Width = 125;
            // 
            // pontoon
            // 
            this.pontoon.HeaderText = "pontoon";
            this.pontoon.MinimumWidth = 6;
            this.pontoon.Name = "pontoon";
            this.pontoon.ReadOnly = true;
            this.pontoon.Width = 125;
            // 
            // cancelled
            // 
            this.cancelled.HeaderText = "cancelled";
            this.cancelled.MinimumWidth = 6;
            this.cancelled.Name = "cancelled";
            this.cancelled.ReadOnly = true;
            this.cancelled.Width = 125;
            // 
            // remarks
            // 
            this.remarks.HeaderText = "remarks";
            this.remarks.MinimumWidth = 6;
            this.remarks.Name = "remarks";
            this.remarks.ReadOnly = true;
            this.remarks.Width = 125;
            // 
            // transfer_from
            // 
            this.transfer_from.HeaderText = "transfer_from";
            this.transfer_from.MinimumWidth = 6;
            this.transfer_from.Name = "transfer_from";
            this.transfer_from.ReadOnly = true;
            this.transfer_from.Width = 125;
            // 
            // baggage_tag_number
            // 
            this.baggage_tag_number.HeaderText = "baggage_tag_number";
            this.baggage_tag_number.MinimumWidth = 6;
            this.baggage_tag_number.Name = "baggage_tag_number";
            this.baggage_tag_number.ReadOnly = true;
            this.baggage_tag_number.Width = 125;
            // 
            // ntl_flag
            // 
            this.ntl_flag.HeaderText = "ntl_flag";
            this.ntl_flag.MinimumWidth = 6;
            this.ntl_flag.Name = "ntl_flag";
            this.ntl_flag.ReadOnly = true;
            this.ntl_flag.Width = 125;
            // 
            // last_min_pax
            // 
            this.last_min_pax.HeaderText = "last_min_pax";
            this.last_min_pax.MinimumWidth = 6;
            this.last_min_pax.Name = "last_min_pax";
            this.last_min_pax.ReadOnly = true;
            this.last_min_pax.Width = 125;
            // 
            // customer_booking_code
            // 
            this.customer_booking_code.HeaderText = "customer_booking_code";
            this.customer_booking_code.MinimumWidth = 6;
            this.customer_booking_code.Name = "customer_booking_code";
            this.customer_booking_code.ReadOnly = true;
            this.customer_booking_code.Width = 125;
            // 
            // Economy
            // 
            this.Economy.HeaderText = "class";
            this.Economy.MinimumWidth = 6;
            this.Economy.Name = "Economy";
            this.Economy.ReadOnly = true;
            this.Economy.Width = 125;
            // 
            // pax_type
            // 
            this.pax_type.HeaderText = "pax_type";
            this.pax_type.MinimumWidth = 6;
            this.pax_type.Name = "pax_type";
            this.pax_type.ReadOnly = true;
            this.pax_type.Width = 125;
            // 
            // security_program_flag
            // 
            this.security_program_flag.HeaderText = "security_program_flag";
            this.security_program_flag.MinimumWidth = 6;
            this.security_program_flag.Name = "security_program_flag";
            this.security_program_flag.ReadOnly = true;
            this.security_program_flag.Width = 125;
            // 
            // bag_allowance
            // 
            this.bag_allowance.HeaderText = "bag_allowance";
            this.bag_allowance.MinimumWidth = 6;
            this.bag_allowance.Name = "bag_allowance";
            this.bag_allowance.ReadOnly = true;
            this.bag_allowance.Width = 125;
            // 
            // additional_baggage_allowance
            // 
            this.additional_baggage_allowance.HeaderText = "additional_baggage_allowance";
            this.additional_baggage_allowance.MinimumWidth = 6;
            this.additional_baggage_allowance.Name = "additional_baggage_allowance";
            this.additional_baggage_allowance.ReadOnly = true;
            this.additional_baggage_allowance.Width = 125;
            // 
            // membership_no
            // 
            this.membership_no.HeaderText = "membership_no";
            this.membership_no.MinimumWidth = 6;
            this.membership_no.Name = "membership_no";
            this.membership_no.ReadOnly = true;
            this.membership_no.Width = 125;
            // 
            // source_check_in
            // 
            this.source_check_in.HeaderText = "source_check_in";
            this.source_check_in.MinimumWidth = 6;
            this.source_check_in.Name = "source_check_in";
            this.source_check_in.ReadOnly = true;
            this.source_check_in.Width = 125;
            // 
            // ssr
            // 
            this.ssr.HeaderText = "ssr";
            this.ssr.MinimumWidth = 6;
            this.ssr.Name = "ssr";
            this.ssr.ReadOnly = true;
            this.ssr.Width = 125;
            // 
            // passport_type
            // 
            this.passport_type.HeaderText = "passport_type";
            this.passport_type.MinimumWidth = 6;
            this.passport_type.Name = "passport_type";
            this.passport_type.ReadOnly = true;
            this.passport_type.Width = 125;
            // 
            // boarding_pass_number
            // 
            this.boarding_pass_number.HeaderText = "boarding_pass_number";
            this.boarding_pass_number.MinimumWidth = 6;
            this.boarding_pass_number.Name = "boarding_pass_number";
            this.boarding_pass_number.ReadOnly = true;
            this.boarding_pass_number.Width = 125;
            // 
            // GetPaxList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.voyage_date);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.trip_id);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.button1);
            this.Name = "GetPaxList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Pax List";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label voyage_date;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txterr_msg;
        private System.Windows.Forms.TextBox txterr_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label trip_id;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.DataGridViewTextBoxColumn pax_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticket_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn travel_document_exp_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn country_issue;
        private System.Windows.Forms.DataGridViewTextBoxColumn country_residence;
        private System.Windows.Forms.DataGridViewTextBoxColumn destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_travel_flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_created;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn pre_imm;
        private System.Windows.Forms.DataGridViewTextBoxColumn immigration;
        private System.Windows.Forms.DataGridViewTextBoxColumn boarding;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontoon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancelled;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn transfer_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn baggage_tag_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ntl_flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_min_pax;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_booking_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Economy;
        private System.Windows.Forms.DataGridViewTextBoxColumn pax_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn security_program_flag;
        private System.Windows.Forms.DataGridViewTextBoxColumn bag_allowance;
        private System.Windows.Forms.DataGridViewTextBoxColumn additional_baggage_allowance;
        private System.Windows.Forms.DataGridViewTextBoxColumn membership_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn source_check_in;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssr;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn boarding_pass_number;
    }
}