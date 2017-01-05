namespace GUI_Applications___02.Latin_Translator
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
            this.SinisterButton = new System.Windows.Forms.Button();
            this.DexterButton = new System.Windows.Forms.Button();
            this.MediumButton = new System.Windows.Forms.Button();
            this.SinisterLabel = new System.Windows.Forms.Label();
            this.DexterLabel = new System.Windows.Forms.Label();
            this.MediumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SinisterButton
            // 
            this.SinisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinisterButton.Location = new System.Drawing.Point(66, 70);
            this.SinisterButton.Name = "SinisterButton";
            this.SinisterButton.Size = new System.Drawing.Size(75, 31);
            this.SinisterButton.TabIndex = 0;
            this.SinisterButton.Text = "sinister";
            this.SinisterButton.UseVisualStyleBackColor = true;
            this.SinisterButton.Click += new System.EventHandler(this.SinisterButton_Click);
            // 
            // DexterButton
            // 
            this.DexterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexterButton.Location = new System.Drawing.Point(195, 70);
            this.DexterButton.Name = "DexterButton";
            this.DexterButton.Size = new System.Drawing.Size(75, 31);
            this.DexterButton.TabIndex = 1;
            this.DexterButton.Text = "dexter";
            this.DexterButton.UseVisualStyleBackColor = true;
            this.DexterButton.Click += new System.EventHandler(this.DexterButton_Click);
            // 
            // MediumButton
            // 
            this.MediumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumButton.Location = new System.Drawing.Point(310, 70);
            this.MediumButton.Name = "MediumButton";
            this.MediumButton.Size = new System.Drawing.Size(75, 31);
            this.MediumButton.TabIndex = 2;
            this.MediumButton.Text = "medium";
            this.MediumButton.UseVisualStyleBackColor = true;
            this.MediumButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // SinisterLabel
            // 
            this.SinisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SinisterLabel.Location = new System.Drawing.Point(53, 117);
            this.SinisterLabel.Name = "SinisterLabel";
            this.SinisterLabel.Size = new System.Drawing.Size(100, 23);
            this.SinisterLabel.TabIndex = 3;
            this.SinisterLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DexterLabel
            // 
            this.DexterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexterLabel.Location = new System.Drawing.Point(182, 117);
            this.DexterLabel.Name = "DexterLabel";
            this.DexterLabel.Size = new System.Drawing.Size(100, 23);
            this.DexterLabel.TabIndex = 4;
            this.DexterLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MediumLabel
            // 
            this.MediumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumLabel.Location = new System.Drawing.Point(297, 117);
            this.MediumLabel.Name = "MediumLabel";
            this.MediumLabel.Size = new System.Drawing.Size(100, 23);
            this.MediumLabel.TabIndex = 5;
            this.MediumLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 201);
            this.Controls.Add(this.MediumLabel);
            this.Controls.Add(this.DexterLabel);
            this.Controls.Add(this.SinisterLabel);
            this.Controls.Add(this.MediumButton);
            this.Controls.Add(this.DexterButton);
            this.Controls.Add(this.SinisterButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SinisterButton;
        private System.Windows.Forms.Button DexterButton;
        private System.Windows.Forms.Button MediumButton;
        private System.Windows.Forms.Label SinisterLabel;
        private System.Windows.Forms.Label DexterLabel;
        private System.Windows.Forms.Label MediumLabel;
    }
}

