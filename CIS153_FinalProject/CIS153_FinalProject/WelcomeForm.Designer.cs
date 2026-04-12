namespace CIS153_FinalProject
{
    partial class WelcomeForm
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
            this.btn_Singleplayer = new System.Windows.Forms.Button();
            this.btn_Twoplayer = new System.Windows.Forms.Button();
            this.btn_Statistics = new System.Windows.Forms.Button();
            this.lbl_logo1 = new System.Windows.Forms.Label();
            this.lbl_logo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Singleplayer
            // 
            this.btn_Singleplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Singleplayer.Location = new System.Drawing.Point(47, 172);
            this.btn_Singleplayer.Name = "btn_Singleplayer";
            this.btn_Singleplayer.Size = new System.Drawing.Size(141, 76);
            this.btn_Singleplayer.TabIndex = 0;
            this.btn_Singleplayer.Text = "Singleplayer Form";
            this.btn_Singleplayer.UseVisualStyleBackColor = true;
            this.btn_Singleplayer.Click += new System.EventHandler(this.btn_Singleplayer_Click);
            // 
            // btn_Twoplayer
            // 
            this.btn_Twoplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Twoplayer.Location = new System.Drawing.Point(267, 172);
            this.btn_Twoplayer.Name = "btn_Twoplayer";
            this.btn_Twoplayer.Size = new System.Drawing.Size(141, 76);
            this.btn_Twoplayer.TabIndex = 1;
            this.btn_Twoplayer.Text = "Two Player Form";
            this.btn_Twoplayer.UseVisualStyleBackColor = true;
            this.btn_Twoplayer.Click += new System.EventHandler(this.btn_Twoplayer_Click);
            // 
            // btn_Statistics
            // 
            this.btn_Statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Statistics.Location = new System.Drawing.Point(470, 172);
            this.btn_Statistics.Name = "btn_Statistics";
            this.btn_Statistics.Size = new System.Drawing.Size(141, 76);
            this.btn_Statistics.TabIndex = 2;
            this.btn_Statistics.Text = "Statistics Form";
            this.btn_Statistics.UseVisualStyleBackColor = true;
            this.btn_Statistics.Click += new System.EventHandler(this.btn_Statistics_Click);
            // 
            // lbl_logo1
            // 
            this.lbl_logo1.AutoSize = true;
            this.lbl_logo1.Font = new System.Drawing.Font("Magneto", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo1.ForeColor = System.Drawing.Color.Red;
            this.lbl_logo1.Location = new System.Drawing.Point(12, 26);
            this.lbl_logo1.Name = "lbl_logo1";
            this.lbl_logo1.Size = new System.Drawing.Size(192, 48);
            this.lbl_logo1.TabIndex = 3;
            this.lbl_logo1.Text = "Connect";
            // 
            // lbl_logo2
            // 
            this.lbl_logo2.AutoSize = true;
            this.lbl_logo2.Font = new System.Drawing.Font("Magneto", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logo2.ForeColor = System.Drawing.Color.Gold;
            this.lbl_logo2.Location = new System.Drawing.Point(200, 26);
            this.lbl_logo2.Name = "lbl_logo2";
            this.lbl_logo2.Size = new System.Drawing.Size(125, 48);
            this.lbl_logo2.TabIndex = 4;
            this.lbl_logo2.Text = "Four";
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_logo2);
            this.Controls.Add(this.lbl_logo1);
            this.Controls.Add(this.btn_Statistics);
            this.Controls.Add(this.btn_Twoplayer);
            this.Controls.Add(this.btn_Singleplayer);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "WelcomeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Singleplayer;
        private System.Windows.Forms.Button btn_Twoplayer;
        private System.Windows.Forms.Button btn_Statistics;
        private System.Windows.Forms.Label lbl_logo1;
        private System.Windows.Forms.Label lbl_logo2;
    }
}

