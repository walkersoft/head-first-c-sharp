namespace Elephant
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
            this.lucindaButton = new System.Windows.Forms.Button();
            this.lloydButton = new System.Windows.Forms.Button();
            this.swapButton = new System.Windows.Forms.Button();
            this.elephantButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lucindaButton
            // 
            this.lucindaButton.Location = new System.Drawing.Point(48, 22);
            this.lucindaButton.Name = "lucindaButton";
            this.lucindaButton.Size = new System.Drawing.Size(75, 23);
            this.lucindaButton.TabIndex = 0;
            this.lucindaButton.Text = "Lucinda";
            this.lucindaButton.UseVisualStyleBackColor = true;
            this.lucindaButton.Click += new System.EventHandler(this.lucindaButton_Click);
            // 
            // lloydButton
            // 
            this.lloydButton.Location = new System.Drawing.Point(48, 51);
            this.lloydButton.Name = "lloydButton";
            this.lloydButton.Size = new System.Drawing.Size(75, 23);
            this.lloydButton.TabIndex = 1;
            this.lloydButton.Text = "Lloyd";
            this.lloydButton.UseVisualStyleBackColor = true;
            this.lloydButton.Click += new System.EventHandler(this.lloydButton_Click);
            // 
            // swapButton
            // 
            this.swapButton.Location = new System.Drawing.Point(48, 80);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(75, 23);
            this.swapButton.TabIndex = 2;
            this.swapButton.Text = "Swap";
            this.swapButton.UseVisualStyleBackColor = true;
            this.swapButton.Click += new System.EventHandler(this.swapButton_Click);
            // 
            // elephantButton
            // 
            this.elephantButton.Location = new System.Drawing.Point(48, 109);
            this.elephantButton.Name = "elephantButton";
            this.elephantButton.Size = new System.Drawing.Size(75, 23);
            this.elephantButton.TabIndex = 3;
            this.elephantButton.Text = "Elephant";
            this.elephantButton.UseVisualStyleBackColor = true;
            this.elephantButton.Click += new System.EventHandler(this.elephantButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(167, 149);
            this.Controls.Add(this.elephantButton);
            this.Controls.Add(this.swapButton);
            this.Controls.Add(this.lloydButton);
            this.Controls.Add(this.lucindaButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button lucindaButton;
        private System.Windows.Forms.Button lloydButton;
        private System.Windows.Forms.Button swapButton;
        private System.Windows.Forms.Button elephantButton;
    }
}

