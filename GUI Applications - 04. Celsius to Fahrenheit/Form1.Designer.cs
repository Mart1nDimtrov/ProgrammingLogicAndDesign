namespace GUI_Applications___04.Celsius_to_Fahrenheit
{
    partial class FarhenheitLabel
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
            this.CelsiusTextBox = new System.Windows.Forms.TextBox();
            this.CelsiusLabel = new System.Windows.Forms.Label();
            this.FahrenheitLabel = new System.Windows.Forms.Label();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CelsiusTextBox
            // 
            this.CelsiusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelsiusTextBox.Location = new System.Drawing.Point(64, 65);
            this.CelsiusTextBox.Name = "CelsiusTextBox";
            this.CelsiusTextBox.Size = new System.Drawing.Size(151, 20);
            this.CelsiusTextBox.TabIndex = 0;
            this.CelsiusTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CelsiusLabel
            // 
            this.CelsiusLabel.AutoSize = true;
            this.CelsiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CelsiusLabel.Location = new System.Drawing.Point(102, 44);
            this.CelsiusLabel.Name = "CelsiusLabel";
            this.CelsiusLabel.Size = new System.Drawing.Size(69, 18);
            this.CelsiusLabel.TabIndex = 1;
            this.CelsiusLabel.Text = "Celsius:";
            // 
            // FahrenheitLabel
            // 
            this.FahrenheitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FahrenheitLabel.Location = new System.Drawing.Point(87, 98);
            this.FahrenheitLabel.Name = "FahrenheitLabel";
            this.FahrenheitLabel.Size = new System.Drawing.Size(98, 56);
            this.FahrenheitLabel.TabIndex = 2;
            this.FahrenheitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertButton.Location = new System.Drawing.Point(74, 171);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(122, 30);
            this.ConvertButton.TabIndex = 3;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // FarhenheitLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.FahrenheitLabel);
            this.Controls.Add(this.CelsiusLabel);
            this.Controls.Add(this.CelsiusTextBox);
            this.Name = "FarhenheitLabel";
            this.Load += new System.EventHandler(this.FarhenheitLabel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CelsiusTextBox;
        private System.Windows.Forms.Label CelsiusLabel;
        private System.Windows.Forms.Label FahrenheitLabel;
        private System.Windows.Forms.Button ConvertButton;
    }
}

