namespace GUI_Applications___01.Name_and_Address
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
            this.ShowInfoButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowInfoButton
            // 
            this.ShowInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowInfoButton.Location = new System.Drawing.Point(48, 233);
            this.ShowInfoButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ShowInfoButton.Name = "ShowInfoButton";
            this.ShowInfoButton.Size = new System.Drawing.Size(170, 51);
            this.ShowInfoButton.TabIndex = 0;
            this.ShowInfoButton.Text = "Show Info";
            this.ShowInfoButton.UseVisualStyleBackColor = true;
            this.ShowInfoButton.Click += new System.EventHandler(this.ShowInfoButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(282, 235);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(143, 49);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel.Location = new System.Drawing.Point(118, 58);
            this.InfoLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(258, 148);
            this.InfoLabel.TabIndex = 2;
            this.InfoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.InfoLabel.Click += new System.EventHandler(this.InfoLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 357);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ShowInfoButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowInfoButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label InfoLabel;
    }
}

