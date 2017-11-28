using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RunescapeAndTheGreenKnight
{
    public partial class Form1 : Form
    {
        static int Section = 0;
        public Form1()
        {
            InitializeComponent();
            LoadSection();
        }

        private void start_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            start.Visible = false;

        }
        private void LoadSection()
        {
            switch (Section)
            {
                case 0:
                    video.URL = "";
                    Option1.Text = "Volunteer yourself in place of the king";
                    Option2.Text = "Let the king play the game";
                    break;
                case 1:
                    video.URL = "";
                    Option1.Text = "Leave in search for the castle";
                    Option2.Text = "Stay at the castle for your own safety";
                    break;
                case 2:
                    video.URL = "";
                    Option1.Text = "Pray to the gods for help";
                    Option2.Text = "Keep searching";
                    break;
                case 3:
                    video.URL = "";
                    Option1.Text = "Accept Bertilak's deal";
                    Option2.Text = "Refuse Bertilak's deal and keep looking";
                    break;
                case 4:
                    video.URL = "";
                    Option1.Text = "Accept graciously";
                    Option2.Text = "Accept eagarly";
                    break;
                case 5:
                    video.URL = "";
                    Option1.Text = "Accept";
                    Option2.Text = "Decline";
                    break;
                case 6:
                    video.URL = "";
                    Option1.Text = "Continue with the Quest";
                    Option2.Text = "Take Grindolet's word and leave";
                    break;
                case 7:
                    video.URL = "";
                    Option1.Text = "Get your head chopped off";
                    Option2.Text = "Run away cowardly";
                    break;  


            }
        }
        private void LoadDeath()
        {
            switch (Section)
            {

            }
        }
        private void Option1_Click(object sender, EventArgs e)
        {
            Section++;
            LoadSection();
        }

        private void Option2_Click(object sender, EventArgs e)
        {
            LoadDeath();
        }
    }
}
