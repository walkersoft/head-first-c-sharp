namespace DayAtTheRaces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.greyhoundBox1 = new System.Windows.Forms.PictureBox();
            this.greyhoundBox2 = new System.Windows.Forms.PictureBox();
            this.greyhoundBox3 = new System.Windows.Forms.PictureBox();
            this.greyhoundBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.raceStatus = new System.Windows.Forms.Label();
            this.joeButton = new System.Windows.Forms.RadioButton();
            this.alButton = new System.Windows.Forms.RadioButton();
            this.bobButton = new System.Windows.Forms.RadioButton();
            this.alBet = new System.Windows.Forms.Label();
            this.bobBet = new System.Windows.Forms.Label();
            this.joeBet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bettor = new System.Windows.Forms.Label();
            this.betAmount = new System.Windows.Forms.NumericUpDown();
            this.betGreyhound = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.placeBet = new System.Windows.Forms.Button();
            this.race = new System.Windows.Forms.Button();
            this.alCash = new System.Windows.Forms.Label();
            this.bobCash = new System.Windows.Forms.Label();
            this.joeCash = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betGreyhound)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // greyhoundBox1
            // 
            this.greyhoundBox1.Image = ((System.Drawing.Image)(resources.GetObject("greyhoundBox1.Image")));
            this.greyhoundBox1.Location = new System.Drawing.Point(20, 21);
            this.greyhoundBox1.Name = "greyhoundBox1";
            this.greyhoundBox1.Size = new System.Drawing.Size(75, 20);
            this.greyhoundBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.greyhoundBox1.TabIndex = 1;
            this.greyhoundBox1.TabStop = false;
            // 
            // greyhoundBox2
            // 
            this.greyhoundBox2.Image = ((System.Drawing.Image)(resources.GetObject("greyhoundBox2.Image")));
            this.greyhoundBox2.Location = new System.Drawing.Point(20, 71);
            this.greyhoundBox2.Name = "greyhoundBox2";
            this.greyhoundBox2.Size = new System.Drawing.Size(75, 20);
            this.greyhoundBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.greyhoundBox2.TabIndex = 2;
            this.greyhoundBox2.TabStop = false;
            // 
            // greyhoundBox3
            // 
            this.greyhoundBox3.Image = ((System.Drawing.Image)(resources.GetObject("greyhoundBox3.Image")));
            this.greyhoundBox3.Location = new System.Drawing.Point(20, 124);
            this.greyhoundBox3.Name = "greyhoundBox3";
            this.greyhoundBox3.Size = new System.Drawing.Size(75, 20);
            this.greyhoundBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.greyhoundBox3.TabIndex = 3;
            this.greyhoundBox3.TabStop = false;
            // 
            // greyhoundBox4
            // 
            this.greyhoundBox4.Image = ((System.Drawing.Image)(resources.GetObject("greyhoundBox4.Image")));
            this.greyhoundBox4.Location = new System.Drawing.Point(20, 178);
            this.greyhoundBox4.Name = "greyhoundBox4";
            this.greyhoundBox4.Size = new System.Drawing.Size(75, 20);
            this.greyhoundBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.greyhoundBox4.TabIndex = 4;
            this.greyhoundBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Betting Parlor (Minimum 5 / Maximum 25)";
            // 
            // raceStatus
            // 
            this.raceStatus.AutoSize = true;
            this.raceStatus.Location = new System.Drawing.Point(178, 231);
            this.raceStatus.Name = "raceStatus";
            this.raceStatus.Size = new System.Drawing.Size(158, 13);
            this.raceStatus.TabIndex = 6;
            this.raceStatus.Text = "Place your bets before the race!";
            // 
            // joeButton
            // 
            this.joeButton.AutoSize = true;
            this.joeButton.Checked = true;
            this.joeButton.Location = new System.Drawing.Point(12, 257);
            this.joeButton.Name = "joeButton";
            this.joeButton.Size = new System.Drawing.Size(42, 17);
            this.joeButton.TabIndex = 7;
            this.joeButton.TabStop = true;
            this.joeButton.Text = "Joe";
            this.joeButton.UseVisualStyleBackColor = true;
            this.joeButton.CheckedChanged += new System.EventHandler(this.joeButton_CheckedChanged);
            // 
            // alButton
            // 
            this.alButton.AutoSize = true;
            this.alButton.Location = new System.Drawing.Point(12, 303);
            this.alButton.Name = "alButton";
            this.alButton.Size = new System.Drawing.Size(34, 17);
            this.alButton.TabIndex = 8;
            this.alButton.Text = "Al";
            this.alButton.UseVisualStyleBackColor = true;
            this.alButton.CheckedChanged += new System.EventHandler(this.alButton_CheckedChanged);
            // 
            // bobButton
            // 
            this.bobButton.AutoSize = true;
            this.bobButton.Location = new System.Drawing.Point(12, 280);
            this.bobButton.Name = "bobButton";
            this.bobButton.Size = new System.Drawing.Size(44, 17);
            this.bobButton.TabIndex = 9;
            this.bobButton.Text = "Bob";
            this.bobButton.UseVisualStyleBackColor = true;
            this.bobButton.CheckedChanged += new System.EventHandler(this.bobButton_CheckedChanged);
            // 
            // alBet
            // 
            this.alBet.AutoSize = true;
            this.alBet.Location = new System.Drawing.Point(178, 305);
            this.alBet.Name = "alBet";
            this.alBet.Size = new System.Drawing.Size(119, 13);
            this.alBet.TabIndex = 10;
            this.alBet.Text = "Al has not placed a bet!";
            // 
            // bobBet
            // 
            this.bobBet.AutoSize = true;
            this.bobBet.Location = new System.Drawing.Point(178, 282);
            this.bobBet.Name = "bobBet";
            this.bobBet.Size = new System.Drawing.Size(129, 13);
            this.bobBet.TabIndex = 11;
            this.bobBet.Text = "Bob has not placed a bet!";
            // 
            // joeBet
            // 
            this.joeBet.AutoSize = true;
            this.joeBet.Location = new System.Drawing.Point(178, 259);
            this.joeBet.Name = "joeBet";
            this.joeBet.Size = new System.Drawing.Size(127, 13);
            this.joeBet.TabIndex = 12;
            this.joeBet.Text = "Joe has not placed a bet!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Players";
            // 
            // bettor
            // 
            this.bettor.AutoSize = true;
            this.bettor.Location = new System.Drawing.Point(9, 363);
            this.bettor.Name = "bettor";
            this.bettor.Size = new System.Drawing.Size(47, 13);
            this.bettor.TabIndex = 14;
            this.bettor.Text = "Joe bets";
            // 
            // betAmount
            // 
            this.betAmount.Location = new System.Drawing.Point(61, 361);
            this.betAmount.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.betAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betAmount.Name = "betAmount";
            this.betAmount.Size = new System.Drawing.Size(45, 20);
            this.betAmount.TabIndex = 15;
            this.betAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betGreyhound
            // 
            this.betGreyhound.Location = new System.Drawing.Point(228, 361);
            this.betGreyhound.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.betGreyhound.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.betGreyhound.Name = "betGreyhound";
            this.betGreyhound.Size = new System.Drawing.Size(45, 20);
            this.betGreyhound.TabIndex = 16;
            this.betGreyhound.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "on greyhound number";
            // 
            // placeBet
            // 
            this.placeBet.Location = new System.Drawing.Point(288, 361);
            this.placeBet.Name = "placeBet";
            this.placeBet.Size = new System.Drawing.Size(75, 20);
            this.placeBet.TabIndex = 18;
            this.placeBet.Text = "Place Bet";
            this.placeBet.UseVisualStyleBackColor = true;
            this.placeBet.Click += new System.EventHandler(this.placeBet_Click);
            // 
            // race
            // 
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.race.Location = new System.Drawing.Point(401, 257);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(187, 124);
            this.race.TabIndex = 19;
            this.race.Text = "RACE!!!";
            this.race.UseVisualStyleBackColor = true;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // alCash
            // 
            this.alCash.AutoSize = true;
            this.alCash.Location = new System.Drawing.Point(60, 305);
            this.alCash.Name = "alCash";
            this.alCash.Size = new System.Drawing.Size(35, 13);
            this.alCash.TabIndex = 20;
            this.alCash.Text = "label3";
            // 
            // bobCash
            // 
            this.bobCash.AutoSize = true;
            this.bobCash.Location = new System.Drawing.Point(60, 282);
            this.bobCash.Name = "bobCash";
            this.bobCash.Size = new System.Drawing.Size(35, 13);
            this.bobCash.TabIndex = 21;
            this.bobCash.Text = "label4";
            // 
            // joeCash
            // 
            this.joeCash.AutoSize = true;
            this.joeCash.Location = new System.Drawing.Point(60, 259);
            this.joeCash.Name = "joeCash";
            this.joeCash.Size = new System.Drawing.Size(35, 13);
            this.joeCash.TabIndex = 22;
            this.joeCash.Text = "label6";
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 410);
            this.Controls.Add(this.joeCash);
            this.Controls.Add(this.bobCash);
            this.Controls.Add(this.alCash);
            this.Controls.Add(this.race);
            this.Controls.Add(this.placeBet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.betGreyhound);
            this.Controls.Add(this.betAmount);
            this.Controls.Add(this.bettor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.joeBet);
            this.Controls.Add(this.bobBet);
            this.Controls.Add(this.alBet);
            this.Controls.Add(this.bobButton);
            this.Controls.Add(this.alButton);
            this.Controls.Add(this.joeButton);
            this.Controls.Add(this.raceStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.greyhoundBox4);
            this.Controls.Add(this.greyhoundBox3);
            this.Controls.Add(this.greyhoundBox2);
            this.Controls.Add(this.greyhoundBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = " A Day At The Races";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyhoundBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betGreyhound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox greyhoundBox1;
        private System.Windows.Forms.PictureBox greyhoundBox2;
        private System.Windows.Forms.PictureBox greyhoundBox3;
        private System.Windows.Forms.PictureBox greyhoundBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label raceStatus;
        private System.Windows.Forms.RadioButton joeButton;
        private System.Windows.Forms.RadioButton alButton;
        private System.Windows.Forms.RadioButton bobButton;
        private System.Windows.Forms.Label alBet;
        private System.Windows.Forms.Label bobBet;
        private System.Windows.Forms.Label joeBet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bettor;
        private System.Windows.Forms.NumericUpDown betAmount;
        private System.Windows.Forms.NumericUpDown betGreyhound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button placeBet;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.Label alCash;
        private System.Windows.Forms.Label bobCash;
        private System.Windows.Forms.Label joeCash;
        private System.Windows.Forms.Timer timer1;
    }
}

