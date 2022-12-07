using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetszolegesWinForm
{
    public partial class ModositAdatGUI : Form
    {
        Adatbazis adatmodosit = new Adatbazis("localhost", "root", "", "videojatekok");

        public ModositAdatGUI()
        {
            InitializeComponent();
        }

        private void AdatModButton_Modosit_Click(object sender, EventArgs e)
        {

            if (adatmodosit.Modosit(int.Parse(IDText_Modosit.Text), JateknevText_Modosit.Text, JatekfajText_Modosit.Text, (int)JatekevNumUpDown_Modosit.Value, JatekPlatText_Modosit.Text))
            {

                Program.mainGUI.IDText_Main.Text = "";
                Program.mainGUI.JateknevText_Main.Text = "";
                Program.mainGUI.JatekfajText_Main.Text = "";
                Program.mainGUI.JatekevNumUpDown_Main.Value = Program.mainGUI.JatekevNumUpDown_Main.Minimum;
                Program.mainGUI.JatekPlatText_Main.Text = "";

            }

            Close();
        }

        private void ModositAdatGUI_Load(object sender, EventArgs e)
        {

            Program.modositadatGUI.IDText_Modosit.Text = MainGUI.ErtekText1;
            Program.modositadatGUI.JateknevText_Modosit.Text = MainGUI.ErtekText2;
            Program.modositadatGUI.JatekfajText_Modosit.Text = MainGUI.ErtekText3;
            Program.modositadatGUI.JatekevNumUpDown_Modosit.Value = MainGUI.ErtekText4;
            Program.modositadatGUI.JatekPlatText_Modosit.Text = MainGUI.ErtekText5;

        }
    }
}
