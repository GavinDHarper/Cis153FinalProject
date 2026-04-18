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

namespace CIS153_FinalProject
{
    public partial class Statistics : Form
    {
        WelcomeForm WCForm;
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            WCForm.Show();
            this.Close();
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
                playerPercent = Math.Round(((Double.Parse(playerWins) / Double.Parse(gamesPlayed)) * 100), 2);
                computerPercent = Math.Round(((Double.Parse(computerWins) / Double.Parse(gamesPlayed)) * 100), 2);

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

        
    }
}
