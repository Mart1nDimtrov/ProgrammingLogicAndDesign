using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Applications___04.Celsius_to_Fahrenheit
{
    public partial class FarhenheitLabel : Form
    {
        public FarhenheitLabel()
        {
            InitializeComponent();
        }

        private void FarhenheitLabel_Load(object sender, EventArgs e)
        {

        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            var celsius = double.Parse(CelsiusTextBox.Text);
            var fahrenheit = (9.0 / 5.0) * celsius + 32.0;
            var fahrenheitString = $"{fahrenheit} degrees Fahrenheit";
            FahrenheitLabel.Text = Convert.ToString(fahrenheitString);
        }
    }
}
