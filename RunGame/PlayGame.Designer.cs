﻿namespace RunGame
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
            this.components = new System.ComponentModel.Container();
            this.RobertRadBtn = new System.Windows.Forms.RadioButton();
            this.SamuelRadBtn = new System.Windows.Forms.RadioButton();
            this.GeorgeRadBtn = new System.Windows.Forms.RadioButton();
            this.RobertSituation = new System.Windows.Forms.Label();
            this.SamuelSituation = new System.Windows.Forms.Label();
            this.GeorgeSituation = new System.Windows.Forms.Label();
            this.Jerry = new System.Windows.Forms.PictureBox();
            this.Tom = new System.Windows.Forms.PictureBox();
            this.Turtle = new System.Windows.Forms.PictureBox();
            this.Rabbit = new System.Windows.Forms.PictureBox();
            this.StartRace = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.BetAmount = new System.Windows.Forms.NumericUpDown();
            this.ContestantName = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.BetBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.RobertCash = new System.Windows.Forms.TextBox();
            this.SamuelCash = new System.Windows.Forms.TextBox();
            this.GeorgeCash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Jerry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Turtle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rabbit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContestantName)).BeginInit();
            this.SuspendLayout();
            // 
            // RobertRadBtn
            // 
            this.RobertRadBtn.AutoSize = true;
            this.RobertRadBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RobertRadBtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RobertRadBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.RobertRadBtn.Location = new System.Drawing.Point(679, 602);
            this.RobertRadBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RobertRadBtn.Name = "RobertRadBtn";
            this.RobertRadBtn.Size = new System.Drawing.Size(96, 32);
            this.RobertRadBtn.TabIndex = 4;
            this.RobertRadBtn.TabStop = true;
            this.RobertRadBtn.Text = "Robert";
            this.RobertRadBtn.UseVisualStyleBackColor = false;
            this.RobertRadBtn.CheckedChanged += new System.EventHandler(this.RobertRadBtn_CheckedChanged);
            // 
            // SamuelRadBtn
            // 
            this.SamuelRadBtn.AutoSize = true;
            this.SamuelRadBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SamuelRadBtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SamuelRadBtn.ForeColor = System.Drawing.Color.Green;
            this.SamuelRadBtn.Location = new System.Drawing.Point(679, 641);
            this.SamuelRadBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SamuelRadBtn.Name = "SamuelRadBtn";
            this.SamuelRadBtn.Size = new System.Drawing.Size(100, 32);
            this.SamuelRadBtn.TabIndex = 5;
            this.SamuelRadBtn.TabStop = true;
            this.SamuelRadBtn.Text = "Samuel";
            this.SamuelRadBtn.UseVisualStyleBackColor = false;
            this.SamuelRadBtn.CheckedChanged += new System.EventHandler(this.SamuelRadBtn_CheckedChanged);
            // 
            // GeorgeRadBtn
            // 
            this.GeorgeRadBtn.AutoSize = true;
            this.GeorgeRadBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.GeorgeRadBtn.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeorgeRadBtn.ForeColor = System.Drawing.Color.Red;
            this.GeorgeRadBtn.Location = new System.Drawing.Point(681, 681);
            this.GeorgeRadBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GeorgeRadBtn.Name = "GeorgeRadBtn";
            this.GeorgeRadBtn.Size = new System.Drawing.Size(97, 32);
            this.GeorgeRadBtn.TabIndex = 6;
            this.GeorgeRadBtn.TabStop = true;
            this.GeorgeRadBtn.Text = "George";
            this.GeorgeRadBtn.UseVisualStyleBackColor = false;
            this.GeorgeRadBtn.CheckedChanged += new System.EventHandler(this.GeorgeRadBtn_CheckedChanged);
            // 
            // RobertSituation
            // 
            this.RobertSituation.AutoSize = true;
            this.RobertSituation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RobertSituation.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RobertSituation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.RobertSituation.Location = new System.Drawing.Point(23, 604);
            this.RobertSituation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RobertSituation.Name = "RobertSituation";
            this.RobertSituation.Size = new System.Drawing.Size(243, 25);
            this.RobertSituation.TabIndex = 7;
            this.RobertSituation.Text = "Robert haven`t bet yet";
            // 
            // SamuelSituation
            // 
            this.SamuelSituation.AutoSize = true;
            this.SamuelSituation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SamuelSituation.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SamuelSituation.ForeColor = System.Drawing.Color.Green;
            this.SamuelSituation.Location = new System.Drawing.Point(21, 644);
            this.SamuelSituation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SamuelSituation.Name = "SamuelSituation";
            this.SamuelSituation.Size = new System.Drawing.Size(251, 25);
            this.SamuelSituation.TabIndex = 8;
            this.SamuelSituation.Text = "Samuel haven`t bet yet";
            // 
            // GeorgeSituation
            // 
            this.GeorgeSituation.AutoSize = true;
            this.GeorgeSituation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GeorgeSituation.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GeorgeSituation.ForeColor = System.Drawing.Color.Red;
            this.GeorgeSituation.Location = new System.Drawing.Point(21, 683);
            this.GeorgeSituation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GeorgeSituation.Name = "GeorgeSituation";
            this.GeorgeSituation.Size = new System.Drawing.Size(244, 25);
            this.GeorgeSituation.TabIndex = 9;
            this.GeorgeSituation.Text = "George haven`t bet yet";
            // 
            // Jerry
            // 
            this.Jerry.Image = global::RunGame.Resource1.Jerry;
            this.Jerry.Location = new System.Drawing.Point(4, 468);
            this.Jerry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Jerry.Name = "Jerry";
            this.Jerry.Size = new System.Drawing.Size(101, 58);
            this.Jerry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Jerry.TabIndex = 3;
            this.Jerry.TabStop = false;
            // 
            // Tom
            // 
            this.Tom.Image = global::RunGame.Resource1.Tom;
            this.Tom.Location = new System.Drawing.Point(4, 349);
            this.Tom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tom.Name = "Tom";
            this.Tom.Size = new System.Drawing.Size(100, 76);
            this.Tom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tom.TabIndex = 2;
            this.Tom.TabStop = false;
            // 
            // Turtle
            // 
            this.Turtle.Image = global::RunGame.Resource1.Turtle;
            this.Turtle.Location = new System.Drawing.Point(5, 223);
            this.Turtle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Turtle.Name = "Turtle";
            this.Turtle.Size = new System.Drawing.Size(100, 90);
            this.Turtle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Turtle.TabIndex = 1;
            this.Turtle.TabStop = false;
            // 
            // Rabbit
            // 
            this.Rabbit.Image = global::RunGame.Resource1.Rabbit;
            this.Rabbit.Location = new System.Drawing.Point(3, 91);
            this.Rabbit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rabbit.Name = "Rabbit";
            this.Rabbit.Size = new System.Drawing.Size(101, 90);
            this.Rabbit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Rabbit.TabIndex = 0;
            this.Rabbit.TabStop = false;
            // 
            // StartRace
            // 
            this.StartRace.BackColor = System.Drawing.SystemColors.ControlLight;
            this.StartRace.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartRace.ForeColor = System.Drawing.Color.Lime;
            this.StartRace.Location = new System.Drawing.Point(1025, 602);
            this.StartRace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StartRace.Name = "StartRace";
            this.StartRace.Size = new System.Drawing.Size(168, 50);
            this.StartRace.TabIndex = 10;
            this.StartRace.Text = "Start Race";
            this.StartRace.UseVisualStyleBackColor = false;
            this.StartRace.Click += new System.EventHandler(this.StartRace_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Exit.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.Red;
            this.Exit.Location = new System.Drawing.Point(808, 607);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 39);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // BetAmount
            // 
            this.BetAmount.Location = new System.Drawing.Point(1024, 694);
            this.BetAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BetAmount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.BetAmount.Name = "BetAmount";
            this.BetAmount.Size = new System.Drawing.Size(160, 22);
            this.BetAmount.TabIndex = 12;
            // 
            // ContestantName
            // 
            this.ContestantName.Location = new System.Drawing.Point(1024, 667);
            this.ContestantName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContestantName.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ContestantName.Name = "ContestantName";
            this.ContestantName.Size = new System.Drawing.Size(160, 22);
            this.ContestantName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(897, 694);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Bet Amount";
            // 
            // BetBtn
            // 
            this.BetBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BetBtn.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BetBtn.ForeColor = System.Drawing.Color.Red;
            this.BetBtn.Location = new System.Drawing.Point(916, 602);
            this.BetBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BetBtn.Name = "BetBtn";
            this.BetBtn.Size = new System.Drawing.Size(101, 50);
            this.BetBtn.TabIndex = 16;
            this.BetBtn.Text = "BET";
            this.BetBtn.UseVisualStyleBackColor = false;
            this.BetBtn.Click += new System.EventHandler(this.BetBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(912, 667);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Contestant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(445, -4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 56);
            this.label3.TabIndex = 18;
            this.label3.Text = "RACE";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RobertCash
            // 
            this.RobertCash.Enabled = false;
            this.RobertCash.Location = new System.Drawing.Point(512, 608);
            this.RobertCash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RobertCash.Name = "RobertCash";
            this.RobertCash.Size = new System.Drawing.Size(132, 22);
            this.RobertCash.TabIndex = 21;
            this.RobertCash.Text = "$50";
            // 
            // SamuelCash
            // 
            this.SamuelCash.Enabled = false;
            this.SamuelCash.Location = new System.Drawing.Point(512, 647);
            this.SamuelCash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SamuelCash.Name = "SamuelCash";
            this.SamuelCash.Size = new System.Drawing.Size(132, 22);
            this.SamuelCash.TabIndex = 22;
            this.SamuelCash.Text = "$50";
            // 
            // GeorgeCash
            // 
            this.GeorgeCash.Enabled = false;
            this.GeorgeCash.Location = new System.Drawing.Point(512, 687);
            this.GeorgeCash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GeorgeCash.Name = "GeorgeCash";
            this.GeorgeCash.Size = new System.Drawing.Size(132, 22);
            this.GeorgeCash.TabIndex = 23;
            this.GeorgeCash.Text = "$50";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(481, 571);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 22);
            this.label4.TabIndex = 24;
            this.label4.Text = "Amount Remained";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1239, 727);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GeorgeCash);
            this.Controls.Add(this.SamuelCash);
            this.Controls.Add(this.RobertCash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BetBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ContestantName);
            this.Controls.Add(this.BetAmount);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.StartRace);
            this.Controls.Add(this.GeorgeSituation);
            this.Controls.Add(this.SamuelSituation);
            this.Controls.Add(this.RobertSituation);
            this.Controls.Add(this.GeorgeRadBtn);
            this.Controls.Add(this.SamuelRadBtn);
            this.Controls.Add(this.RobertRadBtn);
            this.Controls.Add(this.Jerry);
            this.Controls.Add(this.Tom);
            this.Controls.Add(this.Turtle);
            this.Controls.Add(this.Rabbit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Jerry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Turtle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rabbit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContestantName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Rabbit;
        private System.Windows.Forms.PictureBox Turtle;
        private System.Windows.Forms.PictureBox Tom;
        private System.Windows.Forms.PictureBox Jerry;
        private System.Windows.Forms.RadioButton RobertRadBtn;
        private System.Windows.Forms.RadioButton SamuelRadBtn;
        private System.Windows.Forms.RadioButton GeorgeRadBtn;
        private System.Windows.Forms.Label RobertSituation;
        private System.Windows.Forms.Label SamuelSituation;
        private System.Windows.Forms.Label GeorgeSituation;
        private System.Windows.Forms.Button StartRace;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.NumericUpDown BetAmount;
        private System.Windows.Forms.NumericUpDown ContestantName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BetBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox RobertCash;
        private System.Windows.Forms.TextBox SamuelCash;
        private System.Windows.Forms.TextBox GeorgeCash;
        private System.Windows.Forms.Label label4;
    }
}

