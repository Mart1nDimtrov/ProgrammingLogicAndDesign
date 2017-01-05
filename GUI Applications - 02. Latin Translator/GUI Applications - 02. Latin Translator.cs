/*
2. Latin Translator
Look at the following list of Latin words and their meanings:
Latin English
sinister left
dexter right
medium center
Design a GUI program that translates the Latin words to English. The window
should have three buttons, one for each Latin word. When the user clicks a button,
the program displays the English translation in a label component.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Applications___02.Latin_Translator
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
