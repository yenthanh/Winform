namespace SPOSAPIDemo
{
    partial class MenuAPI
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
            this.btnaddpax = new System.Windows.Forms.Button();
            this.btnupdatepax = new System.Windows.Forms.Button();
            this.btncancelpax = new System.Windows.Forms.Button();
            this.btngetvessel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnaddpax
            // 
            this.btnaddpax.Location = new System.Drawing.Point(12, 65);
            this.btnaddpax.Name = "btnaddpax";
            this.btnaddpax.Size = new System.Drawing.Size(171, 36);
            this.btnaddpax.TabIndex = 0;
            this.btnaddpax.Text = "Add Pax Record";
            this.btnaddpax.UseVisualStyleBackColor = true;
            this.btnaddpax.Click += new System.EventHandler(this.btnaddpax_Click);
            // 
            // btnupdatepax
            // 
            this.btnupdatepax.Location = new System.Drawing.Point(198, 65);
            this.btnupdatepax.Name = "btnupdatepax";
            this.btnupdatepax.Size = new System.Drawing.Size(171, 36);
            this.btnupdatepax.TabIndex = 1;
            this.btnupdatepax.Text = "Update Pax Record";
            this.btnupdatepax.UseVisualStyleBackColor = true;
            this.btnupdatepax.Click += new System.EventHandler(this.btnupdatepax_Click);
            // 
            // btncancelpax
            // 
            this.btncancelpax.Location = new System.Drawing.Point(384, 65);
            this.btncancelpax.Name = "btncancelpax";
            this.btncancelpax.Size = new System.Drawing.Size(171, 36);
            this.btncancelpax.TabIndex = 3;
            this.btncancelpax.Text = "Cancel Pax";
            this.btncancelpax.UseVisualStyleBackColor = true;
            this.btncancelpax.Click += new System.EventHandler(this.btncancelpax_Click);
            // 
            // btngetvessel
            // 
            this.btngetvessel.Location = new System.Drawing.Point(570, 65);
            this.btngetvessel.Name = "btngetvessel";
            this.btngetvessel.Size = new System.Drawing.Size(171, 36);
            this.btngetvessel.TabIndex = 2;
            this.btngetvessel.Text = "Get Vessel Code";
            this.btngetvessel.UseVisualStyleBackColor = true;
            this.btngetvessel.Click += new System.EventHandler(this.btngetvessel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose 1 API";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Get Terminal List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 36);
            this.button2.TabIndex = 6;
            this.button2.Text = "Get Trip Info";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(198, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "Get Trip List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(384, 107);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 36);
            this.button4.TabIndex = 8;
            this.button4.Text = "Get Pax Info";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(570, 107);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 36);
            this.button5.TabIndex = 9;
            this.button5.Text = "Get Pax List";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 149);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(171, 36);
            this.button6.TabIndex = 10;
            this.button6.Text = "Get Pax Detail";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(384, 149);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(171, 36);
            this.button7.TabIndex = 11;
            this.button7.Text = "Submit Check-in";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // MenuAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 197);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelpax);
            this.Controls.Add(this.btngetvessel);
            this.Controls.Add(this.btnupdatepax);
            this.Controls.Add(this.btnaddpax);
            this.Name = "MenuAPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaddpax;
        private System.Windows.Forms.Button btnupdatepax;
        private System.Windows.Forms.Button btncancelpax;
        private System.Windows.Forms.Button btngetvessel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}