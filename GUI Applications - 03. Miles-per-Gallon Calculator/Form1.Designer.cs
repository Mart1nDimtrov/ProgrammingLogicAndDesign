namespace GUI_Applications___03.Miles_per_Gallon_Calculator
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
            this.GallonsLabel = new System.Windows.Forms.Label();
            this.MilesLabel = new System.Windows.Forms.Label();
            this.GallonsTextBox = new System.Windows.Forms.TextBox();
            this.MilesTextBox = new System.Windows.Forms.TextBox();
            this.CalculateMilesButton = new System.Windows.Forms.Button();
            this.MilesPerGalonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GallonsLabel
            // 
            this.GallonsLabel.AutoSize = true;
            this.GallonsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GallonsLabel.Location = new System.Drawing.Point(72, 58);
            this.GallonsLabel.Name = "GallonsLabel";
            this.GallonsLabel.Size = new System.Drawing.Size(63, 18);
            this.GallonsLabel.TabIndex = 0;
            this.GallonsLabel.Text = "Gallons:";
            // 
            // MilesLabel
            // 
            this.MilesLabel.AutoSize = true;
            this.MilesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MilesLabel.Location = new System.Drawing.Point(226, 58);
            this.MilesLabel.Name = "MilesLabel";
            this.MilesLabel.Size = new System.Drawing.Size(47, 18);
            this.MilesLabel.TabIndex = 1;
            this.MilesLabel.Text = "Miles:";
            // 
            // GallonsTextBox
            // 
            this.GallonsTextBox.Location = new System.Drawing.Point(52, 89);
            this.GallonsTextBox.Name = "GallonsTextBox";
            this.GallonsTextBox.Size = new System.Drawing.Size(100, 20);
            this.GallonsTextBox.TabIndex = 2;
            this.GallonsTextBox.TextChanged += new System.EventHandler(this.GallonsTextBox_TextChanged);
            // 
            // MilesTextBox
            // 
            this.MilesTextBox.Location = new System.Drawing.Point(199, 89);
            this.MilesTextBox.Name = "MilesTextBox";
            this.MilesTextBox.Size = new System.Drawing.Size(105, 20);
            this.MilesTextBox.TabIndex = 3;
            this.MilesTextBox.TextChanged += new System.EventHandler(this.MilesTextBox_TextChanged);
            // 
            // CalculateMilesButton
            // 
            this.CalculateMilesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateMilesButton.Location = new System.Drawing.Point(111, 167);
            this.CalculateMilesButton.Name = "CalculateMilesButton";
            this.CalculateMilesButton.Size = new System.Drawing.Size(124, 32);
            this.CalculateMilesButton.TabIndex = 4;
            this.CalculateMilesButton.Text = "Calculate MPG";
            this.CalculateMilesButton.UseVisualStyleBackColor = true;
            this.CalculateMilesButton.Click += new System.EventHandler(this.CalculateMilesButton_Click);
            // 
            // MilesPerGalonLabel
            // 
            this.MilesPerGalonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MilesPerGalonLabel.Location = new System.Drawing.Point(124, 128);
            this.MilesPerGalonLabel.Name = "MilesPerGalonLabel";
            this.MilesPerGalonLabel.Size = new System.Drawing.Size(100, 23);
            this.MilesPerGalonLabel.TabIndex = 5;
            this.MilesPerGalonLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MilesPerGalonLabel.Click += new System.EventHandler(this.MilesPerGalonLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 232);
            this.Controls.Add(this.MilesPerGalonLabel);
            this.Controls.Add(this.CalculateMilesButton);
            this.Controls.Add(this.MilesTextBox);
            this.Controls.Add(this.GallonsTextBox);
            this.Controls.Add(this.MilesLabel);
            this.Controls.Add(this.GallonsLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GallonsLabel;
        private System.Windows.Forms.Label MilesLabel;
        private System.Windows.Forms.TextBox GallonsTextBox;
        private System.Windows.Forms.TextBox MilesTextBox;
        private System.Windows.Forms.Button CalculateMilesButton;
        private System.Windows.Forms.Label MilesPerGalonLabel;
    }
}

