namespace GUI_Applications___05.Property_Tax
{
    partial class AssesmentValueLabel
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
            this.ActualValueLabel = new System.Windows.Forms.Label();
            this.ActualValueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AssesmentValueTextBox = new System.Windows.Forms.TextBox();
            this.PropertyTaxLabel = new System.Windows.Forms.Label();
            this.PropertyTaxTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ActualValueLabel
            // 
            this.ActualValueLabel.AutoSize = true;
            this.ActualValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActualValueLabel.Location = new System.Drawing.Point(83, 52);
            this.ActualValueLabel.Name = "ActualValueLabel";
            this.ActualValueLabel.Size = new System.Drawing.Size(99, 16);
            this.ActualValueLabel.TabIndex = 0;
            this.ActualValueLabel.Text = "Actual Value:";
            // 
            // ActualValueTextBox
            // 
            this.ActualValueTextBox.Location = new System.Drawing.Point(67, 71);
            this.ActualValueTextBox.Name = "ActualValueTextBox";
            this.ActualValueTextBox.Size = new System.Drawing.Size(144, 20);
            this.ActualValueTextBox.TabIndex = 1;
            this.ActualValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Assesment Value:";
            // 
            // AssesmentValueTextBox
            // 
            this.AssesmentValueTextBox.Location = new System.Drawing.Point(67, 123);
            this.AssesmentValueTextBox.Name = "AssesmentValueTextBox";
            this.AssesmentValueTextBox.Size = new System.Drawing.Size(144, 20);
            this.AssesmentValueTextBox.TabIndex = 3;
            this.AssesmentValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PropertyTaxLabel
            // 
            this.PropertyTaxLabel.AutoSize = true;
            this.PropertyTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PropertyTaxLabel.Location = new System.Drawing.Point(89, 156);
            this.PropertyTaxLabel.Name = "PropertyTaxLabel";
            this.PropertyTaxLabel.Size = new System.Drawing.Size(93, 16);
            this.PropertyTaxLabel.TabIndex = 4;
            this.PropertyTaxLabel.Text = "Propert Tax:";
            // 
            // PropertyTaxTextBox
            // 
            this.PropertyTaxTextBox.Location = new System.Drawing.Point(67, 175);
            this.PropertyTaxTextBox.Name = "PropertyTaxTextBox";
            this.PropertyTaxTextBox.Size = new System.Drawing.Size(144, 20);
            this.PropertyTaxTextBox.TabIndex = 5;
            this.PropertyTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(86, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AssesmentValueLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PropertyTaxTextBox);
            this.Controls.Add(this.PropertyTaxLabel);
            this.Controls.Add(this.AssesmentValueTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActualValueTextBox);
            this.Controls.Add(this.ActualValueLabel);
            this.Name = "AssesmentValueLabel";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ActualValueLabel;
        private System.Windows.Forms.TextBox ActualValueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AssesmentValueTextBox;
        private System.Windows.Forms.Label PropertyTaxLabel;
        private System.Windows.Forms.TextBox PropertyTaxTextBox;
        private System.Windows.Forms.Button button1;
    }
}

