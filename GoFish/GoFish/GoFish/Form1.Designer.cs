﻿namespace GoFish
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
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textBooks = new System.Windows.Forms.TextBox();
            this.textProgress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listHand = new System.Windows.Forms.ListBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonAsk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Name:";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(12, 25);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(131, 20);
            this.textName.TabIndex = 1;
            // 
            // textBooks
            // 
            this.textBooks.Enabled = false;
            this.textBooks.Location = new System.Drawing.Point(12, 425);
            this.textBooks.Multiline = true;
            this.textBooks.Name = "textBooks";
            this.textBooks.Size = new System.Drawing.Size(252, 128);
            this.textBooks.TabIndex = 2;
            // 
            // textProgress
            // 
            this.textProgress.Enabled = false;
            this.textProgress.Location = new System.Drawing.Point(12, 80);
            this.textProgress.Multiline = true;
            this.textProgress.Name = "textProgress";
            this.textProgress.Size = new System.Drawing.Size(252, 312);
            this.textProgress.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Game Progress:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Books";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(274, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Your Hand:";
            // 
            // listHand
            // 
            this.listHand.FormattingEnabled = true;
            this.listHand.Location = new System.Drawing.Point(277, 25);
            this.listHand.Name = "listHand";
            this.listHand.Size = new System.Drawing.Size(146, 498);
            this.listHand.TabIndex = 7;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(149, 23);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(115, 23);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Start Game!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonAsk
            // 
            this.buttonAsk.Enabled = false;
            this.buttonAsk.Location = new System.Drawing.Point(277, 530);
            this.buttonAsk.Name = "buttonAsk";
            this.buttonAsk.Size = new System.Drawing.Size(146, 23);
            this.buttonAsk.TabIndex = 9;
            this.buttonAsk.Text = "Ask for a card";
            this.buttonAsk.UseVisualStyleBackColor = true;
            this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 565);
            this.Controls.Add(this.buttonAsk);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.listHand);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.textBooks);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Go Fish!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textBooks;
        private System.Windows.Forms.TextBox textProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listHand;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonAsk;
    }
}

