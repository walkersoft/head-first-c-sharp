namespace OverloadedCards
{
    partial class DeckOfCards
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
            this.deck1 = new System.Windows.Forms.ListBox();
            this.deck2 = new System.Windows.Forms.ListBox();
            this.shuffle2 = new System.Windows.Forms.Button();
            this.shuffle1 = new System.Windows.Forms.Button();
            this.reset1 = new System.Windows.Forms.Button();
            this.reset2 = new System.Windows.Forms.Button();
            this.moveCardLeft = new System.Windows.Forms.Button();
            this.moveCardRight = new System.Windows.Forms.Button();
            this.deck1Label = new System.Windows.Forms.Label();
            this.deck2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deck1
            // 
            this.deck1.FormattingEnabled = true;
            this.deck1.Location = new System.Drawing.Point(12, 25);
            this.deck1.Name = "deck1";
            this.deck1.Size = new System.Drawing.Size(120, 303);
            this.deck1.TabIndex = 0;
            // 
            // deck2
            // 
            this.deck2.FormattingEnabled = true;
            this.deck2.Location = new System.Drawing.Point(197, 25);
            this.deck2.Name = "deck2";
            this.deck2.Size = new System.Drawing.Size(120, 303);
            this.deck2.TabIndex = 1;
            // 
            // shuffle2
            // 
            this.shuffle2.Location = new System.Drawing.Point(197, 373);
            this.shuffle2.Name = "shuffle2";
            this.shuffle2.Size = new System.Drawing.Size(120, 23);
            this.shuffle2.TabIndex = 2;
            this.shuffle2.Text = "Shuffle Deck #2";
            this.shuffle2.UseVisualStyleBackColor = true;
            // 
            // shuffle1
            // 
            this.shuffle1.Location = new System.Drawing.Point(12, 373);
            this.shuffle1.Name = "shuffle1";
            this.shuffle1.Size = new System.Drawing.Size(120, 23);
            this.shuffle1.TabIndex = 3;
            this.shuffle1.Text = "Shuffle Deck #1";
            this.shuffle1.UseVisualStyleBackColor = true;
            // 
            // reset1
            // 
            this.reset1.Location = new System.Drawing.Point(12, 344);
            this.reset1.Name = "reset1";
            this.reset1.Size = new System.Drawing.Size(120, 23);
            this.reset1.TabIndex = 4;
            this.reset1.Text = "Reset Deck #1";
            this.reset1.UseVisualStyleBackColor = true;
            // 
            // reset2
            // 
            this.reset2.Location = new System.Drawing.Point(197, 344);
            this.reset2.Name = "reset2";
            this.reset2.Size = new System.Drawing.Size(120, 23);
            this.reset2.TabIndex = 5;
            this.reset2.Text = "Reset Deck #2";
            this.reset2.UseVisualStyleBackColor = true;
            // 
            // moveCardLeft
            // 
            this.moveCardLeft.Location = new System.Drawing.Point(147, 172);
            this.moveCardLeft.Name = "moveCardLeft";
            this.moveCardLeft.Size = new System.Drawing.Size(31, 23);
            this.moveCardLeft.TabIndex = 6;
            this.moveCardLeft.Text = "<<";
            this.moveCardLeft.UseVisualStyleBackColor = true;
            // 
            // moveCardRight
            // 
            this.moveCardRight.Location = new System.Drawing.Point(147, 114);
            this.moveCardRight.Name = "moveCardRight";
            this.moveCardRight.Size = new System.Drawing.Size(31, 23);
            this.moveCardRight.TabIndex = 7;
            this.moveCardRight.Text = ">>";
            this.moveCardRight.UseVisualStyleBackColor = true;
            // 
            // deck1Label
            // 
            this.deck1Label.AutoSize = true;
            this.deck1Label.Location = new System.Drawing.Point(12, 7);
            this.deck1Label.Name = "deck1Label";
            this.deck1Label.Size = new System.Drawing.Size(49, 13);
            this.deck1Label.TabIndex = 8;
            this.deck1Label.Text = "Deck #1";
            // 
            // deck2Label
            // 
            this.deck2Label.AutoSize = true;
            this.deck2Label.Location = new System.Drawing.Point(194, 7);
            this.deck2Label.Name = "deck2Label";
            this.deck2Label.Size = new System.Drawing.Size(49, 13);
            this.deck2Label.TabIndex = 9;
            this.deck2Label.Text = "Deck #2";
            // 
            // DeckOfCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 421);
            this.Controls.Add(this.deck2Label);
            this.Controls.Add(this.deck1Label);
            this.Controls.Add(this.moveCardRight);
            this.Controls.Add(this.moveCardLeft);
            this.Controls.Add(this.reset2);
            this.Controls.Add(this.reset1);
            this.Controls.Add(this.shuffle1);
            this.Controls.Add(this.shuffle2);
            this.Controls.Add(this.deck2);
            this.Controls.Add(this.deck1);
            this.Name = "DeckOfCards";
            this.Text = "DeckOfCards";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox deck1;
        private System.Windows.Forms.ListBox deck2;
        private System.Windows.Forms.Button shuffle2;
        private System.Windows.Forms.Button shuffle1;
        private System.Windows.Forms.Button reset1;
        private System.Windows.Forms.Button reset2;
        private System.Windows.Forms.Button moveCardLeft;
        private System.Windows.Forms.Button moveCardRight;
        private System.Windows.Forms.Label deck1Label;
        private System.Windows.Forms.Label deck2Label;
    }
}