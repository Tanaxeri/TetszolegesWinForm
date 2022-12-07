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
    public partial class UjAdatGUI : Form
    {
        Adatbazis adatuj = new Adatbazis("localhost", "root", "", "videojatekok");

        public UjAdatGUI()
        {
            InitializeComponent();
        }

        private void UjAdatGUI_Load(object sender, EventArgs e)
        {


        }

        private void UjAdatButton_Uj_Click(object sender, EventArgs e)
        {

            if (adatuj.Hozzaad(JateknevText_Uj.Text, JatekfajText_Uj.Text, (int)JatekevNumUpDown_Uj.Value, JatekPlatText_Uj.Text))
            {

                Program.ujadatGUI.IDText_Uj.Text = "";
                Program.ujadatGUI.JateknevText_Uj.Text = "";
                Program.ujadatGUI.JatekfajText_Uj.Text = "";
                Program.ujadatGUI.JatekevNumUpDown_Uj.Value = JatekevNumUpDown_Uj.Minimum;
                Program.ujadatGUI.JatekPlatText_Uj.Text = "";
                
            }

        }
    }
}
