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
        Mob mob;
        int level;
        float floor;
        int score;
        bool Player_turn;
        float floors_pr_level;

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

            //skal være et primtal
            floors_pr_level = 7;

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

            floor = 0;
            score = 0;
            level = 0;
            Player_turn = true;
        }


        private void Start_Click(object sender, EventArgs e)
        {
            background.Image = Eksamens_projekt.Properties.Resources.Background1;

            Player1 = new Player();
            player_picture.Image = Eksamens_projekt.Properties.Resources.character;

            mob = new Slime();
            mob_picture.Image = Eksamens_projekt.Properties.Resources.Basic_Slime;

            Player_Life.Text = $"HP: {Player1.Current_Life} / {Player1.Max_Life}";
            Mob_Life.Text = $"HP: {mob.Current_Life} / {mob.Max_Life}";

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

            level = Convert.ToInt32(Math.Floor(floor / floors_pr_level));

            switch (level)
            {
                case 0: //skal være case 0:
                    if(floor % (floors_pr_level - 1) == 0)
                    {
                        mob = new Boss_Slime();
                        mob_picture.Image = Eksamens_projekt.Properties.Resources.Boss_Slime;
                    }
                    else
                    {
                        Random r1 = new Random();
                        Slime_type = r1.Next(1, 6);

                        switch (Slime_type)
                        {
                            case 1:
                                mob = new Fire_Slime();
                                mob_picture.Image = Eksamens_projekt.Properties.Resources.Fire_Slime;
                                break;
                            case 2:
                                mob = new Water_Slime();
                                mob_picture.Image = Eksamens_projekt.Properties.Resources.Water_Slime;
                                break;
                            case 3:
                                mob = new Air_Slime();
                                mob_picture.Image = Eksamens_projekt.Properties.Resources.Air_Slime;
                                break;
                            case 4:
                                mob = new Earth_Slime();
                                mob_picture.Image = Eksamens_projekt.Properties.Resources.Earth_Slime;
                                break;
                            default:
                                mob = new Slime();
                                mob_picture.Image = Eksamens_projekt.Properties.Resources.Basic_Slime;
                                break;
                        }
                    }

                    break;

                default:
                    if (floor % (floors_pr_level - 1) == 0)
                    {
                        mob = new Armored_skeleton();
                        mob_picture.Image = Eksamens_projekt.Properties.Resources.Armored_skeleton;
                    }
                    else
                    {
                        Random r2 = new Random();
                        Undead_type = r2.Next(1, 5);

                        switch (Undead_type)
                        {
                            case 1:
                                mob = new Skeleton();
                                mob_picture.Image = Eksamens_projekt.Properties.Resources.Skeleton;
                                break;
                            case 2:
                                mob = new Vampire();
                                mob_picture.Image = Eksamens_projekt.Properties.Resources.Vampire;
                                break;
                            case 3:
                                mob = new Ghost();
                                mob_picture.Image = Eksamens_projekt.Properties.Resources.Ghost;
                                break;
                            default:
                                mob = new Zombie();
                                mob_picture.Image = Eksamens_projekt.Properties.Resources.Zombie;
                                break;
                        }
                    }


                    break;
            }

            Player1.Current_Life = Player1.Max_Life;
            Player_Life.Text = $"HP: {Player1.Current_Life} / {Player1.Max_Life}";
            Mob_Life.Text = $"HP: {mob.Current_Life} / {mob.Max_Life}";

            Player_turn = true;
        }

        private void Attack_Click(object sender, EventArgs e)
        {
            if (Player_turn == true)
            {
                mob.Current_Life = mob.Current_Life - Player1.Damage;
                Mob_Life.Text = $"HP: {mob.Current_Life} / {mob.Max_Life}";
                Player_turn = false;

                if (mob.Current_Life > 1)
                {
                    Mob_turn();
                }
                else
                {
                    score = score + mob.Score;
                    Score_viewer.Text = $"Score: {score}";
                    new_floor();
                }
            }
        }

        public void Mob_turn()
        {
            Player1.Current_Life = Player1.Current_Life - mob.Damage;
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
