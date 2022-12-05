using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TetszolegesWinForm
{
    internal class Adatbazis
    {

        private MySqlConnection sqlconnection;
        private MySqlCommand sqlcommand;
        private string hibauzenet = null;

        public Adatbazis(string host, string user, string password, string db)
        {

            MySqlConnectionStringBuilder stringbuilder = new MySqlConnectionStringBuilder();
            stringbuilder.Server = host;
            stringbuilder.UserID = user;
            stringbuilder.Password = password;
            stringbuilder.Database = db;
            sqlconnection = new MySqlConnection(stringbuilder.ConnectionString);
            sqlcommand = sqlconnection.CreateCommand();

        }

        private bool DataOpen()
        {

            try
            {

                if (sqlconnection.State != System.Data.ConnectionState.Open)
                {

                    sqlconnection.Open();

                }

            }
            catch (MySqlException ex)
            {

                hibauzenet = ex.Message;
                return false;
                
            }

            return true;
        }
        private bool DataClose()
        {

            try
            {

                if (sqlconnection.State != System.Data.ConnectionState.Closed)
                {

                    sqlconnection.Close();

                }

            }
            catch (MySqlException ex)
            {

                hibauzenet = ex.Message;
                return false;

            }

            return true;
        }

        public List<VideojatekAdat> osszesVideojatek()
        {

           List<VideojatekAdat> videojatekAdats = new List<VideojatekAdat>();
            sqlcommand.CommandText = "SELECT `id`, `jateknev`, `faj(mufaj)`, `ev`, `platform` FROM `jatekok` WHERE 1";
            if (DataOpen())
            {

                using (MySqlDataReader dr = sqlcommand.ExecuteReader())
                {

                    while (dr.Read())
                    {

                        VideojatekAdat uj = new VideojatekAdat(dr.GetInt32("id"), dr.GetString("jateknev"), dr.GetString("faj(mufaj)"), dr.GetInt32("ev"), dr.GetString("platform"));
                        videojatekAdats.Add(uj);

                    }

                }

            }
            else
            {

                MessageBox.Show(hibauzenet);

            }
            DataClose();

            return videojatekAdats;
        }

        public bool Hozzaad(string jateknev, string faj, int ev, string platform)
        {

            sqlcommand.CommandText = "INSERT INTO `jatekok` (`id`, `jateknev`, `faj(mufaj)`, `ev`, `platform`) VALUES (NULL, @jateknev, @faj, @ev, @platform)";
            sqlcommand.Parameters.Clear();
            sqlcommand.Parameters.AddWithValue("@jateknev", jateknev);
            sqlcommand.Parameters.AddWithValue("@faj", faj);
            sqlcommand.Parameters.AddWithValue("@ev", ev);
            sqlcommand.Parameters.AddWithValue("@platform", platform);
            DataOpen();
            try
            {

                if (sqlcommand.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("Adatot sikeresen rögzítettük!", "Sikeres!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return true;
                }
                else
                {

                    MessageBox.Show("Adatot nem sikerült rögzíteni!", "Sikertelen!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;

                }


            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "Sikertelen!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            DataClose();

            return true;
        }

        public bool Modosit(int id, string jateknev, string faj, int ev, string platform)
        {

            sqlcommand.CommandText = "UPDATE `jatekok` SET `jateknev` = @jateknev, `faj(mufaj)` = @faj, `ev` = @ev, `platform` = @platform WHERE id = @id";
            sqlcommand.Parameters.Clear();
            sqlcommand.Parameters.AddWithValue("@id", id);
            sqlcommand.Parameters.AddWithValue("@jateknev", jateknev);
            sqlcommand.Parameters.AddWithValue("@faj", faj);
            sqlcommand.Parameters.AddWithValue("@ev", ev);
            sqlcommand.Parameters.AddWithValue("@platform", platform);
            DataOpen();
            if (sqlcommand.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("Adatok módosítása sikeres volt!", "Sikeres!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return true;
                DataClose();

            }
            else
            {

                MessageBox.Show("Az adatok módosítása sikertelen volt!", "Sikertelen!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }

            return true;
        }

        public bool Torol(int id)
        {

            sqlcommand.CommandText = "DELETE FROM `jatekok` WHERE `id` = @id";
            sqlcommand.Parameters.Clear();
            sqlcommand.Parameters.AddWithValue("@id", id);
            DataOpen();
            if (sqlcommand.ExecuteNonQuery() == 1)
            {

                MessageBox.Show("Adat törlése sikeres volt!", "Sikeres!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return true;

                DataClose();
            }
            else
            {

                MessageBox.Show("Az adat törlése sikertelen volt!", "Sikertelen!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }

        }

    }
}
