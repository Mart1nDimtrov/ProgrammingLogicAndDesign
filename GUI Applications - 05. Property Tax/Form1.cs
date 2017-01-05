using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Applications___05.Property_Tax
{
    public partial class AssesmentValueLabel : Form
    {
        public AssesmentValueLabel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var actualValue = double.Parse(ActualValueTextBox.Text);
            var assesedValue = actualValue * 0.60;
            AssesmentValueTextBox.Text = $"{assesedValue:F2}";
            var propertyTax = assesedValue * 0.0064;
            PropertyTaxTextBox.Text = $"{propertyTax:F2}";
        }
    }
}
