namespace ZenGameEngine
{
    partial class EngineStart
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.WelcomeString_1 = new System.Windows.Forms.Label();
            this.VerDetails = new System.Windows.Forms.Button();
            this.NewProj = new System.Windows.Forms.Button();
            this.LoadProj = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(13, 13);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(420, 37);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome to the Zen Game Engine";
            // 
            // WelcomeString_1
            // 
            this.WelcomeString_1.AutoSize = true;
            this.WelcomeString_1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeString_1.ForeColor = System.Drawing.Color.White;
            this.WelcomeString_1.Location = new System.Drawing.Point(16, 50);
            this.WelcomeString_1.Name = "WelcomeString_1";
            this.WelcomeString_1.Size = new System.Drawing.Size(233, 20);
            this.WelcomeString_1.TabIndex = 1;
            this.WelcomeString_1.Text = "What would you like to do today?";
            // 
            // VerDetails
            // 
            this.VerDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.VerDetails.Location = new System.Drawing.Point(499, 350);
            this.VerDetails.Name = "VerDetails";
            this.VerDetails.Size = new System.Drawing.Size(104, 23);
            this.VerDetails.TabIndex = 2;
            this.VerDetails.Text = "Version Details";
            this.VerDetails.UseVisualStyleBackColor = true;
            this.VerDetails.Click += new System.EventHandler(this.VerDetails_Click);
            // 
            // NewProj
            // 
            this.NewProj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewProj.ForeColor = System.Drawing.Color.Blue;
            this.NewProj.Location = new System.Drawing.Point(20, 285);
            this.NewProj.Name = "NewProj";
            this.NewProj.Size = new System.Drawing.Size(154, 41);
            this.NewProj.TabIndex = 3;
            this.NewProj.Text = "New Project";
            this.NewProj.UseVisualStyleBackColor = true;
            this.NewProj.Click += new System.EventHandler(this.NewProj_Click);
            // 
            // LoadProj
            // 
            this.LoadProj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadProj.ForeColor = System.Drawing.Color.Blue;
            this.LoadProj.Location = new System.Drawing.Point(20, 332);
            this.LoadProj.Name = "LoadProj";
            this.LoadProj.Size = new System.Drawing.Size(154, 41);
            this.LoadProj.TabIndex = 4;
            this.LoadProj.Text = "Load Project";
            this.LoadProj.UseVisualStyleBackColor = true;
            this.LoadProj.Click += new System.EventHandler(this.LoadProj_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EngineStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(615, 385);
            this.Controls.Add(this.LoadProj);
            this.Controls.Add(this.NewProj);
            this.Controls.Add(this.VerDetails);
            this.Controls.Add(this.WelcomeString_1);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "EngineStart";
            this.Text = "Zen Game Engine";
            this.Load += new System.EventHandler(this.EngineStart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label WelcomeString_1;
        private System.Windows.Forms.Button VerDetails;
        private System.Windows.Forms.Button NewProj;
        private System.Windows.Forms.Button LoadProj;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

