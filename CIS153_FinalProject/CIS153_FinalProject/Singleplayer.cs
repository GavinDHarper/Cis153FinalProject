using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject
{
    public partial class Singleplayer : Form
    {
        Board gameBoard = new Board(6, 7, '.', new Player(1, "Player 1", new Chip("../../Resources/connect4chipIconRED.png", Color.Red)), new Player(2, "Robot", new Chip("../../Resources/connect4chipIconBLUE.png", Color.Blue)));
        Bot bot = new Bot();
        int playerTurn;
        bool gameOver = false;
        WelcomeForm WCForm;
        public Singleplayer()
        {
            InitializeComponent();
        }
        public Singleplayer(WelcomeForm WCF)
        {
            InitializeComponent();
            initializeDisplay();
            WCForm = WCF;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_placeChip(object sender, EventArgs e)
        {
            int col;
            Button btn = sender as Button;
            
            if (gameOver == false && playerTurn != gameBoard.getPlayer2().getId()) ////////bug fix this
            {
                if (btn != null)
                {
                    col = Int32.Parse(btn.Text) - 1;
                    if (gameBoard.board[5, col].isOpen()) //this is important becuase otherwize it will keep playing 
                                                          //checks if top space is open if it isnt then you cant place any peice
                    {
                        if (playerTurn == gameBoard.getPlayer1().getId())
                        {
                            gameBoard.placePiece(col, gameBoard.getPlayer1());
                        }
                        else
                        {
                            gameBoard.placePiece(col, gameBoard.getPlayer2());
                        }

                        if (gameBoard.checkWin(playerTurn)) //moved inside so i can make it check if collum is full
                        {
                            lbl_playerTurn.Visible = false;
                            gameOver = true;
                            if (playerTurn == gameBoard.getPlayer1().getId())
                            {
                                lbl_win.Text = gameBoard.getPlayer1().getName() + " Wins!";
                                lbl_win.ForeColor = gameBoard.getPlayer1().getChipColor();
                                lbl_win.Visible = true;
                                statUpdate(gameBoard.getPlayer1().getId());
                            }
                            else
                            {
                                lbl_win.Text = gameBoard.getPlayer2().getName() + " Wins!";
                                lbl_win.ForeColor = gameBoard.getPlayer2().getChipColor();
                                lbl_win.Visible = true;
                                statUpdate(gameBoard.getPlayer2().getId());
                            }
                            initializeDisplay();
                        }
                        else
                            nextTurn();
                    }
                    
                }
                
            }
            else
            {
                bot.play(gameBoard);
                nextTurn();
            }
        }
        public void nextTurn()
        {
            if (playerTurn == gameBoard.getPlayer1().getId())
            {
                playerTurn = gameBoard.getPlayer2().getId();
                pictureBox1.Image = gameBoard.getPlayer2().getChipImage();
                lbl_playerTurn.Text = gameBoard.getPlayer2().getName() + "'s Turn";
                lbl_playerTurn.ForeColor = gameBoard.getPlayer2().getChipColor();
                
                //nextTurn();
            }
            else
            {
                playerTurn = gameBoard.getPlayer1().getId();
                pictureBox1.Image = gameBoard.getPlayer1().getChipImage();
                lbl_playerTurn.Text = gameBoard.getPlayer1().getName() + "'s Turn";
                lbl_playerTurn.ForeColor = gameBoard.getPlayer1().getChipColor();
            }


            //This is giving me a headache lol
            //gameBoard.reverseBoard();
            initializeDisplay();
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            WCForm.Show();
            this.Close();
        }

        private void statUpdate(int i)
        {
            try
            {
                string fileName = "GameStats.txt";
                //finds the directory of the application
                string baseDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
                //combines the application directory with the name of the file
                //to get the relative path. allows this to work on any computer
                string filePath = Path.Combine(baseDirectoryPath, fileName);
                StreamReader file = new StreamReader(filePath);
                Debug.WriteLine(filePath);
                string line = file.ReadLine();

                int gamesPlayed = 0;
                int playerWins = 0;
                int computerWins = 0;
                int ties = 0;
                
                int comma;
                char delim = ',';

                //get games played
                comma = line.IndexOf(delim);
                gamesPlayed = Int32.Parse(line.Substring(0, comma));
                line = line.Substring(comma + 1);

                //get playerWins
                comma = line.IndexOf(delim);
                playerWins = Int32.Parse(line.Substring(0, comma));
                line = line.Substring(comma + 1);

                //get computerWins
                comma = line.IndexOf(delim);
                computerWins = Int32.Parse(line.Substring(0, comma));
                line = line.Substring(comma + 1);

                //get ties
                ties = Int32.Parse(line);
                file.Close();

                //calculations
                gamesPlayed++;

                if (i == 1)
                {
                    playerWins++;
                }
                else if (i == 2)
                {
                    computerWins++;
                }
                else
                {
                    ties++;
                }



                //write
                StreamWriter writer = new StreamWriter(filePath);
                writer.WriteLine($"{ gamesPlayed}, { playerWins}, { computerWins}, { ties}");
                writer.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("ERROR. File Not Found");
            }
        }
    }
}
