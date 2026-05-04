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
using System.Diagnostics;
using System.Media;

namespace CIS153_FinalProject
{
    public partial class Statistics : Form
    {
        SoundPlayer click1 = new SoundPlayer("click1.wav");
        WelcomeForm WCForm;
        Singleplayer single;
        Twoplayer twoplayer;
        public Statistics()
        {
            InitializeComponent();
            readDisplayStats();
        }
        public Statistics(WelcomeForm WCF)
        {
            InitializeComponent();
            readDisplayStats();
            WCForm = WCF;
        }

        public Statistics(Singleplayer s, WelcomeForm WCF)
        {
            InitializeComponent();
            readDisplayStats();
            single = s;
            WCForm = WCF;
        }

        public Statistics(Twoplayer tp, WelcomeForm WCF)
        {
            InitializeComponent();
            readDisplayStats();
            twoplayer = tp;
            WCForm = WCF;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_ReturnToWelcome_Click(object sender, EventArgs e)
        {
            WCForm.Show();
            this.Close();
            if (single != null)
            {
                single.Close();
            }
            if (twoplayer != null)
            {
                twoplayer.Close();
            }
            click1.Play();
        }
        public void readDisplayStats()
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

                string gamesPlayed;
                string playerWins;
                string computerWins;
                string ties;
                double playerPercent;
                double computerPercent;

                int comma;
                char delim = ',';

                //get games played
                comma = line.IndexOf(delim);
                gamesPlayed = line.Substring(0, comma);
                line = line.Substring(comma + 1);

                //get playerWins
                comma = line.IndexOf(delim);
                playerWins = line.Substring(0, comma);
                line = line.Substring(comma + 1);

                //get computerWins
                comma = line.IndexOf(delim);
                computerWins = line.Substring(0, comma);
                line = line.Substring(comma + 1);

                //get ties
                ties = line;

                //calculations
                if (Double.Parse(gamesPlayed) > 0)
                {
                    playerPercent = Math.Round(((Double.Parse(playerWins) / Double.Parse(gamesPlayed)) * 100), 2);
                }
                else
                {
                    playerPercent = 0;
                }
                if (Double.Parse(gamesPlayed) > 0)
                {
                    computerPercent = Math.Round(((Double.Parse(computerWins) / Double.Parse(gamesPlayed)) * 100), 2);
                }
                else
                { 
                    computerPercent = 0; 
                }

                    

                //display
                lbl_stats_numGames.Text = gamesPlayed;
                lbl_stats_numPWins.Text = playerWins;
                lbl_stats_numCpuWins.Text = computerWins;
                lbl_stats_numTies.Text = ties;
                lbl_stats_playerPNum.Text = playerPercent.ToString() + '%';
                lbl_stats_cpuPNum.Text = computerPercent.ToString() + '%';
            }
            catch(Exception e)
            {
                Debug.WriteLine("ERROR. File Not Found");
            }
        }

        private void btn_review_Click(object sender, EventArgs e)
        {
            if (single != null)
            {
                single.Show();
                click1.Play();
            }
            else if (twoplayer != null)
            {
                twoplayer.Show();
                click1.Play();
            }
            
        }
    }
}
