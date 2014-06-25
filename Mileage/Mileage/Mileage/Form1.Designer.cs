namespace Mileage
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startMileage = new System.Windows.Forms.NumericUpDown();
            this.endMileage = new System.Windows.Forms.NumericUpDown();
            this.amountOwed = new System.Windows.Forms.Label();
            this.calcMileage = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.showMiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startMileage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMileage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Mileage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ending Mileage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount Owed:";
            // 
            // startMileage
            // 
            this.startMileage.Location = new System.Drawing.Point(105, 39);
            this.startMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.startMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.startMileage.Name = "startMileage";
            this.startMileage.Size = new System.Drawing.Size(87, 20);
            this.startMileage.TabIndex = 3;
            this.startMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // endMileage
            // 
            this.endMileage.Location = new System.Drawing.Point(105, 67);
            this.endMileage.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.endMileage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.endMileage.Name = "endMileage";
            this.endMileage.Size = new System.Drawing.Size(87, 20);
            this.endMileage.TabIndex = 4;
            this.endMileage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // amountOwed
            // 
            this.amountOwed.AutoSize = true;
            this.amountOwed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountOwed.Location = new System.Drawing.Point(102, 96);
            this.amountOwed.Name = "amountOwed";
            this.amountOwed.Size = new System.Drawing.Size(52, 17);
            this.amountOwed.TabIndex = 5;
            this.amountOwed.Text = "label4";
            // 
            // calcMileage
            // 
            this.calcMileage.Location = new System.Drawing.Point(12, 128);
            this.calcMileage.Name = "calcMileage";
            this.calcMileage.Size = new System.Drawing.Size(75, 23);
            this.calcMileage.TabIndex = 6;
            this.calcMileage.Text = "Calculate";
            this.calcMileage.UseVisualStyleBackColor = true;
            this.calcMileage.Click += new System.EventHandler(this.calcMileage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mileage Calculator";
            // 
            // showMiles
            // 
            this.showMiles.Location = new System.Drawing.Point(117, 128);
            this.showMiles.Name = "showMiles";
            this.showMiles.Size = new System.Drawing.Size(88, 23);
            this.showMiles.TabIndex = 8;
            this.showMiles.Text = "Show Mileage";
            this.showMiles.UseVisualStyleBackColor = true;
            this.showMiles.Click += new System.EventHandler(this.showMiles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 192);
            this.Controls.Add(this.showMiles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.calcMileage);
            this.Controls.Add(this.amountOwed);
            this.Controls.Add(this.endMileage);
            this.Controls.Add(this.startMileage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mileage Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.startMileage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMileage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown startMileage;
        private System.Windows.Forms.NumericUpDown endMileage;
        private System.Windows.Forms.Label amountOwed;
        private System.Windows.Forms.Button calcMileage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button showMiles;
    }
}

