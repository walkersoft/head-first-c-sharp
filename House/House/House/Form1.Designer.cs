namespace House
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
            this.roomDescription = new System.Windows.Forms.TextBox();
            this.roomSelect = new System.Windows.Forms.ComboBox();
            this.goToRoom = new System.Windows.Forms.Button();
            this.goThroughDoor = new System.Windows.Forms.Button();
            this.checkButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // roomDescription
            // 
            this.roomDescription.Enabled = false;
            this.roomDescription.Location = new System.Drawing.Point(12, 12);
            this.roomDescription.Multiline = true;
            this.roomDescription.Name = "roomDescription";
            this.roomDescription.Size = new System.Drawing.Size(289, 209);
            this.roomDescription.TabIndex = 0;
            // 
            // roomSelect
            // 
            this.roomSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomSelect.FormattingEnabled = true;
            this.roomSelect.Items.AddRange(new object[] {
            "Front Yard",
            "Living Room",
            "Dining Room",
            "Kitchen",
            "Back Yard",
            "Garden"});
            this.roomSelect.Location = new System.Drawing.Point(107, 227);
            this.roomSelect.Name = "roomSelect";
            this.roomSelect.Size = new System.Drawing.Size(194, 21);
            this.roomSelect.TabIndex = 1;
            // 
            // goToRoom
            // 
            this.goToRoom.Location = new System.Drawing.Point(12, 225);
            this.goToRoom.Name = "goToRoom";
            this.goToRoom.Size = new System.Drawing.Size(89, 23);
            this.goToRoom.TabIndex = 2;
            this.goToRoom.Text = "Go here:";
            this.goToRoom.UseVisualStyleBackColor = true;
            this.goToRoom.Click += new System.EventHandler(this.goToRoom_Click);
            // 
            // goThroughDoor
            // 
            this.goThroughDoor.Location = new System.Drawing.Point(12, 254);
            this.goThroughDoor.Name = "goThroughDoor";
            this.goThroughDoor.Size = new System.Drawing.Size(289, 23);
            this.goThroughDoor.TabIndex = 3;
            this.goThroughDoor.Text = "Go through the door";
            this.goThroughDoor.UseVisualStyleBackColor = true;
            this.goThroughDoor.Click += new System.EventHandler(this.goThroughDoor_Click);
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(12, 283);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(289, 23);
            this.checkButton.TabIndex = 4;
            this.checkButton.Text = "Check!";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(12, 312);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(289, 23);
            this.hideButton.TabIndex = 5;
            this.hideButton.Text = "Hide!";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 345);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.goThroughDoor);
            this.Controls.Add(this.goToRoom);
            this.Controls.Add(this.roomSelect);
            this.Controls.Add(this.roomDescription);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox roomDescription;
        private System.Windows.Forms.ComboBox roomSelect;
        private System.Windows.Forms.Button goToRoom;
        private System.Windows.Forms.Button goThroughDoor;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button hideButton;
    }
}

