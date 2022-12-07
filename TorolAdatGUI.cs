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
    public partial class TorolAdatGUI : Form
    {
        Adatbazis adattorol = new Adatbazis("localhost", "root", "", "videojatekok");

        public TorolAdatGUI()
        {
            InitializeComponent();
        }

        private void AdatTorButton_Torol_Click(object sender, EventArgs e)
        {

            if (adattorol.Torol(int.Parse(IDText_Torol.Text)))
            {

                Program.mainGUI.IDText_Main.Text = "";
                Program.mainGUI.JateknevText_Main.Text = "";
                Program.mainGUI.JatekfajText_Main.Text = "";
                Program.mainGUI.JatekevNumUpDown_Main.Value = Program.mainGUI.JatekevNumUpDown_Main.Minimum;
                Program.mainGUI.JatekPlatText_Main.Text = "";

            }

            Close();
        }

        private void TorolAdatGUI_Load(object sender, EventArgs e)
        {

            Program.toroladatGUI.IDText_Torol.Text = MainGUI.ErtekText1;
            Program.toroladatGUI.JateknevText_Torol.Text = MainGUI.ErtekText2;
            Program.toroladatGUI.JatekfajText_Torol.Text = MainGUI.ErtekText3;
            Program.toroladatGUI.JatekevNumUpDown_Torol.Value = MainGUI.ErtekText4;
            Program.toroladatGUI.JatekPlatText_Torol.Text = MainGUI.ErtekText5;

        }
    }
}
