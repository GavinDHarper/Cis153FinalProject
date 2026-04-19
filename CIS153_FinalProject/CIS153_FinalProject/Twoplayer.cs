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
        Board gameBoard = new Board(6, 7, '.');
        Player player1 = new Player();
        Player player2 = new Player();
        Chip redChip = new Chip("../../Resources/connect4chipIconRED.png", Color.Red);
        Chip blueChip = new Chip("../../Resources/connect4chipIconBLUE.png", Color.Blue);
        int playerTurn;

        WelcomeForm WCForm;
        public Twoplayer()
        {
            InitializeComponent();
            initializeDisplay();
        }
        public Twoplayer(WelcomeForm WCF)
        {
            InitializeComponent();
            WCForm = WCF;
            initializeDisplay();
            player1.setId(1);
            player1.setName("Player 1");
            player1.setChip(redChip);
            player2.setId(2);
            player1.setName("Player 2");
            player2.setChip(blueChip);
            playerTurn = player1.getId();
            lbl_playerTurn.Text = player1.getName() + "'s Turn";
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            WCForm.Show();
            this.Close();
        }
        private void btn_placeChip(object sender, EventArgs e)
        {
            int col;
            Button btn = sender as Button;
            if (btn != null)
            {
                col = Int32.Parse(btn.Text) - 1;
                if (playerTurn == player1.getId())
                {
                    gameBoard.placePiece(col, player1);
                }
                else 
                {
                    gameBoard.placePiece(col, player2);
                }
            }
            nextTurn();
        }

        private void initializeDisplay()
        {
            SP_00.Image = gameBoard.board[0, 0].getChipImage();
            SP_10.Image = gameBoard.board[1, 0].getChipImage();
            SP_20.Image = gameBoard.board[2, 0].getChipImage();
            SP_30.Image = gameBoard.board[3, 0].getChipImage();
            SP_40.Image = gameBoard.board[4, 0].getChipImage();
            SP_50.Image = gameBoard.board[5, 0].getChipImage();
            SP_01.Image = gameBoard.board[0, 1].getChipImage();
            SP_11.Image = gameBoard.board[1, 1].getChipImage();
            SP_21.Image = gameBoard.board[2, 1].getChipImage();
            SP_31.Image = gameBoard.board[3, 1].getChipImage();
            SP_41.Image = gameBoard.board[4, 1].getChipImage();
            SP_51.Image = gameBoard.board[5, 1].getChipImage();
            SP_02.Image = gameBoard.board[0, 2].getChipImage();
            SP_12.Image = gameBoard.board[1, 2].getChipImage();
            SP_22.Image = gameBoard.board[2, 2].getChipImage();
            SP_32.Image = gameBoard.board[3, 2].getChipImage();
            SP_42.Image = gameBoard.board[4, 2].getChipImage();
            SP_52.Image = gameBoard.board[5, 2].getChipImage();
            SP_03.Image = gameBoard.board[0, 3].getChipImage();
            SP_13.Image = gameBoard.board[1, 3].getChipImage();
            SP_23.Image = gameBoard.board[2, 3].getChipImage();
            SP_33.Image = gameBoard.board[3, 3].getChipImage();
            SP_43.Image = gameBoard.board[4, 3].getChipImage();
            SP_53.Image = gameBoard.board[5, 3].getChipImage();
            SP_04.Image = gameBoard.board[0, 4].getChipImage();
            SP_14.Image = gameBoard.board[1, 4].getChipImage();
            SP_24.Image = gameBoard.board[2, 4].getChipImage();
            SP_34.Image = gameBoard.board[3, 4].getChipImage();
            SP_44.Image = gameBoard.board[4, 4].getChipImage();
            SP_54.Image = gameBoard.board[5, 4].getChipImage();
            SP_05.Image = gameBoard.board[0, 5].getChipImage();
            SP_15.Image = gameBoard.board[1, 5].getChipImage();
            SP_25.Image = gameBoard.board[2, 5].getChipImage();
            SP_35.Image = gameBoard.board[3, 5].getChipImage();
            SP_45.Image = gameBoard.board[4, 5].getChipImage();
            SP_55.Image = gameBoard.board[5, 5].getChipImage();
            SP_06.Image = gameBoard.board[0, 6].getChipImage();
            SP_16.Image = gameBoard.board[1, 6].getChipImage();
            SP_26.Image = gameBoard.board[2, 6].getChipImage();
            SP_36.Image = gameBoard.board[3, 6].getChipImage();
            SP_46.Image = gameBoard.board[4, 6].getChipImage();
            SP_56.Image = gameBoard.board[5, 6].getChipImage();
            gameBoard.displayBoardConsole();
        }


        public void nextTurn()
        {
            if (playerTurn == player1.getId())
            {
                playerTurn = player2.getId();
                pictureBox1.Image = player2.getChipImage();
                lbl_playerTurn.Text = player2.getName() + "'s Turn";
            }
            else
            {
                playerTurn = player1.getId();
                pictureBox1.Image = player1.getChipImage();
                lbl_playerTurn.Text = player1.getName() + "'s Turn";
            }
            gameBoard.reverseBoard();
            initializeDisplay();
        }
    }
}
