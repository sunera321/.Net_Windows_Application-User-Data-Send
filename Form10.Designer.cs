namespace WindowsFormsApp
{
    partial class Form10
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
            this.btnSendData = new System.Windows.Forms.Button();
            this.txtMacAddress = new System.Windows.Forms.TextBox();
            this.txtHostUrl = new System.Windows.Forms.TextBox();
            this.txtSiteNames = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSendData
            // 
            this.btnSendData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSendData.Location = new System.Drawing.Point(312, 39);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(184, 59);
            this.btnSendData.TabIndex = 0;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = false;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // txtMacAddress
            // 
            this.txtMacAddress.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMacAddress.Location = new System.Drawing.Point(149, 137);
            this.txtMacAddress.Multiline = true;
            this.txtMacAddress.Name = "txtMacAddress";
            this.txtMacAddress.ReadOnly = true;
            this.txtMacAddress.Size = new System.Drawing.Size(504, 46);
            this.txtMacAddress.TabIndex = 1;
            // 
            // txtHostUrl
            // 
            this.txtHostUrl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtHostUrl.Location = new System.Drawing.Point(149, 206);
            this.txtHostUrl.Multiline = true;
            this.txtHostUrl.Name = "txtHostUrl";
            this.txtHostUrl.ReadOnly = true;
            this.txtHostUrl.Size = new System.Drawing.Size(504, 46);
            this.txtHostUrl.TabIndex = 2;
            this.txtHostUrl.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSiteNames
            // 
            this.txtSiteNames.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSiteNames.Location = new System.Drawing.Point(149, 275);
            this.txtSiteNames.Multiline = true;
            this.txtSiteNames.Name = "txtSiteNames";
            this.txtSiteNames.ReadOnly = true;
            this.txtSiteNames.Size = new System.Drawing.Size(504, 152);
            this.txtSiteNames.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mac Address:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Site Names  :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Host URl      :";
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.BackColor = System.Drawing.SystemColors.GrayText;
            this.home.Location = new System.Drawing.Point(12, 12);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(62, 30);
            this.home.TabIndex = 15;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 467);
            this.Controls.Add(this.home);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSiteNames);
            this.Controls.Add(this.txtHostUrl);
            this.Controls.Add(this.txtMacAddress);
            this.Controls.Add(this.btnSendData);
            this.Name = "Form10";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.TextBox txtMacAddress;
        private System.Windows.Forms.TextBox txtHostUrl;
        private System.Windows.Forms.TextBox txtSiteNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button home;
    }
}

