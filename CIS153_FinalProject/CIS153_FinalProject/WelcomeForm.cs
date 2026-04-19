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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            //push practice - Nathan Gamboa
            //push practice - Gavin Harper
            //push practice - Todd Sachs
            InitializeComponent();
        }

        private void btn_Singleplayer_Click(object sender, EventArgs e)
        {
            Singleplayer singleplayer = new Singleplayer(this);
            singleplayer.Show();
            this.Hide();
        }

        private void btn_Twoplayer_Click(object sender, EventArgs e)
        {
            Twoplayer twoplayer = new Twoplayer(this);
            twoplayer.Show();
            this.Hide();
        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics(this);
            statistics.Show();
            this.Hide();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
