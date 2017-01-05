/*
1. Name and Address
Design a GUI program that displays your name and address when a button is
clicked. The program’s window should appear as the sketch on the left side of
Figure 15-15 when it runs. When the user clicks the Show Infobutton, the program should display your name and address, as shown in the sketch on the right
side of the figure.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Applications___01.Name_and_Address
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
            Application.Run(new Form1());
        }
    }
}
