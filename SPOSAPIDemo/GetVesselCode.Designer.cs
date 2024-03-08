namespace SPOSAPIDemo
{
    partial class GetVesselCode
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
            this.vessel_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reg_country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vessel_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vessel_owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurance_company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurance_policy_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vessel_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurance_expiry_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eids_short_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vessel_call_sign_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vessel_length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vessel_width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurance_reminder_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_updated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crew_cap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pax_cap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_cap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txterr_msg = new System.Windows.Forms.TextBox();
            this.txterr_num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClickGetVesselCode = new System.Windows.Forms.Button();
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
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 252);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Get Vessel Code";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vessel_id,
            this.reg_country,
            this.vessel_name,
            this.vessel_owner,
            this.insurance_company,
            this.insurance_policy_no,
            this.vessel_type,
            this.insurance_expiry_date,
            this.eids_short_name,
            this.vessel_call_sign_type,
            this.grt,
            this.vessel_length,
            this.vessel_width,
            this.insurance_reminder_date,
            this.date_created,
            this.create_by,
            this.date_updated,
            this.update_by,
            this.remark,
            this.crew_cap,
            this.pax_cap,
            this.total_cap,
            this.status});
            this.dataGridView2.Location = new System.Drawing.Point(6, 68);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(652, 175);
            this.dataGridView2.TabIndex = 4;
            // 
            // vessel_id
            // 
            this.vessel_id.HeaderText = "vessel_id";
            this.vessel_id.MinimumWidth = 6;
            this.vessel_id.Name = "vessel_id";
            this.vessel_id.ReadOnly = true;
            this.vessel_id.Width = 125;
            // 
            // reg_country
            // 
            this.reg_country.HeaderText = "reg_country";
            this.reg_country.MinimumWidth = 6;
            this.reg_country.Name = "reg_country";
            this.reg_country.ReadOnly = true;
            this.reg_country.Width = 125;
            // 
            // vessel_name
            // 
            this.vessel_name.HeaderText = "vessel_name";
            this.vessel_name.MinimumWidth = 6;
            this.vessel_name.Name = "vessel_name";
            this.vessel_name.ReadOnly = true;
            this.vessel_name.Width = 125;
            // 
            // vessel_owner
            // 
            this.vessel_owner.HeaderText = "vessel_owner";
            this.vessel_owner.MinimumWidth = 6;
            this.vessel_owner.Name = "vessel_owner";
            this.vessel_owner.ReadOnly = true;
            this.vessel_owner.Width = 125;
            // 
            // insurance_company
            // 
            this.insurance_company.HeaderText = "insurance_company";
            this.insurance_company.MinimumWidth = 6;
            this.insurance_company.Name = "insurance_company";
            this.insurance_company.ReadOnly = true;
            this.insurance_company.Width = 125;
            // 
            // insurance_policy_no
            // 
            this.insurance_policy_no.HeaderText = "insurance_policy_no";
            this.insurance_policy_no.MinimumWidth = 6;
            this.insurance_policy_no.Name = "insurance_policy_no";
            this.insurance_policy_no.ReadOnly = true;
            this.insurance_policy_no.Width = 125;
            // 
            // vessel_type
            // 
            this.vessel_type.HeaderText = "vessel_type";
            this.vessel_type.MinimumWidth = 6;
            this.vessel_type.Name = "vessel_type";
            this.vessel_type.ReadOnly = true;
            this.vessel_type.Width = 125;
            // 
            // insurance_expiry_date
            // 
            this.insurance_expiry_date.HeaderText = "insurance_expiry_date";
            this.insurance_expiry_date.MinimumWidth = 6;
            this.insurance_expiry_date.Name = "insurance_expiry_date";
            this.insurance_expiry_date.ReadOnly = true;
            this.insurance_expiry_date.Width = 125;
            // 
            // eids_short_name
            // 
            this.eids_short_name.HeaderText = "eids_short_name";
            this.eids_short_name.MinimumWidth = 6;
            this.eids_short_name.Name = "eids_short_name";
            this.eids_short_name.ReadOnly = true;
            this.eids_short_name.Width = 125;
            // 
            // vessel_call_sign_type
            // 
            this.vessel_call_sign_type.HeaderText = "vessel_call_sign_type";
            this.vessel_call_sign_type.MinimumWidth = 6;
            this.vessel_call_sign_type.Name = "vessel_call_sign_type";
            this.vessel_call_sign_type.ReadOnly = true;
            this.vessel_call_sign_type.Width = 125;
            // 
            // grt
            // 
            this.grt.HeaderText = "grt";
            this.grt.MinimumWidth = 6;
            this.grt.Name = "grt";
            this.grt.ReadOnly = true;
            this.grt.Width = 125;
            // 
            // vessel_length
            // 
            this.vessel_length.HeaderText = "vessel_length";
            this.vessel_length.MinimumWidth = 6;
            this.vessel_length.Name = "vessel_length";
            this.vessel_length.ReadOnly = true;
            this.vessel_length.Width = 125;
            // 
            // vessel_width
            // 
            this.vessel_width.HeaderText = "vessel_width";
            this.vessel_width.MinimumWidth = 6;
            this.vessel_width.Name = "vessel_width";
            this.vessel_width.ReadOnly = true;
            this.vessel_width.Width = 125;
            // 
            // insurance_reminder_date
            // 
            this.insurance_reminder_date.HeaderText = "insurance_reminder_date";
            this.insurance_reminder_date.MinimumWidth = 6;
            this.insurance_reminder_date.Name = "insurance_reminder_date";
            this.insurance_reminder_date.ReadOnly = true;
            this.insurance_reminder_date.Width = 125;
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
            // update_by
            // 
            this.update_by.HeaderText = "update_by";
            this.update_by.MinimumWidth = 6;
            this.update_by.Name = "update_by";
            this.update_by.ReadOnly = true;
            this.update_by.Width = 125;
            // 
            // remark
            // 
            this.remark.HeaderText = "remark";
            this.remark.MinimumWidth = 6;
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.Width = 125;
            // 
            // crew_cap
            // 
            this.crew_cap.HeaderText = "crew_cap";
            this.crew_cap.MinimumWidth = 6;
            this.crew_cap.Name = "crew_cap";
            this.crew_cap.ReadOnly = true;
            this.crew_cap.Width = 125;
            // 
            // pax_cap
            // 
            this.pax_cap.HeaderText = "pax_cap";
            this.pax_cap.MinimumWidth = 6;
            this.pax_cap.Name = "pax_cap";
            this.pax_cap.ReadOnly = true;
            this.pax_cap.Width = 125;
            // 
            // total_cap
            // 
            this.total_cap.HeaderText = "total_cap";
            this.total_cap.MinimumWidth = 6;
            this.total_cap.Name = "total_cap";
            this.total_cap.ReadOnly = true;
            this.total_cap.Width = 125;
            // 
            // status
            // 
            this.status.HeaderText = "status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 125;
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
            // btnClickGetVesselCode
            // 
            this.btnClickGetVesselCode.Location = new System.Drawing.Point(518, 270);
            this.btnClickGetVesselCode.Name = "btnClickGetVesselCode";
            this.btnClickGetVesselCode.Size = new System.Drawing.Size(132, 29);
            this.btnClickGetVesselCode.TabIndex = 8;
            this.btnClickGetVesselCode.Text = "Get Vessel Code";
            this.btnClickGetVesselCode.UseVisualStyleBackColor = true;
            this.btnClickGetVesselCode.Click += new System.EventHandler(this.btnClickGetVesselCode_Click);
            // 
            // GetVesselCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 313);
            this.Controls.Add(this.btnClickGetVesselCode);
            this.Controls.Add(this.groupBox3);
            this.Name = "GetVesselCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get Vessel Code";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txterr_msg;
        private System.Windows.Forms.TextBox txterr_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn vessel_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn reg_country;
        private System.Windows.Forms.DataGridViewTextBoxColumn vessel_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn vessel_owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurance_company;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurance_policy_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn vessel_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurance_expiry_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn eids_short_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn vessel_call_sign_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn grt;
        private System.Windows.Forms.DataGridViewTextBoxColumn vessel_length;
        private System.Windows.Forms.DataGridViewTextBoxColumn vessel_width;
        private System.Windows.Forms.DataGridViewTextBoxColumn insurance_reminder_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_created;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_updated;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn crew_cap;
        private System.Windows.Forms.DataGridViewTextBoxColumn pax_cap;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_cap;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.Button btnClickGetVesselCode;
    }
}