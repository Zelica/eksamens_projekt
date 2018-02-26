namespace Eksamens_projekt
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Start = new System.Windows.Forms.Button();
            this.Highscore = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.Player_Life = new System.Windows.Forms.Label();
            this.Mob_Life = new System.Windows.Forms.Label();
            this.Attack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(896, 640);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // Player_Life
            // 
            this.Player_Life.AutoSize = true;
            this.Player_Life.BackColor = System.Drawing.Color.White;
            this.Player_Life.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Player_Life.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player_Life.Location = new System.Drawing.Point(164, 160);
            this.Player_Life.Name = "Player_Life";
            this.Player_Life.Size = new System.Drawing.Size(149, 56);
            this.Player_Life.TabIndex = 4;
            this.Player_Life.Text = "label1";
            // 
            // Mob_Life
            // 
            this.Mob_Life.AutoSize = true;
            this.Mob_Life.BackColor = System.Drawing.Color.White;
            this.Mob_Life.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Mob_Life.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mob_Life.Location = new System.Drawing.Point(676, 160);
            this.Mob_Life.Name = "Mob_Life";
            this.Mob_Life.Size = new System.Drawing.Size(149, 56);
            this.Mob_Life.TabIndex = 5;
            this.Mob_Life.Text = "label2";
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
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1457, 1029);
            this.Controls.Add(this.Attack);
            this.Controls.Add(this.Mob_Life);
            this.Controls.Add(this.Player_Life);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.Highscore);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Highscore;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Label Player_Life;
        private System.Windows.Forms.Label Mob_Life;
        private System.Windows.Forms.Button Attack;
    }
}

