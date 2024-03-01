namespace WindowsFormsApp1
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
            this.SuspendLayout();
            // 
            // btnaddpax
            // 
            this.btnaddpax.Location = new System.Drawing.Point(12, 65);
            this.btnaddpax.Name = "btnaddpax";
            this.btnaddpax.Size = new System.Drawing.Size(143, 36);
            this.btnaddpax.TabIndex = 0;
            this.btnaddpax.Text = "Add Pax Record";
            this.btnaddpax.UseVisualStyleBackColor = true;
            this.btnaddpax.Click += new System.EventHandler(this.btnaddpax_Click);
            // 
            // btnupdatepax
            // 
            this.btnupdatepax.Location = new System.Drawing.Point(161, 65);
            this.btnupdatepax.Name = "btnupdatepax";
            this.btnupdatepax.Size = new System.Drawing.Size(143, 36);
            this.btnupdatepax.TabIndex = 1;
            this.btnupdatepax.Text = "Update Pax Record";
            this.btnupdatepax.UseVisualStyleBackColor = true;
            this.btnupdatepax.Click += new System.EventHandler(this.btnupdatepax_Click);
            // 
            // btncancelpax
            // 
            this.btncancelpax.Location = new System.Drawing.Point(310, 65);
            this.btncancelpax.Name = "btncancelpax";
            this.btncancelpax.Size = new System.Drawing.Size(143, 36);
            this.btncancelpax.TabIndex = 3;
            this.btncancelpax.Text = "Cancel Pax";
            this.btncancelpax.UseVisualStyleBackColor = true;
            // 
            // btngetvessel
            // 
            this.btngetvessel.Location = new System.Drawing.Point(459, 65);
            this.btngetvessel.Name = "btngetvessel";
            this.btngetvessel.Size = new System.Drawing.Size(143, 36);
            this.btngetvessel.TabIndex = 2;
            this.btngetvessel.Text = "Get Vessel Code";
            this.btngetvessel.UseVisualStyleBackColor = true;
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
            // MenuAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 140);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelpax);
            this.Controls.Add(this.btngetvessel);
            this.Controls.Add(this.btnupdatepax);
            this.Controls.Add(this.btnaddpax);
            this.Name = "MenuAPI";
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
    }
}