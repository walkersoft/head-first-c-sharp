namespace BobJoeCash
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
            this.bobCash = new System.Windows.Forms.Label();
            this.joeCash = new System.Windows.Forms.Label();
            this.bankCash = new System.Windows.Forms.Label();
            this.giveCash = new System.Windows.Forms.Button();
            this.receiveCash = new System.Windows.Forms.Button();
            this.joeToBob = new System.Windows.Forms.Button();
            this.bobToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bobCash
            // 
            this.bobCash.AutoSize = true;
            this.bobCash.Location = new System.Drawing.Point(26, 41);
            this.bobCash.Name = "bobCash";
            this.bobCash.Size = new System.Drawing.Size(35, 13);
            this.bobCash.TabIndex = 3;
            this.bobCash.Text = "label4";
            // 
            // joeCash
            // 
            this.joeCash.AutoSize = true;
            this.joeCash.Location = new System.Drawing.Point(26, 73);
            this.joeCash.Name = "joeCash";
            this.joeCash.Size = new System.Drawing.Size(35, 13);
            this.joeCash.TabIndex = 4;
            this.joeCash.Text = "label5";
            // 
            // bankCash
            // 
            this.bankCash.AutoSize = true;
            this.bankCash.Location = new System.Drawing.Point(26, 105);
            this.bankCash.Name = "bankCash";
            this.bankCash.Size = new System.Drawing.Size(35, 13);
            this.bankCash.TabIndex = 5;
            this.bankCash.Text = "label6";
            // 
            // giveCash
            // 
            this.giveCash.Location = new System.Drawing.Point(42, 156);
            this.giveCash.Name = "giveCash";
            this.giveCash.Size = new System.Drawing.Size(83, 67);
            this.giveCash.TabIndex = 6;
            this.giveCash.Text = "Give $10 Cash to Joe";
            this.giveCash.UseVisualStyleBackColor = true;
            this.giveCash.Click += new System.EventHandler(this.giveCash_Click);
            // 
            // receiveCash
            // 
            this.receiveCash.Location = new System.Drawing.Point(131, 156);
            this.receiveCash.Name = "receiveCash";
            this.receiveCash.Size = new System.Drawing.Size(84, 67);
            this.receiveCash.TabIndex = 7;
            this.receiveCash.Text = "Receive $5 Cash from Bob";
            this.receiveCash.UseVisualStyleBackColor = true;
            this.receiveCash.Click += new System.EventHandler(this.receiveCash_Click);
            // 
            // joeToBob
            // 
            this.joeToBob.Location = new System.Drawing.Point(42, 229);
            this.joeToBob.Name = "joeToBob";
            this.joeToBob.Size = new System.Drawing.Size(83, 67);
            this.joeToBob.TabIndex = 8;
            this.joeToBob.Text = "Joe Gives $10 to Bob";
            this.joeToBob.UseVisualStyleBackColor = true;
            this.joeToBob.Click += new System.EventHandler(this.joeToBob_Click);
            // 
            // bobToJoe
            // 
            this.bobToJoe.Location = new System.Drawing.Point(131, 229);
            this.bobToJoe.Name = "bobToJoe";
            this.bobToJoe.Size = new System.Drawing.Size(84, 67);
            this.bobToJoe.TabIndex = 9;
            this.bobToJoe.Text = "Bob Gives $5 to Joe";
            this.bobToJoe.UseVisualStyleBackColor = true;
            this.bobToJoe.Click += new System.EventHandler(this.bobToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 336);
            this.Controls.Add(this.bobToJoe);
            this.Controls.Add(this.joeToBob);
            this.Controls.Add(this.receiveCash);
            this.Controls.Add(this.giveCash);
            this.Controls.Add(this.bankCash);
            this.Controls.Add(this.joeCash);
            this.Controls.Add(this.bobCash);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bobCash;
        private System.Windows.Forms.Label joeCash;
        private System.Windows.Forms.Label bankCash;
        private System.Windows.Forms.Button giveCash;
        private System.Windows.Forms.Button receiveCash;
        private System.Windows.Forms.Button joeToBob;
        private System.Windows.Forms.Button bobToJoe;
    }
}

