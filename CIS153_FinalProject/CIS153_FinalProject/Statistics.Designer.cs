namespace CIS153_FinalProject
{
    partial class Statistics
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_stats_playerWins = new System.Windows.Forms.Label();
            this.lbl_stats_numPWins = new System.Windows.Forms.Label();
            this.lbl_stats_cpuWins = new System.Windows.Forms.Label();
            this.lbl_stats_numCpuWins = new System.Windows.Forms.Label();
            this.lbl_stats_totalGames = new System.Windows.Forms.Label();
            this.lbl_stats_ties = new System.Windows.Forms.Label();
            this.lbl_stats_numGames = new System.Windows.Forms.Label();
            this.lbl_stats_numTies = new System.Windows.Forms.Label();
            this.lbl_stats_playerPercent = new System.Windows.Forms.Label();
            this.lbl_stats_playerPNum = new System.Windows.Forms.Label();
            this.lbl_stats_cpuPercent = new System.Windows.Forms.Label();
            this.lbl_stats_cpuPNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(289, 309);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(141, 76);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Back to menu";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_stats_playerWins
            // 
            this.lbl_stats_playerWins.AutoSize = true;
            this.lbl_stats_playerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_playerWins.Location = new System.Drawing.Point(12, 91);
            this.lbl_stats_playerWins.Name = "lbl_stats_playerWins";
            this.lbl_stats_playerWins.Size = new System.Drawing.Size(166, 31);
            this.lbl_stats_playerWins.TabIndex = 5;
            this.lbl_stats_playerWins.Text = "Player Wins:";
            // 
            // lbl_stats_numPWins
            // 
            this.lbl_stats_numPWins.AutoSize = true;
            this.lbl_stats_numPWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_numPWins.Location = new System.Drawing.Point(184, 91);
            this.lbl_stats_numPWins.Name = "lbl_stats_numPWins";
            this.lbl_stats_numPWins.Size = new System.Drawing.Size(86, 31);
            this.lbl_stats_numPWins.TabIndex = 6;
            this.lbl_stats_numPWins.Text = "label1";
            // 
            // lbl_stats_cpuWins
            // 
            this.lbl_stats_cpuWins.AutoSize = true;
            this.lbl_stats_cpuWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_cpuWins.Location = new System.Drawing.Point(12, 142);
            this.lbl_stats_cpuWins.Name = "lbl_stats_cpuWins";
            this.lbl_stats_cpuWins.Size = new System.Drawing.Size(208, 31);
            this.lbl_stats_cpuWins.TabIndex = 7;
            this.lbl_stats_cpuWins.Text = "Computer Wins:";
            // 
            // lbl_stats_numCpuWins
            // 
            this.lbl_stats_numCpuWins.AutoSize = true;
            this.lbl_stats_numCpuWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_numCpuWins.Location = new System.Drawing.Point(226, 142);
            this.lbl_stats_numCpuWins.Name = "lbl_stats_numCpuWins";
            this.lbl_stats_numCpuWins.Size = new System.Drawing.Size(86, 31);
            this.lbl_stats_numCpuWins.TabIndex = 8;
            this.lbl_stats_numCpuWins.Text = "label1";
            // 
            // lbl_stats_totalGames
            // 
            this.lbl_stats_totalGames.AutoSize = true;
            this.lbl_stats_totalGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_totalGames.Location = new System.Drawing.Point(12, 44);
            this.lbl_stats_totalGames.Name = "lbl_stats_totalGames";
            this.lbl_stats_totalGames.Size = new System.Drawing.Size(199, 31);
            this.lbl_stats_totalGames.TabIndex = 9;
            this.lbl_stats_totalGames.Text = "Games Played:";
            // 
            // lbl_stats_ties
            // 
            this.lbl_stats_ties.AutoSize = true;
            this.lbl_stats_ties.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_ties.Location = new System.Drawing.Point(12, 192);
            this.lbl_stats_ties.Name = "lbl_stats_ties";
            this.lbl_stats_ties.Size = new System.Drawing.Size(81, 31);
            this.lbl_stats_ties.TabIndex = 10;
            this.lbl_stats_ties.Text = "Ties: ";
            // 
            // lbl_stats_numGames
            // 
            this.lbl_stats_numGames.AutoSize = true;
            this.lbl_stats_numGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_numGames.Location = new System.Drawing.Point(217, 44);
            this.lbl_stats_numGames.Name = "lbl_stats_numGames";
            this.lbl_stats_numGames.Size = new System.Drawing.Size(86, 31);
            this.lbl_stats_numGames.TabIndex = 11;
            this.lbl_stats_numGames.Text = "label1";
            // 
            // lbl_stats_numTies
            // 
            this.lbl_stats_numTies.AutoSize = true;
            this.lbl_stats_numTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_numTies.Location = new System.Drawing.Point(99, 192);
            this.lbl_stats_numTies.Name = "lbl_stats_numTies";
            this.lbl_stats_numTies.Size = new System.Drawing.Size(86, 31);
            this.lbl_stats_numTies.TabIndex = 12;
            this.lbl_stats_numTies.Text = "label1";
            // 
            // lbl_stats_playerPercent
            // 
            this.lbl_stats_playerPercent.AutoSize = true;
            this.lbl_stats_playerPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_playerPercent.Location = new System.Drawing.Point(381, 91);
            this.lbl_stats_playerPercent.Name = "lbl_stats_playerPercent";
            this.lbl_stats_playerPercent.Size = new System.Drawing.Size(317, 31);
            this.lbl_stats_playerPercent.TabIndex = 13;
            this.lbl_stats_playerPercent.Text = "Player\'s Win Percentage:";
            // 
            // lbl_stats_playerPNum
            // 
            this.lbl_stats_playerPNum.AutoSize = true;
            this.lbl_stats_playerPNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_playerPNum.Location = new System.Drawing.Point(702, 91);
            this.lbl_stats_playerPNum.Name = "lbl_stats_playerPNum";
            this.lbl_stats_playerPNum.Size = new System.Drawing.Size(86, 31);
            this.lbl_stats_playerPNum.TabIndex = 14;
            this.lbl_stats_playerPNum.Text = "label1";
            // 
            // lbl_stats_cpuPercent
            // 
            this.lbl_stats_cpuPercent.AutoSize = true;
            this.lbl_stats_cpuPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_cpuPercent.Location = new System.Drawing.Point(358, 142);
            this.lbl_stats_cpuPercent.Name = "lbl_stats_cpuPercent";
            this.lbl_stats_cpuPercent.Size = new System.Drawing.Size(340, 31);
            this.lbl_stats_cpuPercent.TabIndex = 15;
            this.lbl_stats_cpuPercent.Text = "Computer Win Percentage:";
            // 
            // lbl_stats_cpuPNum
            // 
            this.lbl_stats_cpuPNum.AutoSize = true;
            this.lbl_stats_cpuPNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_cpuPNum.Location = new System.Drawing.Point(702, 142);
            this.lbl_stats_cpuPNum.Name = "lbl_stats_cpuPNum";
            this.lbl_stats_cpuPNum.Size = new System.Drawing.Size(86, 31);
            this.lbl_stats_cpuPNum.TabIndex = 16;
            this.lbl_stats_cpuPNum.Text = "label1";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_stats_cpuPNum);
            this.Controls.Add(this.lbl_stats_cpuPercent);
            this.Controls.Add(this.lbl_stats_playerPNum);
            this.Controls.Add(this.lbl_stats_playerPercent);
            this.Controls.Add(this.lbl_stats_numTies);
            this.Controls.Add(this.lbl_stats_numGames);
            this.Controls.Add(this.lbl_stats_ties);
            this.Controls.Add(this.lbl_stats_totalGames);
            this.Controls.Add(this.lbl_stats_numCpuWins);
            this.Controls.Add(this.lbl_stats_cpuWins);
            this.Controls.Add(this.lbl_stats_numPWins);
            this.Controls.Add(this.lbl_stats_playerWins);
            this.Controls.Add(this.btn_Exit);
            this.Name = "Statistics";
            this.Text = "StatisticsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_stats_playerWins;
        private System.Windows.Forms.Label lbl_stats_numPWins;
        private System.Windows.Forms.Label lbl_stats_cpuWins;
        private System.Windows.Forms.Label lbl_stats_numCpuWins;
        private System.Windows.Forms.Label lbl_stats_totalGames;
        private System.Windows.Forms.Label lbl_stats_ties;
        private System.Windows.Forms.Label lbl_stats_numGames;
        private System.Windows.Forms.Label lbl_stats_numTies;
        private System.Windows.Forms.Label lbl_stats_playerPercent;
        private System.Windows.Forms.Label lbl_stats_playerPNum;
        private System.Windows.Forms.Label lbl_stats_cpuPercent;
        private System.Windows.Forms.Label lbl_stats_cpuPNum;
    }
}