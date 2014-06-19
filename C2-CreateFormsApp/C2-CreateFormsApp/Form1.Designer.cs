namespace C2_CreateFormsApp
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
            this.changeText = new System.Windows.Forms.Button();
            this.enableCheckbox = new System.Windows.Forms.CheckBox();
            this.labelToChange = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.newButton5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // changeText
            // 
            this.changeText.Location = new System.Drawing.Point(26, 14);
            this.changeText.Name = "changeText";
            this.changeText.Size = new System.Drawing.Size(191, 23);
            this.changeText.TabIndex = 0;
            this.changeText.Text = "Click me to try and change the text";
            this.changeText.UseVisualStyleBackColor = true;
            // 
            // enableCheckbox
            // 
            this.enableCheckbox.AutoSize = true;
            this.enableCheckbox.Location = new System.Drawing.Point(293, 18);
            this.enableCheckbox.Name = "enableCheckbox";
            this.enableCheckbox.Size = new System.Drawing.Size(170, 17);
            this.enableCheckbox.TabIndex = 1;
            this.enableCheckbox.Text = "Change the text if I\'m checked";
            this.enableCheckbox.UseVisualStyleBackColor = true;
            // 
            // labelToChange
            // 
            this.labelToChange.Location = new System.Drawing.Point(12, 56);
            this.labelToChange.Name = "labelToChange";
            this.labelToChange.Size = new System.Drawing.Size(460, 23);
            this.labelToChange.TabIndex = 2;
            this.labelToChange.Text = "Push the button to change my text";
            this.labelToChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 123);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // newButton5
            // 
            this.newButton5.Location = new System.Drawing.Point(0, 0);
            this.newButton5.Name = "newButton5";
            this.newButton5.Size = new System.Drawing.Size(487, 291);
            this.newButton5.TabIndex = 4;
            this.newButton5.Text = "newButton5";
            this.newButton5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 288);
            this.Controls.Add(this.newButton5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelToChange);
            this.Controls.Add(this.enableCheckbox);
            this.Controls.Add(this.changeText);
            this.Name = "Form1";
            this.Text = "C2 - Rebuilding With Forms";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeText;
        private System.Windows.Forms.CheckBox enableCheckbox;
        private System.Windows.Forms.Label labelToChange;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button newButton5;
    }
}

