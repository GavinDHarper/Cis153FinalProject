using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_FinalProject
{
    public partial class GameReview : Form
    {
        WelcomeForm WCForm;
        Statistics statForm;
        MatchHistory matchHistory;
        private List<Game> listOfGames = new List<Game>();
        private Game game;
        private int turn;
        private int plays;
        SoundPlayer click1 = new SoundPlayer("click1.wav");
        int backButtonNum = 0;

        public GameReview()
        {
            InitializeComponent();
        }
        public GameReview(Statistics s, WelcomeForm wf, int gameMode)
        {
            WCForm = wf;
            statForm = s;
            InitializeComponent();
            if (gameMode == 1)
            {
                listOfGames = readGames("SinglePlayerGames.txt");
                game = listOfGames[listOfGames.Count() - 1];
            }
            else
            {
                listOfGames = readGames("TwoPlayerGames.txt");
                game = listOfGames[listOfGames.Count() - 1];
            }
            if (game.getWinner() == 1)
            {
                lbl_win.Text = game.getPlayer1();
                lbl_win.ForeColor = Color.Red;
            }
            else if (game.getWinner() == 2)
            {
                lbl_win.Text = game.getPlayer2();
                lbl_win.ForeColor = Color.Blue;
            }
            else
            {
                lbl_win.Text = "Tie";
                lbl_win.ForeColor = Color.Black;
            }
            plays = game.getPlays().Count();
            if (game.getPlays()[plays - 1].getTurnNum() == 1)
            {
                pictureBox1.Image = Image.FromFile("../../Resources/connect4chipIconRED.png");
            }
            else
            {
                pictureBox1.Image = Image.FromFile("../../Resources/connect4chipIconBLUE.png");
            }
            turn = game.getPlays().Count();
            lbl_turnCount.Text = turn + " / " + game.getPlays().Count().ToString();
            populateBoard(turn);
            backButtonNum = 1;
        }
        public GameReview(MatchHistory m, WelcomeForm wf, int gameMode, int gameNum)
        {
            WCForm = wf;
            matchHistory = m;
            InitializeComponent();
            if (gameMode == 1)
            {
                listOfGames = readGames("SinglePlayerGames.txt");
                game = listOfGames[gameNum];
            }
            else
            {
                listOfGames = readGames("TwoPlayerGames.txt");
                game = listOfGames[gameNum];
            }
            if (game.getWinner() == 1)
            {
                lbl_win.Text = game.getPlayer1();
                lbl_win.ForeColor = Color.Red;
            }
            else if (game.getWinner() == 2)
            {
                lbl_win.Text = game.getPlayer2();
                lbl_win.ForeColor = Color.Blue;
            }
            else
            {
                lbl_win.Text = "Tie";
                lbl_win.ForeColor = Color.Black;
            }
            plays = game.getPlays().Count();
            if (game.getPlays()[plays - 1].getTurnNum() == 1)
            {
                pictureBox1.Image = Image.FromFile("../../Resources/connect4chipIconRED.png");
            }
            else
            {
                pictureBox1.Image = Image.FromFile("../../Resources/connect4chipIconBLUE.png");
            }
            turn = game.getPlays().Count();
            lbl_turnCount.Text = turn + " / " + game.getPlays().Count().ToString();
            populateBoard(turn);
            backButtonNum = 2;
        }

        private List<Game> readGames(string fileName)
        {
            try
            {
                string fName = fileName;
                string baseDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(baseDirectoryPath, fileName);
                StreamReader reader = new StreamReader(filePath);
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
                        playReview.setRow(Int32.Parse(play.Substring(0, delimPos)));
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
        private void btn_previousPlay_Click(object sender, EventArgs e)
        {
            turn--;
            if (turn <= 0)
            {
                turn = game.getPlays().Count();
            }
            lbl_turnCount.Text = turn.ToString() + " / " + game.getPlays().Count().ToString();
            populateBoard(turn);
        }

        private void btn_nextPlay_Click(object sender, EventArgs e)
        {
            turn++;
            if (turn > game.getPlays().Count())
            {
                turn = 1;
            }
            lbl_turnCount.Text = turn.ToString() + " / " + game.getPlays().Count().ToString();
            populateBoard(turn);
        }
        public void resetBoard()
        {
            SP_00.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_10.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_20.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_30.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_40.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_50.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_01.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_11.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_21.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_31.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_41.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_51.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_02.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_12.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_22.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_32.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_42.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_52.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_03.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_13.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_23.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_33.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_43.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_53.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_04.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_14.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_24.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_34.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_44.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_54.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_05.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_15.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_25.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_35.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_45.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_55.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_06.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_16.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_26.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_36.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_46.Image = Image.FromFile("../../Resources/emptyCell.png");
            SP_56.Image = Image.FromFile("../../Resources/emptyCell.png");
        }
        public void populateBoard(int turn)
        {
            resetBoard();
            int row;
            int col;
            int playerTurn;
            List<Play> plays = new List<Play>(game.getPlays());
            for (int i = 0; i < turn; i++)
            {
                row = plays[i].getRow();
                col = plays[i].getCol();
                playerTurn = plays[i].getTurnNum();
                string picBoxPath = "SP_" + row.ToString() + col.ToString();
                //Console.WriteLine(picBoxPath);
                PictureBox picBox = (PictureBox)this.Controls[picBoxPath];
                if (playerTurn == 1)
                {
                    picBox.Image = Image.FromFile("../../Resources/connect4chipIconRED.png");
                }
                else
                {
                    picBox.Image = Image.FromFile("../../Resources/connect4chipIconBLUE.png");
                }
            }
        }
        private void btn_back_Click(object sender, EventArgs e)
        {
            click1.Play();
            if (backButtonNum == 1)
            {
                statForm.Show();
            }
            else if (backButtonNum == 2)
            {
                matchHistory.Show();
            }
            else
            {
                WCForm.Show();
            }
            this.Close();
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GameReview_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backButtonNum == 1)
            {
                statForm.Show();
            }
            else if (backButtonNum == 2)
            {
                matchHistory.Show();
            }
            else
            {
                WCForm.Show();
            }
        }
    }
}
