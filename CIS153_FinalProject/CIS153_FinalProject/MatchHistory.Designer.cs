namespace CIS153_FinalProject
{
    partial class MatchHistory
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
            this.lst_singlePlayer = new System.Windows.Forms.ListBox();
            this.lst_twoPlayer = new System.Windows.Forms.ListBox();
            this.lbl_list1 = new System.Windows.Forms.Label();
            this.lbl_list2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst_singlePlayer
            // 
            this.lst_singlePlayer.FormattingEnabled = true;
            this.lst_singlePlayer.Location = new System.Drawing.Point(12, 122);
            this.lst_singlePlayer.Name = "lst_singlePlayer";
            this.lst_singlePlayer.ScrollAlwaysVisible = true;
            this.lst_singlePlayer.Size = new System.Drawing.Size(262, 316);
            this.lst_singlePlayer.TabIndex = 0;
            this.lst_singlePlayer.SelectedIndexChanged += new System.EventHandler(this.lst_singlePlayer_SelectedIndexChanged);
            // 
            // lst_twoPlayer
            // 
            this.lst_twoPlayer.FormattingEnabled = true;
            this.lst_twoPlayer.Location = new System.Drawing.Point(280, 122);
            this.lst_twoPlayer.Name = "lst_twoPlayer";
            this.lst_twoPlayer.ScrollAlwaysVisible = true;
            this.lst_twoPlayer.Size = new System.Drawing.Size(262, 316);
            this.lst_twoPlayer.TabIndex = 1;
            this.lst_twoPlayer.SelectedIndexChanged += new System.EventHandler(this.lst_twoPlayer_SelectedIndexChanged);
            // 
            // lbl_list1
            // 
            this.lbl_list1.AutoSize = true;
            this.lbl_list1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_list1.Location = new System.Drawing.Point(29, 69);
            this.lbl_list1.Name = "lbl_list1";
            this.lbl_list1.Size = new System.Drawing.Size(229, 26);
            this.lbl_list1.TabIndex = 2;
            this.lbl_list1.Text = "Single Player Matches";
            // 
            // lbl_list2
            // 
            this.lbl_list2.AutoSize = true;
            this.lbl_list2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_list2.Location = new System.Drawing.Point(307, 69);
            this.lbl_list2.Name = "lbl_list2";
            this.lbl_list2.Size = new System.Drawing.Size(208, 26);
            this.lbl_list2.TabIndex = 3;
            this.lbl_list2.Text = "Two Player Matches";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(63, 41);
            this.btn_back.TabIndex = 112;
            this.btn_back.Text = "<--";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(647, 362);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(141, 76);
            this.btn_Exit.TabIndex = 113;
            this.btn_Exit.Text = "Exit Program";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(647, 280);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(141, 76);
            this.btn_delete.TabIndex = 114;
            this.btn_delete.Text = "Delete Match";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_view
            // 
            this.btn_view.Enabled = false;
            this.btn_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.Location = new System.Drawing.Point(647, 198);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(141, 76);
            this.btn_view.TabIndex = 115;
            this.btn_view.Text = "View Match Review";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // MatchHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_list2);
            this.Controls.Add(this.lbl_list1);
            this.Controls.Add(this.lst_twoPlayer);
            this.Controls.Add(this.lst_singlePlayer);
            this.Name = "MatchHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MatchHistory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MatchHistory_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst_singlePlayer;
        private System.Windows.Forms.ListBox lst_twoPlayer;
        private System.Windows.Forms.Label lbl_list1;
        private System.Windows.Forms.Label lbl_list2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_view;
    }
}