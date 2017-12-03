using System;
using System.IO;
using System.Reflection;
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
        public Form1()
        {
            InitializeComponent();
            f2 = new Form2();
        }
        private void start_Click(object sender, EventArgs e)
        {
            
        }
        private Form2 f2;

        private void start_Click_1(object sender, EventArgs e)
        {
            label1.Visible = false;
            start.Visible = false; f2.Show(); Hide();
        }
    }
}
