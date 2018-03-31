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
        
        int SlimeType;
        int UndeadType;

        Player player;
        Mob mob;

        int Delay;
        int Level;
        float Floor;
        int TotalScore;
        bool PlayerTurn;
        float FloorsPrLevel;


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
            FloorsPrLevel = 7;
            Delay = 0;

            Restart();

            ScoreViewer.Parent = Background;
            PlayerPicture.Parent = Turn_Images;
            MobPicture.Parent = Turn_Images;
            Start.Parent = Background;
            Highscore.Parent = Background;
            Settings.Parent = Background;
            Turn_Images.Parent = Background;
        }

        public async void Restart()
        {
            Settings.Parent = Background;

            Background.Image = Eksamens_projekt.Properties.Resources.start_screen;
            PlayerPicture.Image = null;
            MobPicture.Image = null;
            Turn_Images.Image = null;

            ScoreViewer.Visible = false;
            Attack.Visible = false;
            PlayerLife.Visible = false;
            MobLife.Visible = false;

            Air.Visible = false;
            Fire.Visible = false;
            Earth.Visible = false;
            Water.Visible = false;

            Floor = 0;
            TotalScore = 0;
            Level = 0;

            Turn_Images.Image = Properties.Resources.Your_turn;
            await Task.Delay(Delay);
            Turn_Images.Image = null;
            PlayerTurn = true;
        }


        private void Start_Click(object sender, EventArgs e)
        {
            Settings.Parent = MobPicture;

            Background.Image = Eksamens_projekt.Properties.Resources.Background1;

            player = new Player();
            PlayerPicture.Image = Eksamens_projekt.Properties.Resources.character;

            mob = new Slime();
            MobPicture.Image = Eksamens_projekt.Properties.Resources.Basic_Slime;

            PlayerLife.Text = $"HP: {player.CurrentLife} / {player.MaxLife}";
            MobLife.Text = $"HP: {mob.CurrentLife} / {mob.MaxLife}";

            ScoreViewer.Text = $"Score: {TotalScore}";

            ScoreViewer.Visible = true;
            Attack.Visible = true;
            PlayerLife.Visible = true;
            MobLife.Visible = true;

            Air.Visible = true;
            Fire.Visible = true;
            Earth.Visible = true;
            Water.Visible = true;

            Floor++;
        }

        private async void NewFloor()
        {
            Floor++;

            Level = Convert.ToInt32(Math.Floor(Floor / FloorsPrLevel));

            switch (Level)
            {
                case 0:
                    if(Floor % (FloorsPrLevel - 1) == 0)
                    {
                        mob = new BossSlime();
                        MobPicture.Image = Eksamens_projekt.Properties.Resources.Boss_Slime;
                    }
                    else
                    {
                        Random r1 = new Random();
                        SlimeType = r1.Next(1, 6);

                        switch (SlimeType)
                        {
                            case 1:
                                mob = new FireSlime();
                                MobPicture.Image = Eksamens_projekt.Properties.Resources.Fire_Slime;
                                break;
                            case 2:
                                mob = new WaterSlime();
                                MobPicture.Image = Eksamens_projekt.Properties.Resources.Water_Slime;
                                break;
                            case 3:
                                mob = new AirSlime();
                                MobPicture.Image = Eksamens_projekt.Properties.Resources.Air_Slime;
                                break;
                            case 4:
                                mob = new EarthSlime();
                                MobPicture.Image = Eksamens_projekt.Properties.Resources.Earth_Slime;
                                break;
                            default:
                                mob = new Slime();
                                MobPicture.Image = Eksamens_projekt.Properties.Resources.Basic_Slime;
                                break;
                        }
                    }

                    break;

                default:
                    if (Floor % (FloorsPrLevel - 1) == 0)
                    {
                        mob = new Armored_skeleton();
                        MobPicture.Image = Eksamens_projekt.Properties.Resources.Armored_skeleton;
                    }
                    else
                    {
                        Random r2 = new Random();
                        UndeadType = r2.Next(1, 5);

                        switch (UndeadType)
                        {
                            case 1:
                                mob = new Skeleton();
                                MobPicture.Image = Eksamens_projekt.Properties.Resources.Skeleton;
                                break;
                            case 2:
                                mob = new Vampire();
                                MobPicture.Image = Eksamens_projekt.Properties.Resources.Vampire;
                                break;
                            case 3:
                                mob = new Ghost();
                                MobPicture.Image = Eksamens_projekt.Properties.Resources.Ghost;
                                break;
                            default:
                                mob = new Zombie();
                                MobPicture.Image = Eksamens_projekt.Properties.Resources.Zombie;
                                break;
                        }
                    }


                    break;
            }

            player.CurrentLife = player.MaxLife;
            PlayerLife.Text = $"HP: {player.CurrentLife} / {player.MaxLife}";
            MobLife.Text = $"HP: {mob.CurrentLife} / {mob.MaxLife}";

            Turn_Images.Image = Properties.Resources.Your_turn;
            await Task.Delay(Delay);
            Turn_Images.Image = null;
            PlayerTurn = true;
        }

        private void Attack_Click(object sender, EventArgs e)
        {
            if (PlayerTurn == true)
            {
                PlayerTurn = false;
                mob.CurrentLife = mob.CurrentLife - player.Damage;
                MobLife.Text = $"HP: {mob.CurrentLife} / {mob.MaxLife}";

                MobTurn();
            }
        }

        private void Air_Click(object sender, EventArgs e)
        {
            if (PlayerTurn == true)
            {
                PlayerTurn = false;
                mob.CurrentLife = mob.CurrentLife - (player.Damage - (player.Damage * mob.AirResistance));
                MobLife.Text = $"HP: {mob.CurrentLife} / {mob.MaxLife}";

                MobTurn();
            }
            
        }

        private void Fire_Click(object sender, EventArgs e)
        {
            if (PlayerTurn == true)
            {
                PlayerTurn = false;
                mob.CurrentLife = mob.CurrentLife - (player.Damage - (player.Damage * mob.FireResistance));
                MobLife.Text = $"HP: {mob.CurrentLife} / {mob.MaxLife}";

                MobTurn();
            }
        }

        private void Earth_Click(object sender, EventArgs e)
        {
            if (PlayerTurn == true)
            {
                PlayerTurn = false;
                mob.CurrentLife = mob.CurrentLife - (player.Damage - (player.Damage * mob.EarthResistance));
                MobLife.Text = $"HP: {mob.CurrentLife} / {mob.MaxLife}";

                MobTurn();
            }
        }

        private void Water_Click(object sender, EventArgs e)
        {
            if (PlayerTurn == true)
            {
                PlayerTurn = false;
                mob.CurrentLife = mob.CurrentLife - (player.Damage - (player.Damage * mob.WaterResistance));
                MobLife.Text = $"HP: {mob.CurrentLife} / {mob.MaxLife}";

                MobTurn();
            }
        }

        public async void MobTurn()
        {
            if (mob.CurrentLife > 1)
            {
                Turn_Images.Image = Properties.Resources.Enemies_turn;
                await Task.Delay(Delay);
                Turn_Images.Image = null;

                player.CurrentLife = player.CurrentLife - mob.Damage;
                PlayerLife.Text = $"HP: {player.CurrentLife} / {player.MaxLife}";

                if (player.CurrentLife < 1)
                {
                    Turn_Images.Image = Properties.Resources.Game_Over;
                    await Task.Delay(Delay);
                    Turn_Images.Image = null;
                    Restart();
                }
                else
                {
                    Turn_Images.Image = Properties.Resources.Your_turn;
                    await Task.Delay(Delay);
                    Turn_Images.Image = null;
                    PlayerTurn = true;
                }
            }
            else
            {
                TotalScore = TotalScore + mob.Score;
                ScoreViewer.Text = $"Score: {TotalScore}";
                NewFloor();
            }
        }
    }
}
