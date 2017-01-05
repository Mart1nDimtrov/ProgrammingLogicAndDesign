/*
5. Property Tax
A county collects property taxes on the assessment value of property, which is 60
percent of the property’s actual value. If an acre of land is valued at $10,000, its
assessment value is $6,000. The property tax is then $0.64 for each $100 of the
assessment value. The tax for the acre assessed at $6,000 will be $38.40. Design a
GUI program that displays the assessment value and property tax when a user
enters the actual value of a property.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Applications___05.Property_Tax
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AssesmentValueLabel());
        }
    }
}
