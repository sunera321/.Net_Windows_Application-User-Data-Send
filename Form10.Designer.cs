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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.home = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.licenseKey = new System.Windows.Forms.TextBox();
            this.software = new System.Windows.Forms.ComboBox();
            this.SoftwareName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendData
            // 
            this.btnSendData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSendData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSendData.Location = new System.Drawing.Point(383, 403);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(222, 64);
            this.btnSendData.TabIndex = 0;
            this.btnSendData.Text = "Try To Logging ";
            this.btnSendData.UseVisualStyleBackColor = false;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // txtMacAddress
            // 
            this.txtMacAddress.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtMacAddress.Location = new System.Drawing.Point(236, 185);
            this.txtMacAddress.Multiline = true;
            this.txtMacAddress.Name = "txtMacAddress";
            this.txtMacAddress.Size = new System.Drawing.Size(504, 46);
            this.txtMacAddress.TabIndex = 1;
            // 
            // txtHostUrl
            // 
            this.txtHostUrl.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtHostUrl.Location = new System.Drawing.Point(236, 254);
            this.txtHostUrl.Multiline = true;
            this.txtHostUrl.Name = "txtHostUrl";
            this.txtHostUrl.Size = new System.Drawing.Size(504, 46);
            this.txtHostUrl.TabIndex = 2;
            this.txtHostUrl.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::separate_app.Properties.Resources.background1;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(69, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mac Address:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::separate_app.Properties.Resources.background1;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(70, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Host URl      :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // home
            // 
            this.home.AutoSize = true;
            this.home.BackColor = System.Drawing.SystemColors.GrayText;
            this.home.Location = new System.Drawing.Point(2, 2);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(62, 30);
            this.home.TabIndex = 15;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::separate_app.Properties.Resources.background1;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(66, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "License Key  :";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // licenseKey
            // 
            this.licenseKey.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.licenseKey.Location = new System.Drawing.Point(236, 340);
            this.licenseKey.Multiline = true;
            this.licenseKey.Name = "licenseKey";
            this.licenseKey.Size = new System.Drawing.Size(504, 46);
            this.licenseKey.TabIndex = 18;
            this.licenseKey.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // software
            // 
            this.software.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.software.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.software.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.software.FormattingEnabled = true;
            this.software.Items.AddRange(new object[] {
            "HOSPITALITY SERVICES",
            "HRO",
            "PeoplesHR Cloud",
            "PeoplesHR On-premise",
            "Tracking Solutions"});
            this.software.Location = new System.Drawing.Point(236, 92);
            this.software.Name = "software";
            this.software.Size = new System.Drawing.Size(504, 40);
            this.software.TabIndex = 19;
            this.software.Tag = "";
            this.software.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SoftwareName
            // 
            this.SoftwareName.AutoSize = true;
            this.SoftwareName.Font = new System.Drawing.Font("Microsoft Tai Le", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftwareName.Image = global::separate_app.Properties.Resources.background1;
            this.SoftwareName.Location = new System.Drawing.Point(324, 35);
            this.SoftwareName.Name = "SoftwareName";
            this.SoftwareName.Size = new System.Drawing.Size(347, 41);
            this.SoftwareName.TabIndex = 20;
            this.SoftwareName.Text = "Select Software Name";
            this.SoftwareName.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::separate_app.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(931, 500);
            this.Controls.Add(this.SoftwareName);
            this.Controls.Add(this.software);
            this.Controls.Add(this.licenseKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.home);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox licenseKey;
        private System.Windows.Forms.ComboBox software;
        private System.Windows.Forms.Label SoftwareName;
        private System.Windows.Forms.Label label1;
    }
}

