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
            this.btn_ReturnToWelcome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_review = new System.Windows.Forms.Button();
            this.btn_playAgain = new System.Windows.Forms.Button();
            this.lbl_win = new System.Windows.Forms.Label();
            this.btn_matchHistory = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(647, 362);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(141, 76);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit Program";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_stats_playerWins
            // 
            this.lbl_stats_playerWins.AutoSize = true;
            this.lbl_stats_playerWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_playerWins.Location = new System.Drawing.Point(12, 149);
            this.lbl_stats_playerWins.Name = "lbl_stats_playerWins";
            this.lbl_stats_playerWins.Size = new System.Drawing.Size(166, 31);
            this.lbl_stats_playerWins.TabIndex = 5;
            this.lbl_stats_playerWins.Text = "Player Wins:";
            // 
            // lbl_stats_numPWins
            // 
            this.lbl_stats_numPWins.AutoSize = true;
            this.lbl_stats_numPWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_numPWins.Location = new System.Drawing.Point(226, 149);
            this.lbl_stats_numPWins.Name = "lbl_stats_numPWins";
            this.lbl_stats_numPWins.Size = new System.Drawing.Size(86, 31);
            this.lbl_stats_numPWins.TabIndex = 6;
            this.lbl_stats_numPWins.Text = "label1";
            // 
            // lbl_stats_cpuWins
            // 
            this.lbl_stats_cpuWins.AutoSize = true;
            this.lbl_stats_cpuWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_cpuWins.Location = new System.Drawing.Point(12, 200);
            this.lbl_stats_cpuWins.Name = "lbl_stats_cpuWins";
            this.lbl_stats_cpuWins.Size = new System.Drawing.Size(208, 31);
            this.lbl_stats_cpuWins.TabIndex = 7;
            this.lbl_stats_cpuWins.Text = "Computer Wins:";
            // 
            // lbl_stats_numCpuWins
            // 
            this.lbl_stats_numCpuWins.AutoSize = true;
            this.lbl_stats_numCpuWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_numCpuWins.Location = new System.Drawing.Point(226, 200);
            this.lbl_stats_numCpuWins.Name = "lbl_stats_numCpuWins";
            this.lbl_stats_numCpuWins.Size = new System.Drawing.Size(86, 31);
            this.lbl_stats_numCpuWins.TabIndex = 8;
            this.lbl_stats_numCpuWins.Text = "label1";
            // 
            // lbl_stats_totalGames
            // 
            this.lbl_stats_totalGames.AutoSize = true;
            this.lbl_stats_totalGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_totalGames.Location = new System.Drawing.Point(12, 102);
            this.lbl_stats_totalGames.Name = "lbl_stats_totalGames";
            this.lbl_stats_totalGames.Size = new System.Drawing.Size(199, 31);
            this.lbl_stats_totalGames.TabIndex = 9;
            this.lbl_stats_totalGames.Text = "Games Played:";
            // 
            // lbl_stats_ties
            // 
            this.lbl_stats_ties.AutoSize = true;
            this.lbl_stats_ties.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_ties.Location = new System.Drawing.Point(12, 250);
            this.lbl_stats_ties.Name = "lbl_stats_ties";
            this.lbl_stats_ties.Size = new System.Drawing.Size(81, 31);
            this.lbl_stats_ties.TabIndex = 10;
            this.lbl_stats_ties.Text = "Ties: ";
            // 
            // lbl_stats_numGames
            // 
            this.lbl_stats_numGames.AutoSize = true;
            this.lbl_stats_numGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_numGames.Location = new System.Drawing.Point(226, 102);
            this.lbl_stats_numGames.Name = "lbl_stats_numGames";
            this.lbl_stats_numGames.Size = new System.Drawing.Size(86, 31);
            this.lbl_stats_numGames.TabIndex = 11;
            this.lbl_stats_numGames.Text = "label1";
            // 
            // lbl_stats_numTies
            // 
            this.lbl_stats_numTies.AutoSize = true;
            this.lbl_stats_numTies.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_numTies.Location = new System.Drawing.Point(226, 250);
            this.lbl_stats_numTies.Name = "lbl_stats_numTies";
            this.lbl_stats_numTies.Size = new System.Drawing.Size(86, 31);
            this.lbl_stats_numTies.TabIndex = 12;
            this.lbl_stats_numTies.Text = "label1";
            // 
            // lbl_stats_playerPercent
            // 
            this.lbl_stats_playerPercent.AutoSize = true;
            this.lbl_stats_playerPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_playerPercent.Location = new System.Drawing.Point(347, 102);
            this.lbl_stats_playerPercent.Name = "lbl_stats_playerPercent";
            this.lbl_stats_playerPercent.Size = new System.Drawing.Size(317, 31);
            this.lbl_stats_playerPercent.TabIndex = 13;
            this.lbl_stats_playerPercent.Text = "Player\'s Win Percentage:";
            // 
            // lbl_stats_playerPNum
            // 
            this.lbl_stats_playerPNum.AutoSize = true;
            this.lbl_stats_playerPNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_playerPNum.Location = new System.Drawing.Point(691, 102);
            this.lbl_stats_playerPNum.Name = "lbl_stats_playerPNum";
            this.lbl_stats_playerPNum.Size = new System.Drawing.Size(86, 31);
            this.lbl_stats_playerPNum.TabIndex = 14;
            this.lbl_stats_playerPNum.Text = "label1";
            // 
            // lbl_stats_cpuPercent
            // 
            this.lbl_stats_cpuPercent.AutoSize = true;
            this.lbl_stats_cpuPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_cpuPercent.Location = new System.Drawing.Point(347, 149);
            this.lbl_stats_cpuPercent.Name = "lbl_stats_cpuPercent";
            this.lbl_stats_cpuPercent.Size = new System.Drawing.Size(340, 31);
            this.lbl_stats_cpuPercent.TabIndex = 15;
            this.lbl_stats_cpuPercent.Text = "Computer Win Percentage:";
            // 
            // lbl_stats_cpuPNum
            // 
            this.lbl_stats_cpuPNum.AutoSize = true;
            this.lbl_stats_cpuPNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats_cpuPNum.Location = new System.Drawing.Point(691, 149);
            this.lbl_stats_cpuPNum.Name = "lbl_stats_cpuPNum";
            this.lbl_stats_cpuPNum.Size = new System.Drawing.Size(86, 31);
            this.lbl_stats_cpuPNum.TabIndex = 16;
            this.lbl_stats_cpuPNum.Text = "label1";
            // 
            // btn_ReturnToWelcome
            // 
            this.btn_ReturnToWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReturnToWelcome.Location = new System.Drawing.Point(500, 362);
            this.btn_ReturnToWelcome.Name = "btn_ReturnToWelcome";
            this.btn_ReturnToWelcome.Size = new System.Drawing.Size(141, 76);
            this.btn_ReturnToWelcome.TabIndex = 17;
            this.btn_ReturnToWelcome.Text = "Back to menu";
            this.btn_ReturnToWelcome.UseVisualStyleBackColor = true;
            this.btn_ReturnToWelcome.Click += new System.EventHandler(this.btn_ReturnToWelcome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(683, 54);
            this.label1.TabIndex = 18;
            this.label1.Text = "Game Stats Against Computer";
            // 
            // btn_review
            // 
            this.btn_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_review.Location = new System.Drawing.Point(353, 362);
            this.btn_review.Name = "btn_review";
            this.btn_review.Size = new System.Drawing.Size(141, 76);
            this.btn_review.TabIndex = 19;
            this.btn_review.Text = "Review Game";
            this.btn_review.UseVisualStyleBackColor = true;
            this.btn_review.Visible = false;
            this.btn_review.Click += new System.EventHandler(this.btn_review_Click);
            // 
            // btn_playAgain
            // 
            this.btn_playAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playAgain.Location = new System.Drawing.Point(206, 362);
            this.btn_playAgain.Name = "btn_playAgain";
            this.btn_playAgain.Size = new System.Drawing.Size(141, 76);
            this.btn_playAgain.TabIndex = 20;
            this.btn_playAgain.Text = "Play Again?";
            this.btn_playAgain.UseVisualStyleBackColor = true;
            this.btn_playAgain.Visible = false;
            this.btn_playAgain.Click += new System.EventHandler(this.btn_playAgain_Click);
            // 
            // lbl_win
            // 
            this.lbl_win.AutoSize = true;
            this.lbl_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_win.Location = new System.Drawing.Point(490, 250);
            this.lbl_win.Name = "lbl_win";
            this.lbl_win.Size = new System.Drawing.Size(197, 37);
            this.lbl_win.TabIndex = 110;
            this.lbl_win.Text = "Win Display";
            this.lbl_win.Visible = false;
            // 
            // btn_matchHistory
            // 
            this.btn_matchHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_matchHistory.Location = new System.Drawing.Point(647, 280);
            this.btn_matchHistory.Name = "btn_matchHistory";
            this.btn_matchHistory.Size = new System.Drawing.Size(141, 76);
            this.btn_matchHistory.TabIndex = 111;
            this.btn_matchHistory.Text = "Match History";
            this.btn_matchHistory.UseVisualStyleBackColor = true;
            this.btn_matchHistory.Visible = false;
            this.btn_matchHistory.Click += new System.EventHandler(this.btn_matchHistory_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(12, 362);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(141, 76);
            this.btn_reset.TabIndex = 112;
            this.btn_reset.Text = "Reset Stats";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_matchHistory);
            this.Controls.Add(this.lbl_win);
            this.Controls.Add(this.btn_playAgain);
            this.Controls.Add(this.btn_review);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ReturnToWelcome);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticsForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Statistics_FormClosing);
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
        private System.Windows.Forms.Button btn_ReturnToWelcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_review;
        private System.Windows.Forms.Button btn_playAgain;
        private System.Windows.Forms.Label lbl_win;
        private System.Windows.Forms.Button btn_matchHistory;
        private System.Windows.Forms.Button btn_reset;
    }
}