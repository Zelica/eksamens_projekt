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
        
        int Slime_type;
        int Undead_type;
        Player Player1;
        Slime Mob;
        int level;
        int floor;
        int score;
        bool Player_turn;
        int floors_pr_level;

        public Form1()
        {
            InitializeComponent();
        }

        private void Highscore_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a placeholder for a future feature");
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a placeholder for a future feature");
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(896, 640);

            floors_pr_level = 10;

            restart();

            Score_viewer.Parent = background;
            player_picture.Parent = background;
            mob_picture.Parent = background;
            Start.Parent = background;
            Highscore.Parent = background;
            Settings.Parent = background;
        }

        public void restart()
        {
            background.Image = Eksamens_projekt.Properties.Resources.start_screen;
            player_picture.Image = null;
            mob_picture.Image = null;

            Score_viewer.Visible = false;
            Attack.Visible = false;
            Player_Life.Visible = false;
            Mob_Life.Visible = false;

            level = 0;
            Player_turn = true;
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

            Score_viewer.Text = $"Score: {score}";

            Score_viewer.Visible = true;
            Attack.Visible = true;
            Player_Life.Visible = true;
            Mob_Life.Visible = true;

            floor++;
        }

        private void new_floor()
        {
            floor++;

            level = Convert.ToInt32(Math.Floor(floor / 10f));
            switch (level)
            {
                case 1:
                    Random r1 = new Random();
                    Slime_type = r1.Next(1, 6);
                    if(floor % floors_pr_level == 0)
                    {
                        Mob = new Boss_Slime();
                        mob_picture.Image = Eksamens_projekt.Properties.Resources.Boss_Slime;
                    }
                    else
                    {
                        switch (Slime_type)
                        {
                            case 1:
                                Mob = new Fire_Slime();
                                mob_picture.Image = Eksamens_projekt.Properties.Resources.Fire_Slime;
                                break;
                            case 2:
                                Mob = new Water_Slime();
                                mob_picture.Image = Eksamens_projekt.Properties.Resources.Water_Slime;
                                break;
                            case 3:
                                Mob = new Air_Slime();
                                mob_picture.Image = Eksamens_projekt.Properties.Resources.Air_Slime;
                                break;
                            case 4:
                                Mob = new Earth_Slime();
                                mob_picture.Image = Eksamens_projekt.Properties.Resources.Earth_Slime;
                                break;
                            default:
                                Mob = new Slime();
                                mob_picture.Image = Eksamens_projekt.Properties.Resources.Basic_Slime;
                                break;
                        }
                    }

                    break;

                default:
                    Random r2 = new Random();
                    Undead_type = r2.Next(1, 5);
                    //if (floor % floors_pr_level == 0)
                    //{
                    //    Mob = new Armored_skeleton();
                    //    mob_picture.Image = Eksamens_projekt.Properties.Resources.Armored_skeleton;
                    //}
                    //else
                    //{
                        switch (Undead_type)
                        {
                            case 1:
                                Mob = new Skeleton();
                                mob_picture.Image = Eksamens_projekt.Properties.Resources.Fire_Slime;
                                break;
                            //case 2:
                                //Mob = new Water_Slime();
                                //mob_picture.Image = Eksamens_projekt.Properties.Resources.Water_Slime;
                                //break;
                            //case 3:
                                //Mob = new Air_Slime();
                                //mob_picture.Image = Eksamens_projekt.Properties.Resources.Air_Slime;
                                //break;
                            default:
                                Mob = new Zombie();
                                mob_picture.Image = Eksamens_projekt.Properties.Resources.Earth_Slime;
                                break;
                        //}
                    }

                    break;
            }

            Player1.Current_Life = Player1.Max_Life;
            Player_Life.Text = $"HP: {Player1.Current_Life} / {Player1.Max_Life}";
            Mob_Life.Text = $"HP: {Mob.Current_Life} / {Mob.Max_Life}";

            Player_turn = true;
        }

        private void Attack_Click(object sender, EventArgs e)
        {
            if (Player_turn == true)
            {
                Mob.Current_Life = Mob.Current_Life - Player1.Damage;
                Mob_Life.Text = $"HP: {Mob.Current_Life} / {Mob.Max_Life}";
                Player_turn = false;

                if (Mob.Current_Life > 1)
                {
                    Mob_turn();
                }
                else
                {
                    score = score + Mob.score;
                    Score_viewer.Text = $"Score: {score}";
                    new_floor();
                }
            }
        }

        public void Mob_turn()
        {
            Player1.Current_Life = Player1.Current_Life - Mob.Damage;
            Player_Life.Text = $"HP: {Player1.Current_Life} / {Player1.Max_Life}";

            if (Player1.Current_Life < 1)
            {
                MessageBox.Show("You Failed");
                restart();
            }

            Player_turn = true;
        }
    }
}
