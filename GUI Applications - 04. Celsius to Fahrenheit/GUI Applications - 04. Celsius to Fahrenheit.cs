/*
4. Celsius to Fahrenheit
Design a GUI program that converts Celsius temperatures to Fahrenheit temperatures. The user should be able to enter a Celsius temperature, click a button, and
then see the equivalent Fahrenheit temperature. Use the following formula to make
the conversion:
F = (9 / 5) * C + 32;
F is the Fahrenheit temperature and C is the Celsius temperature.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Applications___04.Celsius_to_Fahrenheit
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
            Application.Run(new FarhenheitLabel());
        }
    }
}
