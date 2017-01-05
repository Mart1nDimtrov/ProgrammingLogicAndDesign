using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Applications___01.Name_and_Address
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowInfoButton_Click(object sender, EventArgs e)
        {
            var name = "Steven Marcus";
            var adress = Environment.NewLine + "274 Baily Drive" + Environment.NewLine + "Waynesville, NC 27999";
            InfoLabel.Text = name + " " + adress;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InfoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
