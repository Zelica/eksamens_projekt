﻿namespace Eksamens_projekt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Background = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.Highscore = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.PlayerLife = new System.Windows.Forms.Label();
            this.MobLife = new System.Windows.Forms.Label();
            this.Attack = new System.Windows.Forms.Button();
            this.MobPicture = new System.Windows.Forms.PictureBox();
            this.PlayerPicture = new System.Windows.Forms.PictureBox();
            this.ScoreViewer = new System.Windows.Forms.Label();
            this.Air = new System.Windows.Forms.Button();
            this.Fire = new System.Windows.Forms.Button();
            this.Earth = new System.Windows.Forms.Button();
            this.Water = new System.Windows.Forms.Button();
<<<<<<< HEAD
            this.Turn_Images = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mob_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Turn_Images)).BeginInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.Background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicture)).BeginInit();
>>>>>>> Navngivning
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(896, 640);
            this.Background.TabIndex = 0;
            this.Background.TabStop = false;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Location = new System.Drawing.Point(692, 52);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(152, 48);
            this.Start.TabIndex = 1;
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Highscore
            // 
            this.Highscore.BackColor = System.Drawing.Color.Transparent;
            this.Highscore.FlatAppearance.BorderSize = 0;
            this.Highscore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Highscore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Highscore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Highscore.Location = new System.Drawing.Point(692, 120);
            this.Highscore.Name = "Highscore";
            this.Highscore.Size = new System.Drawing.Size(152, 48);
            this.Highscore.TabIndex = 2;
            this.Highscore.UseVisualStyleBackColor = true;
            this.Highscore.Click += new System.EventHandler(this.Highscore_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.FlatAppearance.BorderSize = 0;
            this.Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Location = new System.Drawing.Point(692, 188);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(152, 48);
            this.Settings.TabIndex = 3;
            this.Settings.UseVisualStyleBackColor = true;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // PlayerLife
            // 
<<<<<<< HEAD
            this.Player_Life.AutoSize = true;
            this.Player_Life.BackColor = System.Drawing.Color.White;
            this.Player_Life.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player_Life.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Life.Location = new System.Drawing.Point(143, 160);
            this.Player_Life.Name = "Player_Life";
            this.Player_Life.Size = new System.Drawing.Size(62, 26);
            this.Player_Life.TabIndex = 4;
            this.Player_Life.Text = "label1";
=======
            this.PlayerLife.AutoSize = true;
            this.PlayerLife.BackColor = System.Drawing.Color.White;
            this.PlayerLife.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLife.Location = new System.Drawing.Point(143, 160);
            this.PlayerLife.Name = "PlayerLife";
            this.PlayerLife.Size = new System.Drawing.Size(149, 56);
            this.PlayerLife.TabIndex = 4;
            this.PlayerLife.Text = "label1";
>>>>>>> Navngivning
            // 
            // MobLife
            // 
<<<<<<< HEAD
            this.Mob_Life.AutoSize = true;
            this.Mob_Life.BackColor = System.Drawing.Color.White;
            this.Mob_Life.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mob_Life.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mob_Life.Location = new System.Drawing.Point(655, 160);
            this.Mob_Life.Name = "Mob_Life";
            this.Mob_Life.Size = new System.Drawing.Size(62, 26);
            this.Mob_Life.TabIndex = 5;
            this.Mob_Life.Text = "label2";
            this.Mob_Life.TextAlign = System.Drawing.ContentAlignment.TopRight;
=======
            this.MobLife.AutoSize = true;
            this.MobLife.BackColor = System.Drawing.Color.White;
            this.MobLife.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MobLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobLife.Location = new System.Drawing.Point(655, 160);
            this.MobLife.Name = "MobLife";
            this.MobLife.Size = new System.Drawing.Size(149, 56);
            this.MobLife.TabIndex = 5;
            this.MobLife.Text = "label2";
            this.MobLife.TextAlign = System.Drawing.ContentAlignment.TopRight;
>>>>>>> Navngivning
            // 
            // Attack
            // 
            this.Attack.BackColor = System.Drawing.Color.White;
            this.Attack.FlatAppearance.BorderSize = 0;
            this.Attack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attack.Location = new System.Drawing.Point(92, 533);
            this.Attack.Name = "Attack";
            this.Attack.Size = new System.Drawing.Size(165, 78);
            this.Attack.TabIndex = 6;
            this.Attack.Text = "Attack";
            this.Attack.UseVisualStyleBackColor = false;
            this.Attack.Click += new System.EventHandler(this.Attack_Click);
            // 
            // MobPicture
            // 
            this.MobPicture.BackColor = System.Drawing.Color.Transparent;
            this.MobPicture.Location = new System.Drawing.Point(565, 188);
            this.MobPicture.Name = "MobPicture";
            this.MobPicture.Size = new System.Drawing.Size(256, 256);
            this.MobPicture.TabIndex = 7;
            this.MobPicture.TabStop = false;
            // 
            // PlayerPicture
            // 
            this.PlayerPicture.BackColor = System.Drawing.Color.Transparent;
            this.PlayerPicture.Location = new System.Drawing.Point(75, 188);
            this.PlayerPicture.Name = "PlayerPicture";
            this.PlayerPicture.Size = new System.Drawing.Size(256, 256);
            this.PlayerPicture.TabIndex = 8;
            this.PlayerPicture.TabStop = false;
            // 
            // ScoreViewer
            // 
<<<<<<< HEAD
            this.Score_viewer.AutoSize = true;
            this.Score_viewer.BackColor = System.Drawing.Color.White;
            this.Score_viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Score_viewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_viewer.Location = new System.Drawing.Point(20, 20);
            this.Score_viewer.Name = "Score_viewer";
            this.Score_viewer.Size = new System.Drawing.Size(53, 22);
            this.Score_viewer.TabIndex = 9;
            this.Score_viewer.Text = "label1";
=======
            this.ScoreViewer.AutoSize = true;
            this.ScoreViewer.BackColor = System.Drawing.Color.White;
            this.ScoreViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScoreViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreViewer.Location = new System.Drawing.Point(20, 20);
            this.ScoreViewer.Name = "ScoreViewer";
            this.ScoreViewer.Size = new System.Drawing.Size(128, 48);
            this.ScoreViewer.TabIndex = 9;
            this.ScoreViewer.Text = "label1";
>>>>>>> Navngivning
            // 
            // Air
            // 
            this.Air.BackColor = System.Drawing.Color.White;
            this.Air.FlatAppearance.BorderSize = 0;
            this.Air.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Air.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Air.Location = new System.Drawing.Point(290, 533);
            this.Air.Name = "Air";
            this.Air.Size = new System.Drawing.Size(80, 37);
            this.Air.TabIndex = 10;
            this.Air.Text = "Air";
            this.Air.UseVisualStyleBackColor = false;
            this.Air.Click += new System.EventHandler(this.Air_Click);
            // 
            // Fire
            // 
            this.Fire.BackColor = System.Drawing.Color.White;
            this.Fire.FlatAppearance.BorderSize = 0;
            this.Fire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fire.Location = new System.Drawing.Point(375, 533);
            this.Fire.Name = "Fire";
            this.Fire.Size = new System.Drawing.Size(80, 37);
            this.Fire.TabIndex = 11;
            this.Fire.Text = "Fire";
            this.Fire.UseVisualStyleBackColor = false;
            this.Fire.Click += new System.EventHandler(this.Fire_Click);
            // 
            // Earth
            // 
            this.Earth.BackColor = System.Drawing.Color.White;
            this.Earth.FlatAppearance.BorderSize = 0;
            this.Earth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Earth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Earth.Location = new System.Drawing.Point(290, 574);
            this.Earth.Name = "Earth";
            this.Earth.Size = new System.Drawing.Size(80, 37);
            this.Earth.TabIndex = 12;
            this.Earth.Text = "Earth";
            this.Earth.UseVisualStyleBackColor = false;
            this.Earth.Click += new System.EventHandler(this.Earth_Click);
            // 
            // Water
            // 
            this.Water.BackColor = System.Drawing.Color.White;
            this.Water.FlatAppearance.BorderSize = 0;
            this.Water.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Water.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Water.Location = new System.Drawing.Point(375, 574);
            this.Water.Name = "Water";
            this.Water.Size = new System.Drawing.Size(80, 37);
            this.Water.TabIndex = 13;
            this.Water.Text = "Water";
            this.Water.UseVisualStyleBackColor = false;
            this.Water.Click += new System.EventHandler(this.Water_Click);
            // 
            // Turn_Images
            // 
            this.Turn_Images.BackColor = System.Drawing.Color.Transparent;
            this.Turn_Images.Location = new System.Drawing.Point(0, 0);
            this.Turn_Images.Name = "Turn_Images";
            this.Turn_Images.Size = new System.Drawing.Size(896, 640);
            this.Turn_Images.TabIndex = 14;
            this.Turn_Images.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1457, 1029);
            this.Controls.Add(this.Turn_Images);
            this.Controls.Add(this.Water);
            this.Controls.Add(this.Earth);
            this.Controls.Add(this.Fire);
            this.Controls.Add(this.Air);
            this.Controls.Add(this.ScoreViewer);
            this.Controls.Add(this.PlayerPicture);
            this.Controls.Add(this.MobPicture);
            this.Controls.Add(this.Attack);
            this.Controls.Add(this.MobLife);
            this.Controls.Add(this.PlayerLife);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Highscore);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Background);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
<<<<<<< HEAD
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mob_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Turn_Images)).EndInit();
=======
            ((System.ComponentModel.ISupportInitialize)(this.Background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MobPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPicture)).EndInit();
>>>>>>> Navngivning
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Background;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Highscore;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Label PlayerLife;
        private System.Windows.Forms.Label MobLife;
        private System.Windows.Forms.Button Attack;
        private System.Windows.Forms.PictureBox MobPicture;
        private System.Windows.Forms.PictureBox PlayerPicture;
        private System.Windows.Forms.Label ScoreViewer;
        private System.Windows.Forms.Button Air;
        private System.Windows.Forms.Button Fire;
        private System.Windows.Forms.Button Earth;
        private System.Windows.Forms.Button Water;
        private System.Windows.Forms.PictureBox Turn_Images;
    }
}

