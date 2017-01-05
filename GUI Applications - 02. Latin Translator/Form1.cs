using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Applications___02.Latin_Translator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var medium = "center";
            MediumLabel.Text = medium;
        }

        private void SinisterButton_Click(object sender, EventArgs e)
        {
            var sinister = "left";
            SinisterLabel.Text = sinister;
        }

        private void DexterButton_Click(object sender, EventArgs e)
        {
            var dexter = "right";
            DexterLabel.Text = dexter;
        }
    }
}
