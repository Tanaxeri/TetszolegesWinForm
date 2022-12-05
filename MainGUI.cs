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
    public partial class MainGUI : Form
    {

        Adatbazis adatmain = new Adatbazis("localhost", "root", "", "videojatekok");
        public MainGUI()
        {
            InitializeComponent();
        }

        private void MainGUI_Load(object sender, EventArgs e)
        {

            JatekevNumUpDown_Main.Maximum = Decimal.MaxValue;
            JatekGrid_felepitese();
            JatekGrid_frissitese();

        }

        private void JatekGrid_frissitese()
        {

            VideojatekAdatai_Grid.Rows.Clear();

            foreach (VideojatekAdat rekord in adatmain.osszesVideojatek())
            {

                int IndexSor = VideojatekAdatai_Grid.Rows.Add();
                DataGridViewRow ujsor = VideojatekAdatai_Grid.Rows[IndexSor];
                ujsor.Cells["id"].Value = rekord.Id;
                ujsor.Cells["jateknev"].Value = rekord.Jateknev;
                ujsor.Cells["faj(mufaj)"].Value = rekord.Faj;
                ujsor.Cells["ev"].Value = rekord.Ev;
                ujsor.Cells["platform"].Value = rekord.Platform;

            }

        }

        private void JatekGrid_felepitese()
        {
            
            DataGridViewColumn col_ID = new DataGridViewColumn();
            {

                col_ID.Name = "ID";
                col_ID.ReadOnly = true;
                col_ID.CellTemplate = new DataGridViewTextBoxCell();
                col_ID.HeaderText = "Videójáték azonosító"; 

            }
            VideojatekAdatai_Grid.Columns.Add(col_ID);

            DataGridViewColumn col_JatekNev = new DataGridViewColumn();
            {

                col_JatekNev.Name = "jateknev";
                col_JatekNev.CellTemplate = new DataGridViewTextBoxCell();
                col_JatekNev.HeaderText = "Videójáték neve";

            }
            VideojatekAdatai_Grid.Columns.Add(col_JatekNev);

            DataGridViewColumn col_Faj = new DataGridViewColumn();
            {

                col_Faj.Name = "faj(mufaj)";
                col_Faj.CellTemplate = new DataGridViewTextBoxCell();
                col_Faj.HeaderText = "Videójáték faja";

            }
            VideojatekAdatai_Grid.Columns.Add(col_Faj);

            DataGridViewColumn col_Ev = new DataGridViewColumn();
            {

                col_Ev.Name = "ev";
                col_Ev.CellTemplate = new DataGridViewTextBoxCell();
                col_Ev.HeaderText = "Videójáték éve";

            }
            VideojatekAdatai_Grid.Columns.Add(col_Ev);

            DataGridViewColumn col_Platform = new DataGridViewColumn();
            {

                col_Platform.Name = "platform";
                col_Platform.CellTemplate = new DataGridViewTextBoxCell();
                col_Platform.HeaderText = "Videójáték platformja";

            }
            VideojatekAdatai_Grid.Columns.Add(col_Platform);

            VideojatekAdatai_Grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void VideojatekAdatai_Grid_SelectionChanged(object sender, EventArgs e)
        {
            if (VideojatekAdatai_Grid.SelectedRows.Count < 1)
            {

                return;

            }
            DataGridViewRow row = VideojatekAdatai_Grid.SelectedRows[0];
            if (row.Cells["id"].Value == null)
            {

                return;

            }
            IDText_Main.Text = row.Cells["id"].Value.ToString();
            JateknevText_Main.Text = row.Cells["jateknev"].Value.ToString();
            JatekfajText_Main.Text = row.Cells["faj(mufaj)"].Value.ToString();
            JatekevNumUpDown_Main.Value = decimal.Parse(row.Cells["ev"].Value.ToString());
            JatekPlatText_Main.Text = row.Cells["platform"].Value.ToString();

        }

        private void UjAdatButton_Main_Click(object sender, EventArgs e)
        {

            if (adathiany())
            {

                return;

            }
            if (adatmain.Hozzaad(JateknevText_Main.Text, JatekfajText_Main.Text, (int)JatekevNumUpDown_Main.Value, JatekPlatText_Main.Text))
            {

                Program.mainGUI.IDText_Main.Text = "";
                Program.mainGUI.JateknevText_Main.Text = "";
                Program.mainGUI.JatekfajText_Main.Text = "";
                Program.mainGUI.JatekevNumUpDown_Main.Value = JatekevNumUpDown_Main.Minimum;
                Program.mainGUI.JatekPlatText_Main.Text = "";

            }
            JatekGrid_frissitese();

        }

        private void AdatModButton_Main_Click(object sender, EventArgs e)
        {

            if (adathiany())
            {

                return;

            }
            if (adatmain.Modosit(int.Parse(IDText_Main.Text), JateknevText_Main.Text, JatekfajText_Main.Text, (int)JatekevNumUpDown_Main.Value, JatekPlatText_Main.Text))
            {

                Program.mainGUI.IDText_Main.Text = "";
                Program.mainGUI.JateknevText_Main.Text = "";
                Program.mainGUI.JatekfajText_Main.Text = "";
                Program.mainGUI.JatekevNumUpDown_Main.Value = JatekevNumUpDown_Main.Minimum;
                Program.mainGUI.JatekPlatText_Main.Text = "";

            }
            JatekGrid_frissitese();

        }

        private void AdatTorButton_Main_Click(object sender, EventArgs e)
        {

            if (adathiany())
            {

                return;

            }
            if (adatmain.Torol(int.Parse(IDText_Main.Text)))
            {

                Program.mainGUI.IDText_Main.Text = "";
                Program.mainGUI.JateknevText_Main.Text = "";
                Program.mainGUI.JatekfajText_Main.Text = "";
                Program.mainGUI.JatekevNumUpDown_Main.Value = JatekevNumUpDown_Main.Minimum;
                Program.mainGUI.JatekPlatText_Main.Text = "";

            }
            JatekGrid_frissitese();

        }

        private bool adathiany()
        {

            if (string.IsNullOrEmpty(JateknevText_Main.Text))
            {

                MessageBox.Show("Adjon meg egy játéknevet!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                JateknevText_Main.Focus();
                return true;

            }
            if (string.IsNullOrEmpty(JatekfajText_Main.Text))
            {

                MessageBox.Show("Adjon meg egy játék fajtát!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                JatekfajText_Main.Focus();
                return true;

            }
            if (string.IsNullOrEmpty(JatekPlatText_Main.Text))
            {

                MessageBox.Show("Adjon meg egy játék platformot!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                JatekPlatText_Main.Focus();
                return true;

            }

            return false;
        }

    }
}
