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
    public partial class MatchHistory : Form
    {
        WelcomeForm WCForm;
        Statistics StatForm;
        SoundPlayer click1 = new SoundPlayer("click1.wav");
        private List<Game> listOfGames1P = new List<Game>();
        private List<Game> listOfGames2P = new List<Game>();

        public MatchHistory()
        {
            InitializeComponent();
        }
        public MatchHistory(WelcomeForm welcomeForm, Statistics stats)
        {
            InitializeComponent();
            WCForm = welcomeForm;
            StatForm = stats;
            fillListBox();
        }

        private void MatchHistory_FormClosing(object sender, FormClosingEventArgs e)
        {
            StatForm.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            click1.Play();
            StatForm.Show();
            this.Close();
        }
        public void fillListBox()
        {
            listOfGames1P = readGames("SinglePlayerGames.txt");
            listOfGames2P = readGames("TwoPlayerGames.txt");
            for (int i = 0; i < listOfGames1P.Count; i++)
            {
                lst_singlePlayer.Items.Add("Game " + (i + 1));
            }
            for (int i = 0; i < listOfGames2P.Count; i++)
            {
                lst_twoPlayer.Items.Add("Game " + (i + 1));
            }
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

        public void writeGames1P(string fileName)
        {
            try
            {
                string baseDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(baseDirectoryPath, fileName);
                StreamWriter writer = new StreamWriter(filePath);
                for (int i = 0; i < listOfGames1P.Count(); i++)
                {
                    writer.Write($"{listOfGames1P[i].getPlayer1()},{listOfGames1P[i].getPlayer2()},{listOfGames1P[i].getWinner()},");
                    for (int j = 0; j < listOfGames1P[i].getPlays().Count(); j++)
                    {
                        writer.Write($"{listOfGames1P[i].getPlays()[j].getRow()},{listOfGames1P[i].getPlays()[j].getCol()},{listOfGames1P[i].getPlays()[j].getTurnNum()}.");
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

        public void writeGames2P(string fileName)
        {
            try
            {
                string baseDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(baseDirectoryPath, fileName);
                StreamWriter writer = new StreamWriter(filePath);
                for (int i = 0; i < listOfGames2P.Count(); i++)
                {
                    writer.Write($"{listOfGames2P[i].getPlayer1()},{listOfGames2P[i].getPlayer2()},{listOfGames2P[i].getWinner()},");
                    for (int j = 0; j < listOfGames2P[i].getPlays().Count(); j++)
                    {
                        writer.Write($"{listOfGames2P[i].getPlays()[j].getRow()},{listOfGames2P[i].getPlays()[j].getCol()},{listOfGames2P[i].getPlays()[j].getTurnNum()}.");
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

        private void lst_singlePlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_singlePlayer.SelectedIndex != -1)
            { 
                lst_twoPlayer.SelectedIndex = -1;
            }
            btn_view.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void lst_twoPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_twoPlayer.SelectedIndex != -1)
            { 
                lst_singlePlayer.SelectedIndex = -1;
            }
            btn_view.Enabled = true;
            btn_delete.Enabled = true;
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (lst_singlePlayer.SelectedIndex == -1 && lst_twoPlayer.SelectedIndex == -1)
            {
                btn_view.Enabled = false;
                btn_delete.Enabled = false;
            }
            else if (lst_singlePlayer.SelectedIndex != -1)
            {
                if (listOfGames1P[lst_singlePlayer.SelectedIndex] != null)
                {
                    GameReview gameReview = new GameReview(this, WCForm, 1, lst_singlePlayer.SelectedIndex);
                    gameReview.Show();
                    this.Hide();
                }
            }
            else if (lst_twoPlayer.SelectedIndex != -1)
            {
                if (listOfGames2P[lst_twoPlayer.SelectedIndex] != null)
                {
                    GameReview gameReview = new GameReview(this, WCForm, 2, lst_twoPlayer.SelectedIndex);
                    gameReview.Show();
                    this.Hide();
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lst_singlePlayer.SelectedIndex == -1 && lst_twoPlayer.SelectedIndex == -1)
            {
                btn_view.Enabled = false;
                btn_delete.Enabled = false;
            }
            else if (lst_singlePlayer.SelectedIndex != -1)
            {
                if (listOfGames1P[lst_singlePlayer.SelectedIndex] != null)
                {
                    listOfGames1P.RemoveAt(lst_singlePlayer.SelectedIndex);
                    writeGames1P("SinglePlayerGames.txt");
                }
            }
            else if (lst_twoPlayer.SelectedIndex != -1)
            {
                if (listOfGames2P[lst_twoPlayer.SelectedIndex] != null)
                {
                    listOfGames2P.RemoveAt(lst_twoPlayer.SelectedIndex);
                    writeGames2P("twoPlayerGames.txt");
                }
            }
            lst_singlePlayer.Items.Clear();
            lst_twoPlayer.Items.Clear();
            fillListBox();
            btn_view.Enabled = false;
            btn_delete.Enabled = false;
        }
    }
}