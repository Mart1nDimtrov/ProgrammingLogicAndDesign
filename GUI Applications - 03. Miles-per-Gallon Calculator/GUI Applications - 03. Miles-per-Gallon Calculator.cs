/*
3. Miles-per-Gallon Calculator
Design a GUI program that calculates a car’s gas mileage. The program’s window
should have text boxes that let the user enter the number of gallons of gas the car
holds, and the number of miles it can be driven on a full tank. When a Calculate
MPGbutton is clicked, the program should display the number of miles that the
car may be driven per gallon of gas. Use the following formula to calculate milesper-gallon:
MPG = Miles / Gallons;
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Applications___03.Miles_per_Gallon_Calculator
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
