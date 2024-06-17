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
            this.SuspendLayout();
            // 
            // ValideteKey
            // 
            this.ValideteKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ValideteKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValideteKey.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ValideteKey.Location = new System.Drawing.Point(583, 351);
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
            this.ActivateKey.Location = new System.Drawing.Point(161, 351);
            this.ActivateKey.MinimumSize = new System.Drawing.Size(150, 50);
            this.ActivateKey.Name = "ActivateKey";
            this.ActivateKey.Size = new System.Drawing.Size(222, 64);
            this.ActivateKey.TabIndex = 1;
            this.ActivateKey.Text = "Activate Software";
            this.ActivateKey.UseVisualStyleBackColor = false;
            this.ActivateKey.Click += new System.EventHandler(this.ActivateKey_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::separate_app.Properties.Resources.MicrosoftTeams_image1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 500);
            this.Controls.Add(this.ActivateKey);
            this.Controls.Add(this.ValideteKey);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ValideteKey;
        private System.Windows.Forms.Button ActivateKey;
    }
}