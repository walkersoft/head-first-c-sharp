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
            this.inventorySlot1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moveRight = new System.Windows.Forms.Button();
            this.moveDown = new System.Windows.Forms.Button();
            this.moveUp = new System.Windows.Forms.Button();
            this.moveLeft = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.attackRight = new System.Windows.Forms.Button();
            this.attackDown = new System.Windows.Forms.Button();
            this.attackUp = new System.Windows.Forms.Button();
            this.attackLeft = new System.Windows.Forms.Button();
            this.inventorySlot2 = new System.Windows.Forms.PictureBox();
            this.inventorySlot3 = new System.Windows.Forms.PictureBox();
            this.inventorySlot4 = new System.Windows.Forms.PictureBox();
            this.inventorySlot5 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot5)).BeginInit();
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
            // inventorySlot1
            // 
            this.inventorySlot1.BackColor = System.Drawing.Color.Transparent;
            this.inventorySlot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventorySlot1.Location = new System.Drawing.Point(108, 477);
            this.inventorySlot1.Name = "inventorySlot1";
            this.inventorySlot1.Size = new System.Drawing.Size(75, 75);
            this.inventorySlot1.TabIndex = 1;
            this.inventorySlot1.TabStop = false;
            this.inventorySlot1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.moveRight);
            this.groupBox1.Controls.Add(this.moveDown);
            this.groupBox1.Controls.Add(this.moveUp);
            this.groupBox1.Controls.Add(this.moveLeft);
            this.groupBox1.Location = new System.Drawing.Point(533, 467);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 93);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // moveRight
            // 
            this.moveRight.Location = new System.Drawing.Point(78, 38);
            this.moveRight.Name = "moveRight";
            this.moveRight.Size = new System.Drawing.Size(30, 30);
            this.moveRight.TabIndex = 3;
            this.moveRight.Text = "→";
            this.moveRight.UseVisualStyleBackColor = true;
            // 
            // moveDown
            // 
            this.moveDown.Location = new System.Drawing.Point(42, 55);
            this.moveDown.Name = "moveDown";
            this.moveDown.Size = new System.Drawing.Size(30, 30);
            this.moveDown.TabIndex = 2;
            this.moveDown.Text = "↓";
            this.moveDown.UseVisualStyleBackColor = true;
            // 
            // moveUp
            // 
            this.moveUp.Location = new System.Drawing.Point(42, 19);
            this.moveUp.Name = "moveUp";
            this.moveUp.Size = new System.Drawing.Size(30, 30);
            this.moveUp.TabIndex = 1;
            this.moveUp.Text = "↑";
            this.moveUp.UseVisualStyleBackColor = true;
            // 
            // moveLeft
            // 
            this.moveLeft.Location = new System.Drawing.Point(6, 38);
            this.moveLeft.Name = "moveLeft";
            this.moveLeft.Size = new System.Drawing.Size(30, 30);
            this.moveLeft.TabIndex = 0;
            this.moveLeft.Text = "←";
            this.moveLeft.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.attackRight);
            this.groupBox2.Controls.Add(this.attackDown);
            this.groupBox2.Controls.Add(this.attackUp);
            this.groupBox2.Controls.Add(this.attackLeft);
            this.groupBox2.Location = new System.Drawing.Point(671, 467);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 93);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Attack";
            // 
            // attackRight
            // 
            this.attackRight.Location = new System.Drawing.Point(78, 38);
            this.attackRight.Name = "attackRight";
            this.attackRight.Size = new System.Drawing.Size(30, 30);
            this.attackRight.TabIndex = 3;
            this.attackRight.Text = "→";
            this.attackRight.UseVisualStyleBackColor = true;
            // 
            // attackDown
            // 
            this.attackDown.Location = new System.Drawing.Point(42, 55);
            this.attackDown.Name = "attackDown";
            this.attackDown.Size = new System.Drawing.Size(30, 30);
            this.attackDown.TabIndex = 2;
            this.attackDown.Text = "↓";
            this.attackDown.UseVisualStyleBackColor = true;
            // 
            // attackUp
            // 
            this.attackUp.Location = new System.Drawing.Point(42, 19);
            this.attackUp.Name = "attackUp";
            this.attackUp.Size = new System.Drawing.Size(30, 30);
            this.attackUp.TabIndex = 1;
            this.attackUp.Text = "↑";
            this.attackUp.UseVisualStyleBackColor = true;
            // 
            // attackLeft
            // 
            this.attackLeft.Location = new System.Drawing.Point(6, 38);
            this.attackLeft.Name = "attackLeft";
            this.attackLeft.Size = new System.Drawing.Size(30, 30);
            this.attackLeft.TabIndex = 0;
            this.attackLeft.Text = "←";
            this.attackLeft.UseVisualStyleBackColor = true;
            // 
            // inventorySlot2
            // 
            this.inventorySlot2.BackColor = System.Drawing.Color.Transparent;
            this.inventorySlot2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventorySlot2.Location = new System.Drawing.Point(189, 477);
            this.inventorySlot2.Name = "inventorySlot2";
            this.inventorySlot2.Size = new System.Drawing.Size(75, 75);
            this.inventorySlot2.TabIndex = 5;
            this.inventorySlot2.TabStop = false;
            this.inventorySlot2.Visible = false;
            // 
            // inventorySlot3
            // 
            this.inventorySlot3.BackColor = System.Drawing.Color.Transparent;
            this.inventorySlot3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventorySlot3.Location = new System.Drawing.Point(271, 477);
            this.inventorySlot3.Name = "inventorySlot3";
            this.inventorySlot3.Size = new System.Drawing.Size(75, 75);
            this.inventorySlot3.TabIndex = 6;
            this.inventorySlot3.TabStop = false;
            this.inventorySlot3.Visible = false;
            // 
            // inventorySlot4
            // 
            this.inventorySlot4.BackColor = System.Drawing.Color.Transparent;
            this.inventorySlot4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventorySlot4.Location = new System.Drawing.Point(351, 477);
            this.inventorySlot4.Name = "inventorySlot4";
            this.inventorySlot4.Size = new System.Drawing.Size(75, 75);
            this.inventorySlot4.TabIndex = 7;
            this.inventorySlot4.TabStop = false;
            this.inventorySlot4.Visible = false;
            // 
            // inventorySlot5
            // 
            this.inventorySlot5.BackColor = System.Drawing.Color.Transparent;
            this.inventorySlot5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inventorySlot5.Location = new System.Drawing.Point(432, 477);
            this.inventorySlot5.Name = "inventorySlot5";
            this.inventorySlot5.Size = new System.Drawing.Size(75, 75);
            this.inventorySlot5.TabIndex = 8;
            this.inventorySlot5.TabStop = false;
            this.inventorySlot5.Visible = false;
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
            this.Controls.Add(this.inventorySlot5);
            this.Controls.Add(this.inventorySlot4);
            this.Controls.Add(this.inventorySlot3);
            this.Controls.Add(this.inventorySlot2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inventorySlot1);
            this.Controls.Add(this.playerIcon);
            this.Name = "Form1";
            this.Text = "The Quest";
            ((System.ComponentModel.ISupportInitialize)(this.playerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventorySlot5)).EndInit();
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
        private System.Windows.Forms.PictureBox inventorySlot1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button moveRight;
        private System.Windows.Forms.Button moveDown;
        private System.Windows.Forms.Button moveUp;
        private System.Windows.Forms.Button moveLeft;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button attackRight;
        private System.Windows.Forms.Button attackDown;
        private System.Windows.Forms.Button attackUp;
        private System.Windows.Forms.Button attackLeft;
        private System.Windows.Forms.PictureBox inventorySlot2;
        private System.Windows.Forms.PictureBox inventorySlot3;
        private System.Windows.Forms.PictureBox inventorySlot4;
        private System.Windows.Forms.PictureBox inventorySlot5;
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

