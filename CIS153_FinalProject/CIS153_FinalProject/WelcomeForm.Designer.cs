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
            this.SuspendLayout();
            // 
            // btn_Singleplayer
            // 
            this.btn_Singleplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Singleplayer.Location = new System.Drawing.Point(140, 52);
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
            this.btn_Twoplayer.Location = new System.Drawing.Point(140, 158);
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
            this.btn_Statistics.Location = new System.Drawing.Point(140, 275);
            this.btn_Statistics.Name = "btn_Statistics";
            this.btn_Statistics.Size = new System.Drawing.Size(141, 76);
            this.btn_Statistics.TabIndex = 2;
            this.btn_Statistics.Text = "Statistics Form";
            this.btn_Statistics.UseVisualStyleBackColor = true;
            this.btn_Statistics.Click += new System.EventHandler(this.btn_Statistics_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Statistics);
            this.Controls.Add(this.btn_Twoplayer);
            this.Controls.Add(this.btn_Singleplayer);
            this.Name = "WelcomeForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Singleplayer;
        private System.Windows.Forms.Button btn_Twoplayer;
        private System.Windows.Forms.Button btn_Statistics;
    }
}

