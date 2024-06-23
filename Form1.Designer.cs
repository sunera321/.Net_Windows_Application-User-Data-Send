namespace separate_app
{
    partial class Form1
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
            this.ValideteKey = new System.Windows.Forms.Button();
            this.ActivateKey = new System.Windows.Forms.Button();
            this.HeadLine = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // ValideteKey
            // 
            this.ValideteKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ValideteKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValideteKey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ValideteKey.Location = new System.Drawing.Point(793, 497);
            this.ValideteKey.MinimumSize = new System.Drawing.Size(150, 50);
            this.ValideteKey.Name = "ValideteKey";
            this.ValideteKey.Size = new System.Drawing.Size(222, 64);
            this.ValideteKey.TabIndex = 0;
            this.ValideteKey.Text = "Loging";
            this.ValideteKey.UseVisualStyleBackColor = false;
            this.ValideteKey.Click += new System.EventHandler(this.ValideteKey_Click);
            // 
            // ActivateKey
            // 
            this.ActivateKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ActivateKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateKey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ActivateKey.Location = new System.Drawing.Point(278, 497);
            this.ActivateKey.MinimumSize = new System.Drawing.Size(150, 50);
            this.ActivateKey.Name = "ActivateKey";
            this.ActivateKey.Size = new System.Drawing.Size(222, 64);
            this.ActivateKey.TabIndex = 1;
            this.ActivateKey.Text = "Activate Software";
            this.ActivateKey.UseVisualStyleBackColor = false;
            this.ActivateKey.Click += new System.EventHandler(this.ActivateKey_Click);
            // 
            // HeadLine
            // 
            this.HeadLine.AutoSize = false;
            this.HeadLine.BackColor = System.Drawing.Color.Transparent;
            this.HeadLine.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeadLine.ForeColor = System.Drawing.Color.Black;
            this.HeadLine.Location = new System.Drawing.Point(222, 22);
            this.HeadLine.Name = "HeadLine";
            this.HeadLine.Size = new System.Drawing.Size(927, 40);
            this.HeadLine.TabIndex = 2;
            this.HeadLine.Text = "This is Simulation Software Represanting Realwold Software hSenidBiz";
            this.HeadLine.Click += new System.EventHandler(this.HeadLine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::separate_app.Properties.Resources.MicrosoftTeams_image1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 689);
            this.Controls.Add(this.HeadLine);
            this.Controls.Add(this.ActivateKey);
            this.Controls.Add(this.ValideteKey);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "hSenidBiz";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ValideteKey;
        private System.Windows.Forms.Button ActivateKey;
        private Guna.UI2.WinForms.Guna2HtmlLabel HeadLine;
    }
}