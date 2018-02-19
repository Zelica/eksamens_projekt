using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eksamens_projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(896, 640);
            pictureBox1.Image = Eksamens_projekt.Properties.Resources.start_screen_v2;
            Start.Parent = pictureBox1;
            Highscore.Parent = pictureBox1;
            Settings.Parent = pictureBox1;
        }

        private void Start_Click(object sender, EventArgs e)
        {

        }

        private void Highscore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a placeholder for a future feature");
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a placeholder for a future feature");
        }
    }
}
