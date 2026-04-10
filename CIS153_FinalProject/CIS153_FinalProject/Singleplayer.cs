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
    public partial class Singleplayer : Form
    {
        WelcomeForm WCForm;
        public Singleplayer()
        {
            InitializeComponent();
        }
        public Singleplayer(WelcomeForm WCF)
        {
            InitializeComponent();
            WCForm = WCF;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            WCForm.Show();
            this.Close();
        }
    }
}
