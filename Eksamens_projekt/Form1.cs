﻿using System;
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
        
        int Slime_type;
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
            background.Image = Eksamens_projekt.Properties.Resources.start_screen;
            player_picture.Image = null;
            mob_picture.Image = null;


            Attack.Visible = false;
            Player_Life.Visible = false;
            Mob_Life.Visible = false;

            level = 0;
        }

        private void new_floor()
        {
            floor++;

            level = Convert.ToInt32(Math.Floor(floor/ 5f));
            switch(level)
            {
                default:
                    Random r1 = new Random();
                    Slime_type = r1.Next(1, 6);
                    switch(Slime_type)
                    {
                        case 1:
                            Mob = new Fire();
                            mob_picture.Image = Eksamens_projekt.Properties.Resources.Fire_Slime;
                            break;
                        case 2:
                            Mob = new Water();
                            mob_picture.Image = Eksamens_projekt.Properties.Resources.Water_Slime;
                            break;
                        case 3:
                            Mob = new Air();
                            mob_picture.Image = Eksamens_projekt.Properties.Resources.Air_Slime;
                            break;
                        case 4:
                            Mob = new Earth();
                            mob_picture.Image = Eksamens_projekt.Properties.Resources.Earth_Slime;
                            break;
                        default:
                            Mob = new Slime();
                            mob_picture.Image = Eksamens_projekt.Properties.Resources.Basic_Slime;
                            break;
                    }

                    break;
            }

            Player1.Current_Life = Player1.Max_Life;
            Player_Life.Text = $"HP: {Player1.Current_Life} / {Player1.Max_Life}";
            Mob_Life.Text = $"HP: {Mob.Current_Life} / {Mob.Max_Life}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(896, 640);

            restart();
            player_picture.Parent = background;
            mob_picture.Parent = background;
            Start.Parent = background;
            Highscore.Parent = background;
            Settings.Parent = background;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            background.Image = Eksamens_projekt.Properties.Resources.Background1;

            Player1 = new Player();
            player_picture.Image = Eksamens_projekt.Properties.Resources.character;
            Mob = new Slime();
            mob_picture.Image = Eksamens_projekt.Properties.Resources.Basic_Slime;

            Player_Life.Text = $"HP: {Player1.Current_Life} / {Player1.Max_Life}";
            Mob_Life.Text = $"HP: {Mob.Current_Life} / {Mob.Max_Life}";

            Attack.Visible = true;
            Player_Life.Visible = true;
            Mob_Life.Visible = true;

            floor++;
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

            if (Mob.Current_Life > 1)
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
                new_floor();
            }
        }
    }
}
