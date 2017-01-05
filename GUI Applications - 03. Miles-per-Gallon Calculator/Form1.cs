using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Applications___03.Miles_per_Gallon_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GallonsTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MilesTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void CalculateMilesButton_Click(object sender, EventArgs e)
        {
            var gallons = double.Parse(GallonsTextBox.Text);
            var miles = double.Parse(MilesTextBox.Text);

            var milesPerGallon = Convert.ToString(miles / gallons);
            MilesPerGalonLabel.Text = milesPerGallon + " miles";
        }

        private void MilesPerGalonLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
