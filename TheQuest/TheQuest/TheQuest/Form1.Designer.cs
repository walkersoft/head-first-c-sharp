namespace TheQuest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playerIcon = new System.Windows.Forms.PictureBox();
            this.weaponSword = new System.Windows.Forms.PictureBox();
            this.moveButtons = new System.Windows.Forms.GroupBox();
            this.moveRight = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            this.moveUp = new System.Windows.Forms.Button();
            this.moveLeft = new System.Windows.Forms.Button();
            this.attackButtons = new System.Windows.Forms.GroupBox();
            this.attackRight = new System.Windows.Forms.Button();
            this.attackDown = new System.Windows.Forms.Button();
            this.attackUp = new System.Windows.Forms.Button();
            this.attackLeft = new System.Windows.Forms.Button();
            this.weaponBow = new System.Windows.Forms.PictureBox();
            this.weaponMace = new System.Windows.Forms.PictureBox();
            this.weaponBluePotion = new System.Windows.Forms.PictureBox();
            this.weaponRedPotion = new System.Windows.Forms.PictureBox();
            this.batIcon = new System.Windows.Forms.PictureBox();
            this.ghostIcon = new System.Windows.Forms.PictureBox();
            this.ghoulIcon = new System.Windows.Forms.PictureBox();
            this.bluePotionIcon = new System.Windows.Forms.PictureBox();
            this.redPotionIcon = new System.Windows.Forms.PictureBox();
            this.swordIcon = new System.Windows.Forms.PictureBox();
            this.bowIcon = new System.Windows.Forms.PictureBox();
            this.maceIcon = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.playerLabel = new System.Windows.Forms.Label();
            this.playerHP = new System.Windows.Forms.Label();
            this.batLabel = new System.Windows.Forms.Label();
            this.batHP = new System.Windows.Forms.Label();
            this.ghostLabel = new System.Windows.Forms.Label();
            this.ghostHP = new System.Windows.Forms.Label();
            this.ghoulLabel = new System.Windows.Forms.Label();
            this.ghoulHP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponSword)).BeginInit();
            this.moveButtons.SuspendLayout();
            this.attackButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponMace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBluePotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponRedPotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoulIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceIcon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerIcon
            // 
            this.playerIcon.BackColor = System.Drawing.Color.Transparent;
            this.playerIcon.Image = ((System.Drawing.Image)(resources.GetObject("playerIcon.Image")));
            this.playerIcon.Location = new System.Drawing.Point(120, 92);
            this.playerIcon.Name = "playerIcon";
            this.playerIcon.Size = new System.Drawing.Size(50, 50);
            this.playerIcon.TabIndex = 0;
            this.playerIcon.TabStop = false;
            this.playerIcon.Visible = false;
            // 
            // weaponSword
            // 
            this.weaponSword.BackColor = System.Drawing.Color.Transparent;
            this.weaponSword.BackgroundImage = global::TheQuest.Properties.Resources.sword;
            this.weaponSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weaponSword.Location = new System.Drawing.Point(108, 477);
            this.weaponSword.Name = "weaponSword";
            this.weaponSword.Size = new System.Drawing.Size(75, 75);
            this.weaponSword.TabIndex = 1;
            this.weaponSword.TabStop = false;
            this.weaponSword.Visible = false;
            this.weaponSword.Click += new System.EventHandler(this.weaponSword_Click);
            // 
            // moveButtons
            // 
            this.moveButtons.BackColor = System.Drawing.Color.Transparent;
            this.moveButtons.Controls.Add(this.moveRight);
            this.moveButtons.Controls.Add(this.moveDown);
            this.moveButtons.Controls.Add(this.moveUp);
            this.moveButtons.Controls.Add(this.moveLeft);
            this.moveButtons.Location = new System.Drawing.Point(533, 467);
            this.moveButtons.Name = "moveButtons";
            this.moveButtons.Size = new System.Drawing.Size(115, 93);
            this.moveButtons.TabIndex = 2;
            this.moveButtons.TabStop = false;
            this.moveButtons.Text = "Move";
            // 
            // moveRight
            // 
            this.moveRight.Location = new System.Drawing.Point(78, 38);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(30, 30);
            this.moveRight.TabIndex = 3;
            this.moveRight.Text = "→";
            this.moveRight.UseVisualStyleBackColor = true;
            this.moveRight.Click += new System.EventHandler(this.moveRight_Click);
            // 
            // moveDown
            // 
            this.moveDown.Location = new System.Drawing.Point(42, 55);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(30, 30);
            this.moveDown.TabIndex = 2;
            this.moveDown.Text = "↓";
            this.moveDown.UseVisualStyleBackColor = true;
            this.moveDown.Click += new System.EventHandler(this.moveDown_Click);
            // 
            // moveUp
            // 
            this.moveUp.Location = new System.Drawing.Point(42, 19);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(30, 30);
            this.moveUp.TabIndex = 1;
            this.moveUp.Text = "↑";
            this.moveUp.UseVisualStyleBackColor = true;
            this.moveUp.Click += new System.EventHandler(this.moveUp_Click);
            // 
            // moveLeft
            // 
            this.moveLeft.Location = new System.Drawing.Point(6, 38);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(30, 30);
            this.moveLeft.TabIndex = 0;
            this.moveLeft.Text = "←";
            this.moveLeft.UseVisualStyleBackColor = true;
            this.moveLeft.Click += new System.EventHandler(this.moveLeft_Click);
            // 
            // attackButtons
            // 
            this.attackButtons.BackColor = System.Drawing.Color.Transparent;
            this.attackButtons.Controls.Add(this.attackRight);
            this.attackButtons.Controls.Add(this.attackDown);
            this.attackButtons.Controls.Add(this.attackUp);
            this.attackButtons.Controls.Add(this.attackLeft);
            this.attackButtons.Location = new System.Drawing.Point(671, 467);
            this.attackButtons.Name = "attackButtons";
            this.attackButtons.Size = new System.Drawing.Size(115, 93);
            this.attackButtons.TabIndex = 4;
            this.attackButtons.TabStop = false;
            this.attackButtons.Text = "Attack";
            // 
            // attackRight
            // 
            this.attackRight.Location = new System.Drawing.Point(78, 38);
            this.attackRight.Name = "attackRight";
            this.attackRight.Size = new System.Drawing.Size(30, 30);
            this.attackRight.TabIndex = 3;
            this.attackRight.Text = "→";
            this.attackRight.UseVisualStyleBackColor = true;
            this.attackRight.Click += new System.EventHandler(this.attackRight_Click);
            // 
            // attackDown
            // 
            this.attackDown.Location = new System.Drawing.Point(42, 55);
            this.attackDown.Name = "attackDown";
            this.attackDown.Size = new System.Drawing.Size(30, 30);
            this.attackDown.TabIndex = 2;
            this.attackDown.Text = "↓";
            this.attackDown.UseVisualStyleBackColor = true;
            this.attackDown.Click += new System.EventHandler(this.attackDown_Click);
            // 
            // attackUp
            // 
            this.attackUp.Location = new System.Drawing.Point(42, 19);
            this.attackUp.Name = "attackUp";
            this.attackUp.Size = new System.Drawing.Size(30, 30);
            this.attackUp.TabIndex = 1;
            this.attackUp.Text = "↑";
            this.attackUp.UseVisualStyleBackColor = true;
            this.attackUp.Click += new System.EventHandler(this.attackUp_Click);
            // 
            // attackLeft
            // 
            this.attackLeft.Location = new System.Drawing.Point(6, 38);
            this.attackLeft.Name = "attackLeft";
            this.attackLeft.Size = new System.Drawing.Size(30, 30);
            this.attackLeft.TabIndex = 0;
            this.attackLeft.Text = "←";
            this.attackLeft.UseVisualStyleBackColor = true;
            this.attackLeft.Click += new System.EventHandler(this.attackLeft_Click);
            // 
            // weaponBow
            // 
            this.weaponBow.BackColor = System.Drawing.Color.Transparent;
            this.weaponBow.BackgroundImage = global::TheQuest.Properties.Resources.bow;
            this.weaponBow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weaponBow.Location = new System.Drawing.Point(189, 477);
            this.weaponBow.Name = "weaponBow";
            this.weaponBow.Size = new System.Drawing.Size(75, 75);
            this.weaponBow.TabIndex = 5;
            this.weaponBow.TabStop = false;
            this.weaponBow.Visible = false;
            this.weaponBow.Click += new System.EventHandler(this.weaponBow_Click);
            // 
            // weaponMace
            // 
            this.weaponMace.BackColor = System.Drawing.Color.Transparent;
            this.weaponMace.BackgroundImage = global::TheQuest.Properties.Resources.mace;
            this.weaponMace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weaponMace.Location = new System.Drawing.Point(271, 477);
            this.weaponMace.Name = "weaponMace";
            this.weaponMace.Size = new System.Drawing.Size(75, 75);
            this.weaponMace.TabIndex = 6;
            this.weaponMace.TabStop = false;
            this.weaponMace.Visible = false;
            this.weaponMace.Click += new System.EventHandler(this.weaponMace_Click);
            // 
            // weaponBluePotion
            // 
            this.weaponBluePotion.BackColor = System.Drawing.Color.Transparent;
            this.weaponBluePotion.BackgroundImage = global::TheQuest.Properties.Resources.potion_blue;
            this.weaponBluePotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weaponBluePotion.Location = new System.Drawing.Point(351, 477);
            this.weaponBluePotion.Name = "weaponBluePotion";
            this.weaponBluePotion.Size = new System.Drawing.Size(75, 75);
            this.weaponBluePotion.TabIndex = 7;
            this.weaponBluePotion.TabStop = false;
            this.weaponBluePotion.Visible = false;
            this.weaponBluePotion.Click += new System.EventHandler(this.weaponBluePotion_Click);
            // 
            // weaponRedPotion
            // 
            this.weaponRedPotion.BackColor = System.Drawing.Color.Transparent;
            this.weaponRedPotion.BackgroundImage = global::TheQuest.Properties.Resources.potion_red;
            this.weaponRedPotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.weaponRedPotion.Location = new System.Drawing.Point(432, 477);
            this.weaponRedPotion.Name = "weaponRedPotion";
            this.weaponRedPotion.Size = new System.Drawing.Size(75, 75);
            this.weaponRedPotion.TabIndex = 8;
            this.weaponRedPotion.TabStop = false;
            this.weaponRedPotion.Visible = false;
            this.weaponRedPotion.Click += new System.EventHandler(this.weaponRedPotion_Click);
            // 
            // batIcon
            // 
            this.batIcon.BackColor = System.Drawing.Color.Transparent;
            this.batIcon.Image = ((System.Drawing.Image)(resources.GetObject("batIcon.Image")));
            this.batIcon.Location = new System.Drawing.Point(176, 92);
            this.batIcon.Name = "batIcon";
            this.batIcon.Size = new System.Drawing.Size(50, 50);
            this.batIcon.TabIndex = 9;
            this.batIcon.TabStop = false;
            this.batIcon.Visible = false;
            // 
            // ghostIcon
            // 
            this.ghostIcon.BackColor = System.Drawing.Color.Transparent;
            this.ghostIcon.Image = ((System.Drawing.Image)(resources.GetObject("ghostIcon.Image")));
            this.ghostIcon.Location = new System.Drawing.Point(232, 92);
            this.ghostIcon.Name = "ghostIcon";
            this.ghostIcon.Size = new System.Drawing.Size(50, 50);
            this.ghostIcon.TabIndex = 10;
            this.ghostIcon.TabStop = false;
            this.ghostIcon.Visible = false;
            // 
            // ghoulIcon
            // 
            this.ghoulIcon.BackColor = System.Drawing.Color.Transparent;
            this.ghoulIcon.Image = ((System.Drawing.Image)(resources.GetObject("ghoulIcon.Image")));
            this.ghoulIcon.Location = new System.Drawing.Point(288, 92);
            this.ghoulIcon.Name = "ghoulIcon";
            this.ghoulIcon.Size = new System.Drawing.Size(50, 50);
            this.ghoulIcon.TabIndex = 11;
            this.ghoulIcon.TabStop = false;
            this.ghoulIcon.Visible = false;
            // 
            // bluePotionIcon
            // 
            this.bluePotionIcon.BackColor = System.Drawing.Color.Transparent;
            this.bluePotionIcon.Image = ((System.Drawing.Image)(resources.GetObject("bluePotionIcon.Image")));
            this.bluePotionIcon.Location = new System.Drawing.Point(344, 92);
            this.bluePotionIcon.Name = "bluePotionIcon";
            this.bluePotionIcon.Size = new System.Drawing.Size(50, 50);
            this.bluePotionIcon.TabIndex = 12;
            this.bluePotionIcon.TabStop = false;
            this.bluePotionIcon.Visible = false;
            // 
            // redPotionIcon
            // 
            this.redPotionIcon.BackColor = System.Drawing.Color.Transparent;
            this.redPotionIcon.Image = ((System.Drawing.Image)(resources.GetObject("redPotionIcon.Image")));
            this.redPotionIcon.Location = new System.Drawing.Point(400, 92);
            this.redPotionIcon.Name = "redPotionIcon";
            this.redPotionIcon.Size = new System.Drawing.Size(50, 50);
            this.redPotionIcon.TabIndex = 13;
            this.redPotionIcon.TabStop = false;
            this.redPotionIcon.Visible = false;
            // 
            // swordIcon
            // 
            this.swordIcon.BackColor = System.Drawing.Color.Transparent;
            this.swordIcon.Image = ((System.Drawing.Image)(resources.GetObject("swordIcon.Image")));
            this.swordIcon.Location = new System.Drawing.Point(456, 92);
            this.swordIcon.Name = "swordIcon";
            this.swordIcon.Size = new System.Drawing.Size(50, 50);
            this.swordIcon.TabIndex = 14;
            this.swordIcon.TabStop = false;
            this.swordIcon.Visible = false;
            // 
            // bowIcon
            // 
            this.bowIcon.BackColor = System.Drawing.Color.Transparent;
            this.bowIcon.Image = ((System.Drawing.Image)(resources.GetObject("bowIcon.Image")));
            this.bowIcon.Location = new System.Drawing.Point(512, 92);
            this.bowIcon.Name = "bowIcon";
            this.bowIcon.Size = new System.Drawing.Size(50, 50);
            this.bowIcon.TabIndex = 15;
            this.bowIcon.TabStop = false;
            this.bowIcon.Visible = false;
            // 
            // maceIcon
            // 
            this.maceIcon.BackColor = System.Drawing.Color.Transparent;
            this.maceIcon.Image = ((System.Drawing.Image)(resources.GetObject("maceIcon.Image")));
            this.maceIcon.Location = new System.Drawing.Point(568, 92);
            this.maceIcon.Name = "maceIcon";
            this.maceIcon.Size = new System.Drawing.Size(50, 50);
            this.maceIcon.TabIndex = 16;
            this.maceIcon.TabStop = false;
            this.maceIcon.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.5F));
            this.tableLayoutPanel1.Controls.Add(this.playerLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.playerHP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.batLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.batHP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ghostLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghostHP, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ghoulLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ghoulHP, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(539, 376);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(149, 73);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(3, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(36, 13);
            this.playerLabel.TabIndex = 0;
            this.playerLabel.Text = "Player";
            // 
            // playerHP
            // 
            this.playerHP.AutoSize = true;
            this.playerHP.Location = new System.Drawing.Point(57, 0);
            this.playerHP.Name = "playerHP";
            this.playerHP.Size = new System.Drawing.Size(35, 13);
            this.playerHP.TabIndex = 1;
            this.playerHP.Text = "label2";
            // 
            // batLabel
            // 
            this.batLabel.AutoSize = true;
            this.batLabel.Location = new System.Drawing.Point(3, 18);
            this.batLabel.Name = "batLabel";
            this.batLabel.Size = new System.Drawing.Size(23, 13);
            this.batLabel.TabIndex = 2;
            this.batLabel.Text = "Bat";
            // 
            // batHP
            // 
            this.batHP.AutoSize = true;
            this.batHP.Location = new System.Drawing.Point(57, 18);
            this.batHP.Name = "batHP";
            this.batHP.Size = new System.Drawing.Size(35, 13);
            this.batHP.TabIndex = 3;
            this.batHP.Text = "label4";
            // 
            // ghostLabel
            // 
            this.ghostLabel.AutoSize = true;
            this.ghostLabel.Location = new System.Drawing.Point(3, 36);
            this.ghostLabel.Name = "ghostLabel";
            this.ghostLabel.Size = new System.Drawing.Size(35, 13);
            this.ghostLabel.TabIndex = 4;
            this.ghostLabel.Text = "Ghost";
            // 
            // ghostHP
            // 
            this.ghostHP.AutoSize = true;
            this.ghostHP.Location = new System.Drawing.Point(57, 36);
            this.ghostHP.Name = "ghostHP";
            this.ghostHP.Size = new System.Drawing.Size(35, 13);
            this.ghostHP.TabIndex = 5;
            this.ghostHP.Text = "label6";
            // 
            // ghoulLabel
            // 
            this.ghoulLabel.AutoSize = true;
            this.ghoulLabel.Location = new System.Drawing.Point(3, 54);
            this.ghoulLabel.Name = "ghoulLabel";
            this.ghoulLabel.Size = new System.Drawing.Size(35, 13);
            this.ghoulLabel.TabIndex = 6;
            this.ghoulLabel.Text = "Ghoul";
            // 
            // ghoulHP
            // 
            this.ghoulHP.AutoSize = true;
            this.ghoulHP.Location = new System.Drawing.Point(57, 54);
            this.ghoulHP.Name = "ghoulHP";
            this.ghoulHP.Size = new System.Drawing.Size(35, 13);
            this.ghoulHP.TabIndex = 7;
            this.ghoulHP.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.maceIcon);
            this.Controls.Add(this.bowIcon);
            this.Controls.Add(this.swordIcon);
            this.Controls.Add(this.redPotionIcon);
            this.Controls.Add(this.bluePotionIcon);
            this.Controls.Add(this.ghoulIcon);
            this.Controls.Add(this.ghostIcon);
            this.Controls.Add(this.batIcon);
            this.Controls.Add(this.weaponRedPotion);
            this.Controls.Add(this.weaponBluePotion);
            this.Controls.Add(this.weaponMace);
            this.Controls.Add(this.weaponBow);
            this.Controls.Add(this.attackButtons);
            this.Controls.Add(this.moveButtons);
            this.Controls.Add(this.weaponSword);
            this.Controls.Add(this.playerIcon);
            this.Name = "Form1";
            this.Text = "The Quest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponSword)).EndInit();
            this.moveButtons.ResumeLayout(false);
            this.attackButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weaponBow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponMace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponBluePotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weaponRedPotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghostIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghoulIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluePotionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redPotionIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swordIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maceIcon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox playerIcon;
        private System.Windows.Forms.PictureBox weaponSword;
        private System.Windows.Forms.GroupBox moveButtons;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.GroupBox attackButtons;
        private System.Windows.Forms.Button attackRight;
        private System.Windows.Forms.Button attackDown;
        private System.Windows.Forms.Button attackUp;
        private System.Windows.Forms.Button attackLeft;
        private System.Windows.Forms.PictureBox weaponBow;
        private System.Windows.Forms.PictureBox weaponMace;
        private System.Windows.Forms.PictureBox weaponBluePotion;
        private System.Windows.Forms.PictureBox weaponRedPotion;
        private System.Windows.Forms.PictureBox batIcon;
        private System.Windows.Forms.PictureBox ghostIcon;
        private System.Windows.Forms.PictureBox ghoulIcon;
        private System.Windows.Forms.PictureBox bluePotionIcon;
        private System.Windows.Forms.PictureBox redPotionIcon;
        private System.Windows.Forms.PictureBox swordIcon;
        private System.Windows.Forms.PictureBox bowIcon;
        private System.Windows.Forms.PictureBox maceIcon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Label playerHP;
        private System.Windows.Forms.Label batLabel;
        private System.Windows.Forms.Label batHP;
        private System.Windows.Forms.Label ghostLabel;
        private System.Windows.Forms.Label ghostHP;
        private System.Windows.Forms.Label ghoulLabel;
        private System.Windows.Forms.Label ghoulHP;
    }
}

