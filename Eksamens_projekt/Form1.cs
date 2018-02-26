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
        Player Player1;
        Slime Mob;
        int level;
        int floor;

        public Form1()
        {
            InitializeComponent();
        }

        private void restart()
        {
            pictureBox1.Image = Eksamens_projekt.Properties.Resources.start_screen_v2;

            Attack.Visible = false;
            Player_Life.Visible = false;
            Mob_Life.Visible = false;
            level = 0;
        }

        private void new_floor()
        {
            level++;
            floor = Convert.ToInt32(Math.Floor(level / 5f));

            Player1.Current_Life = Player1.Max_Life;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(896, 640);

            restart();

            Start.Parent = pictureBox1;
            Highscore.Parent = pictureBox1;
            Settings.Parent = pictureBox1;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Eksamens_projekt.Properties.Resources.Background1;

            Player1 = new Player();
            Mob = new Slime();

            Player_Life.Text = $"HP: {Player1.Current_Life} / {Player1.Max_Life}";
            Mob_Life.Text = $"HP: {Mob.Current_Life} / {Mob.Max_Life}";

            Attack.Visible = true;
            Player_Life.Visible = true;
            Mob_Life.Visible = true;

            level++;
        }

        private void Highscore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a placeholder for a future feature");
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a placeholder for a future feature");
        }

        private void Attack_Click(object sender, EventArgs e)
        {
            Mob.Current_Life = Mob.Current_Life - Player1.Damage;
            Mob_Life.Text = $"HP: {Mob.Current_Life} / {Mob.Max_Life}";

            if (Mob.Current_Life < 1)
            {
                Player1.Current_Life = Player1.Current_Life - Mob.Damage;
                Player_Life.Text = $"HP: {Player1.Current_Life} / {Player1.Max_Life}";
                if (Player1.Current_Life < 1)
                {
                    MessageBox.Show("You Failed");
                    restart();
                }
            }
            else
            {
                
            }
        }
    }
}
