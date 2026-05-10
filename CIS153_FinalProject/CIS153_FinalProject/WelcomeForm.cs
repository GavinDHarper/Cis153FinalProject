//============================================================================
//Authors: Cole Bourbina, Nathan Gamboa, Gavin Harper, Todd Sachs, Owen White
//Date  : 05-10-2026
//Desc  : Connect Four
//============================================================================
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
using System.Media;

namespace CIS153_FinalProject
{
    public partial class WelcomeForm : Form
    {
        SoundPlayer music = new SoundPlayer("music1.wav");
        SoundPlayer music2 = new SoundPlayer("music2.wav");
        SoundPlayer click1 = new SoundPlayer("click1.wav");

        //how fast label moves
        int yVelocity = 2;
        //starting y-value of the label
        int originalY;
        Timer bounceTimer = new Timer();
        public WelcomeForm()
        {
            //push practice - Nathan Gamboa
            //push practice - Gavin Harper
            //push practice - Todd Sachs
            InitializeComponent();
            //setting values
            originalY = lbl_logo1.Top;
            bounceTimer.Interval = 90;
            //loops function every tick
            bounceTimer.Tick += bounceTimer_Tick;
            //starts timer
            bounceTimer.Start();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            music.PlayLooping();
        }

        private async void btn_Singleplayer_Click(object sender, EventArgs e)
        {
            Singleplayer singleplayer = new Singleplayer(this);
            singleplayer.Show();
            this.Hide();
            music.Stop();
            click1.Play();
            await Task.Delay(500);
            music2.PlayLooping();
        }

        private async void btn_Twoplayer_Click(object sender, EventArgs e)
        {
            Twoplayer twoplayer = new Twoplayer(this);
            twoplayer.Show();
            this.Hide();

            music.Stop();
            click1.Play();
            await Task.Delay(500);
            music2.PlayLooping();
        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics(this);
            statistics.Show();
            this.Hide();
            //music.Stop();
            click1.Play();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bounceTimer_Tick(object sender, EventArgs e)
        {
            //logo 1
            lbl_logo1.Top += yVelocity;
            lbl_logo2.Top += yVelocity;

            //checks and makes sure the labels don't go too far 
            //from starting position
            if (lbl_logo1.Top > originalY + 10)
            {
                yVelocity = -2;
            }

            if (lbl_logo1.Top < originalY - 10)
            {
                yVelocity = 2;
            }

        }

        private async void WelcomeForm_Activated(object sender, EventArgs e)
        {
            await Task.Delay(500);
            music.PlayLooping();
            
        }
    }
}
