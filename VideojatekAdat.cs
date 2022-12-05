using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetszolegesWinForm
{
    internal class VideojatekAdat
    {

        int id;
        string jateknev;
        string faj;
        int ev;
        string platform;

        public int Id { get => id; set => id = value; }
        public string Jateknev { get => jateknev; set => jateknev = value; }
        public string Faj { get => faj; set => faj = value; }
        public int Ev { get => ev; set => ev = value; }
        public string Platform { get => platform; set => platform = value; }

        public VideojatekAdat(int id, string jateknev, string faj, int ev, string platform)
        {
            Id = id;
            Jateknev = jateknev;
            Faj = faj;
            Ev = ev;
            Platform = platform;
        }



    }
}
