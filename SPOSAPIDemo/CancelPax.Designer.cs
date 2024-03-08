namespace SPOSAPIDemo
{
    partial class CancelPax
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpax_id = new System.Windows.Forms.TextBox();
            this.txtboarding_pass_number = new System.Windows.Forms.TextBox();
            this.labelpax = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvoyage_date = new System.Windows.Forms.TextBox();
            this.txttrip_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClickCacnelPax = new System.Windows.Forms.Button();
            this.txterr_msg = new System.Windows.Forms.TextBox();
            this.txterr_num = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpax_id);
            this.groupBox1.Controls.Add(this.txtboarding_pass_number);
            this.groupBox1.Controls.Add(this.labelpax);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtvoyage_date);
            this.groupBox1.Controls.Add(this.txttrip_id);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(706, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voyage Details";
            // 
            // txtpax_id
            // 
            this.txtpax_id.Location = new System.Drawing.Point(496, 82);
            this.txtpax_id.Name = "txtpax_id";
            this.txtpax_id.Size = new System.Drawing.Size(190, 22);
            this.txtpax_id.TabIndex = 7;
            // 
            // txtboarding_pass_number
            // 
            this.txtboarding_pass_number.Location = new System.Drawing.Point(496, 43);
            this.txtboarding_pass_number.Name = "txtboarding_pass_number";
            this.txtboarding_pass_number.Size = new System.Drawing.Size(190, 22);
            this.txtboarding_pass_number.TabIndex = 6;
            // 
            // labelpax
            // 
            this.labelpax.AutoSize = true;
            this.labelpax.Location = new System.Drawing.Point(340, 88);
            this.labelpax.Name = "labelpax";
            this.labelpax.Size = new System.Drawing.Size(47, 16);
            this.labelpax.TabIndex = 5;
            this.labelpax.Text = "pax_id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "boarding_pass_number";
            // 
            // txtvoyage_date
            // 
            this.txtvoyage_date.Location = new System.Drawing.Point(139, 82);
            this.txtvoyage_date.Name = "txtvoyage_date";
            this.txtvoyage_date.Size = new System.Drawing.Size(190, 22);
            this.txtvoyage_date.TabIndex = 3;
            // 
            // txttrip_id
            // 
            this.txttrip_id.Location = new System.Drawing.Point(139, 43);
            this.txttrip_id.Name = "txttrip_id";
            this.txttrip_id.Size = new System.Drawing.Size(190, 22);
            this.txttrip_id.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "voyage_date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "trip_id";
            // 
            // btnClickCacnelPax
            // 
            this.btnClickCacnelPax.Location = new System.Drawing.Point(293, 131);
            this.btnClickCacnelPax.Name = "btnClickCacnelPax";
            this.btnClickCacnelPax.Size = new System.Drawing.Size(141, 29);
            this.btnClickCacnelPax.TabIndex = 7;
            this.btnClickCacnelPax.Text = "Cancel Pax";
            this.btnClickCacnelPax.UseVisualStyleBackColor = true;
            this.btnClickCacnelPax.Click += new System.EventHandler(this.button1_Click);
            // 
            // txterr_msg
            // 
            this.txterr_msg.Location = new System.Drawing.Point(412, 30);
            this.txterr_msg.Name = "txterr_msg";
            this.txterr_msg.ReadOnly = true;
            this.txterr_msg.Size = new System.Drawing.Size(174, 22);
            this.txterr_msg.TabIndex = 3;
            // 
            // txterr_num
            // 
            this.txterr_num.Location = new System.Drawing.Point(169, 27);
            this.txterr_num.Name = "txterr_num";
            this.txterr_num.ReadOnly = true;
            this.txterr_num.Size = new System.Drawing.Size(174, 22);
            this.txterr_num.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "err_num";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txterr_msg);
            this.groupBox3.Controls.Add(this.txterr_num);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(0, 166);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(706, 71);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "API Response";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "err_msg";
            // 
            // CancelPax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 252);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnClickCacnelPax);
            this.Controls.Add(this.groupBox1);
            this.Name = "CancelPax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancel Pax";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpax_id;
        private System.Windows.Forms.TextBox txtboarding_pass_number;
        private System.Windows.Forms.Label labelpax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtvoyage_date;
        private System.Windows.Forms.TextBox txttrip_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClickCacnelPax;
        private System.Windows.Forms.TextBox txterr_msg;
        private System.Windows.Forms.TextBox txterr_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
    }
}