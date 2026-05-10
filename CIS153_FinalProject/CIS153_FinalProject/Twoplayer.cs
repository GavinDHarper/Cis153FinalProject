using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject
{
    public partial class Twoplayer : Form
    {
        SoundPlayer place = new SoundPlayer("place1.wav");
        SoundPlayer click1 = new SoundPlayer("click1.wav");

        Board gameBoard = new Board(6, 7, '.', new Player(1, "Player 1", new Chip("../../Resources/connect4chipIconRED.png", Color.Red)), new Player(2, "Player 2", new Chip("../../Resources/connect4chipIconBLUE.png", Color.Blue)));
        int playerTurn;
        bool gameOver = false;
        List<Play> listOfPlays = new List<Play>();
        List<Game> listOfGames = new List<Game>();

        WelcomeForm WCForm;
        Statistics statForm;
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
            playerTurn = gameBoard.getPlayer1().getId();
            lbl_playerTurn.Text = gameBoard.getPlayer1().getName() + "'s Turn";
            lbl_playerTurn.ForeColor = gameBoard.getPlayer1().getChipColor();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
        private void SP_placeChip(object sender, MouseEventArgs e)
        {
            int col;
            PictureBox pic = sender as PictureBox;
            if (gameOver == false)
            {
                col = Int32.Parse(pic.Tag.ToString());
                bool placed;
                if (playerTurn == gameBoard.getPlayer1().getId())
                {
                    placed = gameBoard.placePiece(col, gameBoard.getPlayer1());
                }
                else
                {
                    placed = gameBoard.placePiece(col, gameBoard.getPlayer2());
                }
                if (!placed)
                {
                    return;
                }
                Play newPlay = new Play(gameBoard.latestPlayRow(col), col, playerTurn);
                listOfPlays.Add(newPlay);
                //place.Play();
                if (gameBoard.checkWin(playerTurn))
                {
                    lbl_playerTurn.Visible = false;
                    gameOver = true;
                    btn_back.Enabled = false;
                    if (playerTurn == gameBoard.getPlayer1().getId())
                    {
                        lbl_win.Text = gameBoard.getPlayer1().getName() + " Wins!";
                        lbl_win.ForeColor = gameBoard.getPlayer1().getChipColor();
                        lbl_win.Visible = true;
                        showStats();
                    }
                    else
                    {
                        lbl_win.Text = gameBoard.getPlayer2().getName() + " Wins!";
                        lbl_win.ForeColor = gameBoard.getPlayer2().getChipColor();
                        lbl_win.Visible = true;
                        showStats();
                    }
                    initializeDisplay();
                    Game newGame = new Game(new List<Play>(listOfPlays), gameBoard.getPlayer1().getName(), gameBoard.getPlayer2().getName(), playerTurn);
                    listOfGames = new List<Game>(readGames());
                    listOfGames.Add(newGame);
                    listOfPlays.Clear();
                    writeGames();
                }
                else if (gameBoard.IsGameboardFull())
                {
                    lbl_playerTurn.Visible = false;
                    gameOver = true;
                    lbl_win.Text = "It's a Tie!";
                    lbl_win.ForeColor = Color.DarkSlateGray;
                    lbl_win.Visible = true;
                    showStats();
                    initializeDisplay();
                    Game newGame = new Game(new List<Play>(listOfPlays), gameBoard.getPlayer1().getName(), gameBoard.getPlayer2().getName(), -1);
                    listOfGames = new List<Game>(readGames());
                    listOfGames.Add(newGame);
                    listOfPlays.Clear();
                    writeGames();
                }
                else nextTurn();
                for (int row = 0; row < gameBoard.getRows(); row++)
                {
                    if (gameBoard.board[row, col].isOpen())
                    {
                        string picBoxPath = "SP_" + row.ToString() + col.ToString();
                        //Console.WriteLine(picBoxPath);
                        PictureBox picBox = (PictureBox)this.Controls[picBoxPath];
                        {
                            if (playerTurn == gameBoard.getPlayer1().getId())
                            {
                                picBox.Image = Image.FromFile("../../Resources/connect4chipGhostRED.png");
                                return;
                            }
                            else
                            {
                                picBox.Image = Image.FromFile("../../Resources/connect4chipGhostBLUE.png");
                                return;
                            }
                        }
                    }
                }
            }
        }
        private void SP_displayGhostChip(object sender, EventArgs e)
        {
            if (!gameOver)
            {
                int col;
                PictureBox pic = sender as PictureBox;
                col = Int32.Parse(pic.Tag.ToString());
                for (int row = 0; row < gameBoard.getRows(); row++)
                {
                    if (gameBoard.board[row, col].isOpen())
                    {
                        string picBoxPath = "SP_" + row.ToString() + col.ToString();
                        //Console.WriteLine(picBoxPath);
                        PictureBox picBox = (PictureBox)this.Controls[picBoxPath];
                        {
                            if (playerTurn == gameBoard.getPlayer1().getId())
                            {
                                picBox.Image = Image.FromFile("../../Resources/connect4chipGhostRED.png");
                                return;
                            }
                            else
                            {
                                picBox.Image = Image.FromFile("../../Resources/connect4chipGhostBLUE.png");
                                return;
                            }
                        }
                    }
                }
            }
        }
        private void SP_removeGhostChip(object sender, EventArgs e)
        {
            int col;
            PictureBox pic = sender as PictureBox;
            col = Int32.Parse(pic.Tag.ToString());
            for (int row = 0; row < gameBoard.getRows(); row++)
            {
                string picBoxPath = "SP_" + row.ToString() + col.ToString();
                PictureBox picBox = (PictureBox)this.Controls[picBoxPath];
                if (gameBoard.board[row, col].isOpen())
                {
                    picBox.Image = Image.FromFile("../../Resources/emptyCell.png");
                }
            }
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
            if (playerTurn == gameBoard.getPlayer1().getId())
            {
                playerTurn = gameBoard.getPlayer2().getId();
                pictureBox1.Image = gameBoard.getPlayer2().getChipImage();
                lbl_playerTurn.Text = gameBoard.getPlayer2().getName() + "'s Turn";
                lbl_playerTurn.ForeColor = gameBoard.getPlayer2().getChipColor();
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
        private void btn_back_Click(object sender, EventArgs e)
        {
            WCForm.Show();
            this.Close();
            click1.Play();
        }

        public async Task showStats() 
        {
            //keeps game screen up for a few seconds
            await Task.Delay(TimeSpan.FromSeconds(3));

            //hides the game form and opens statistics
            if (gameBoard.checkWin(1))
            {
                statForm = new Statistics(this, WCForm, gameBoard.getPlayer1().getName() + " Won!", gameBoard.getPlayer1().getChipColor());
            }
            else if (gameBoard.checkWin(2))
            {
                statForm = new Statistics(this, WCForm, gameBoard.getPlayer2().getName() + " Won!", gameBoard.getPlayer2().getChipColor());
            }
            else
            {
                statForm = new Statistics(this, WCForm, gameBoard.getPlayer2().getName() + "It was a tie!", Color.Black);
            }
            statForm.Show();
            this.Close();
        }



        //ignore these
        private void TwoplayerForm_Load(object sender, EventArgs e)
        {
            place.Load();
        }
        private void TwoplayerForm_Activated(object sender, EventArgs e)
        {
            //music2.PlayLooping();
        }

        private List<Game> readGames()
        {
            try
            {
                string fileName = "TwoPlayerGames.txt";
                string baseDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(baseDirectoryPath, fileName);
                StreamReader reader = new StreamReader(filePath);
                //StreamReader reader = new StreamReader("../../Resources/TwoPlayerGames.txt");
                string game;
                string play;
                char playDelim = '.';
                char delim = ',';
                int playDelimPos;
                int delimPos;
                List<Play> plays = new List<Play>();
                List<Game> games = new List<Game>();
                game = reader.ReadLine();
                while (game != null)
                {
                    Game gameReview = new Game();
                    delimPos = game.IndexOf(delim);
                    gameReview.setPlayer1(game.Substring(0, delimPos));
                    
                    game = game.Substring(delimPos + 1);
                    delimPos = game.IndexOf(delim);
                    gameReview.setPlayer2(game.Substring(0, delimPos));

                    game = game.Substring(delimPos + 1);
                    delimPos = game.IndexOf(delim);
                    gameReview.setWinner(Int32.Parse(game.Substring(0, delimPos)));

                    game = game.Substring(delimPos + 1);

                    plays.Clear();
                    playDelimPos = game.IndexOf(playDelim);
                    play = game.Substring(0, playDelimPos);
                    while (game.IndexOf(playDelim) != -1)
                    {
                        Play playReview = new Play();
                        delimPos = play.IndexOf(delim);
                        playReview.setRow(Int32.Parse(play.Substring(0,delimPos)));
                        play = play.Substring(delimPos + 1);
                        delimPos = play.IndexOf(delim);
                        playReview.setCol(Int32.Parse(play.Substring(0, delimPos)));
                        play = play.Substring(delimPos + 1);
                        playReview.setTurnNum(Int32.Parse(play));
                        plays.Add(playReview);
                        game = game.Substring(playDelimPos + 1);
                        playDelimPos = game.IndexOf(playDelim);
                    if (playDelimPos != -1)
                    { 
                        play = game.Substring(0, playDelimPos);
                    }
                }
                gameReview.setPlays(new List<Play>(plays));
                    games.Add(gameReview);
                    game = reader.ReadLine();
                    if (game == "\n")
                    {
                        game = null;
                    }
                }
                reader.Close();
                return games;
            }
            catch (Exception e)
            {
                Debug.WriteLine("ERROR. File Not Found");
                return new List<Game>();
            }
        }
        public void writeGames()
        {
            try
            {
                string fileName = "TwoPlayerGames.txt";
                string baseDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(baseDirectoryPath, fileName);
                StreamWriter writer = new StreamWriter(filePath);
                //StreamWriter writer = new StreamWriter("../../Resources/TwoPlayerGames.txt");
                for (int i = 0; i < listOfGames.Count(); i++)
                {
                    writer.Write($"{listOfGames[i].getPlayer1()},{listOfGames[i].getPlayer2()},{listOfGames[i].getWinner()},");
                    for (int j = 0; j < listOfGames[i].getPlays().Count(); j++)
                    {
                        writer.Write($"{listOfGames[i].getPlays()[j].getRow()},{listOfGames[i].getPlays()[j].getCol()},{listOfGames[i].getPlays()[j].getTurnNum()}.");
                    }
                    writer.Write("\n");
                }
                writer.Close();
            }
            catch (Exception e)
            {
                Debug.WriteLine("ERROR. File Not Found");
            }
        }

        private void Twoplayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!gameOver)
            { 
                WCForm.Show();
            }
        }
    }
}
