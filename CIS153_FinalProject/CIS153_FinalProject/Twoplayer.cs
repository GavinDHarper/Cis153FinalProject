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

        WelcomeForm WCForm;
        public Twoplayer()
        {
            InitializeComponent();
            
        }
        public Twoplayer(WelcomeForm WCF)
        {
            InitializeComponent();
            WCForm = WCF;
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
        }

       
    }
}
