using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetszolegesWinForm
{
    internal static class Program
    {

        static public MainGUI mainGUI = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainGUI = new MainGUI();
            Application.Run(mainGUI);
        }
    }
}
