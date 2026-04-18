using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CIS153_FinalProject
{
    public partial class Twoplayer : Form
    {
        Board gameBoard = new Board(7, 6, '.');


        WelcomeForm WCForm;
        public Twoplayer()
        {
            InitializeComponent();
            initualizeDisplay();
        }
        public Twoplayer(WelcomeForm WCF)
        {
            InitializeComponent();
            WCForm = WCF;
            initualizeDisplay();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            WCForm.Show();
            this.Close();
        }

        private void btn_tp1_Click(object sender, EventArgs e)
        {
            //I've got things set up to use a button to place a chip 
            //in each column. I'm going to leave just one coded for now 
            //in case any of you don't like this layout and want to change it
            //since I know having a bunch of blank actions is a pain
            gameBoard.placePiece(1, 'r');
            gameBoard.board[0, 0].pictureBox.Image = pictureBox1.Image; 
        }
        private void btn_tp2_Click(object sender, EventArgs e)
        {
            gameBoard.board[1,0].pictureBox.Image= pictureBox1.Image;
        }

        private void initualizeDisplay()
        {
            gameBoard.board[0, 0].pictureBox = SP_00;
            gameBoard.board[0, 1].pictureBox = SP_01;
            gameBoard.board[0, 2].pictureBox = SP_02;
            gameBoard.board[0, 3].pictureBox = SP_03;
            gameBoard.board[0, 4].pictureBox = SP_04;
            gameBoard.board[0, 5].pictureBox = SP_05;
            gameBoard.board[1, 0].pictureBox = SP_10;
            gameBoard.board[1, 1].pictureBox = SP_11;
            gameBoard.board[1, 2].pictureBox = SP_12;
            gameBoard.board[1, 3].pictureBox = SP_13;
            gameBoard.board[1, 4].pictureBox = SP_14;
            gameBoard.board[1, 5].pictureBox = SP_15;
            gameBoard.board[2, 0].pictureBox = SP_20;
            gameBoard.board[2, 1].pictureBox = SP_21;
            gameBoard.board[2, 2].pictureBox = SP_22;
            gameBoard.board[2, 3].pictureBox = SP_23;
            gameBoard.board[2, 4].pictureBox = SP_24;
            gameBoard.board[2, 5].pictureBox = SP_25;
            gameBoard.board[3, 0].pictureBox = SP_30;
            gameBoard.board[3, 1].pictureBox = SP_31;
            gameBoard.board[3, 2].pictureBox = SP_32;
            gameBoard.board[3, 3].pictureBox = SP_33;
            gameBoard.board[3, 4].pictureBox = SP_34;
            gameBoard.board[3, 5].pictureBox = SP_35;
            gameBoard.board[4, 0].pictureBox = SP_40;
            gameBoard.board[4, 1].pictureBox = SP_41;
            gameBoard.board[4, 2].pictureBox = SP_42;
            gameBoard.board[4, 3].pictureBox = SP_43;
            gameBoard.board[4, 4].pictureBox = SP_44;
            gameBoard.board[4, 5].pictureBox = SP_45;
            gameBoard.board[5, 0].pictureBox = SP_50;
            gameBoard.board[5, 1].pictureBox = SP_51;
            gameBoard.board[5, 2].pictureBox = SP_52;
            gameBoard.board[5, 3].pictureBox = SP_53;
            gameBoard.board[5, 4].pictureBox = SP_54;
            gameBoard.board[5, 5].pictureBox = SP_55;
            gameBoard.board[6, 0].pictureBox = SP_60;
            gameBoard.board[6, 1].pictureBox = SP_61;
            gameBoard.board[6, 2].pictureBox = SP_62;
            gameBoard.board[6, 3].pictureBox = SP_63;
            gameBoard.board[6, 4].pictureBox = SP_64;
            gameBoard.board[6, 5].pictureBox = SP_65;
        }

        
    }
}
