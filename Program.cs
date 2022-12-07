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
        static public UjAdatGUI ujadatGUI = null;
        static public ModositAdatGUI modositadatGUI = null;
        static public TorolAdatGUI toroladatGUI = null;

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            toroladatGUI = new TorolAdatGUI();
            modositadatGUI = new ModositAdatGUI();
            ujadatGUI = new UjAdatGUI();
            mainGUI = new MainGUI();
            Application.Run(mainGUI);
        }
    }
}
