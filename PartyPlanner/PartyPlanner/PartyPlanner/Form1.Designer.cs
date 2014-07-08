namespace PartyPlanner
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
            this.personCount = new System.Windows.Forms.NumericUpDown();
            this.healthyOption = new System.Windows.Forms.CheckBox();
            this.fancyDecorations = new System.Windows.Forms.CheckBox();
            this.costLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. of People:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Party Planner";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cost:";
            // 
            // personCount
            // 
            this.personCount.Location = new System.Drawing.Point(93, 48);
            this.personCount.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.personCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.personCount.Name = "personCount";
            this.personCount.Size = new System.Drawing.Size(58, 20);
            this.personCount.TabIndex = 3;
            this.personCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.personCount.ValueChanged += new System.EventHandler(this.personCount_ValueChanged);
            // 
            // healthyOption
            // 
            this.healthyOption.AutoSize = true;
            this.healthyOption.Location = new System.Drawing.Point(15, 75);
            this.healthyOption.Name = "healthyOption";
            this.healthyOption.Size = new System.Drawing.Size(96, 17);
            this.healthyOption.TabIndex = 4;
            this.healthyOption.Text = "Healthy Option";
            this.healthyOption.UseVisualStyleBackColor = true;
            this.healthyOption.CheckedChanged += new System.EventHandler(this.healthyOption_CheckedChanged);
            // 
            // fancyDecorations
            // 
            this.fancyDecorations.AutoSize = true;
            this.fancyDecorations.Checked = true;
            this.fancyDecorations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyDecorations.Location = new System.Drawing.Point(15, 98);
            this.fancyDecorations.Name = "fancyDecorations";
            this.fancyDecorations.Size = new System.Drawing.Size(115, 17);
            this.fancyDecorations.TabIndex = 5;
            this.fancyDecorations.Text = "Fancy Decorations";
            this.fancyDecorations.UseVisualStyleBackColor = true;
            this.fancyDecorations.CheckedChanged += new System.EventHandler(this.fancyDecorations_CheckedChanged);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(83, 129);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(43, 15);
            this.costLabel.TabIndex = 6;
            this.costLabel.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 170);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.fancyDecorations);
            this.Controls.Add(this.healthyOption);
            this.Controls.Add(this.personCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.personCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown personCount;
        private System.Windows.Forms.CheckBox healthyOption;
        private System.Windows.Forms.CheckBox fancyDecorations;
        private System.Windows.Forms.Label costLabel;
    }
}

