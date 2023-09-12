using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bérek2020
{
    internal class Berek
    {
        string Nev;
        string Neme;
        string Reszleg;
        int Belepes;
        int Ber;

        public string Nev1 { get => Nev; set => Nev = value; }
        public string Neme1 { get => Neme; set => Neme = value; }
        public string Reszleg1 { get => Reszleg; set => Reszleg = value; }
        public int Belepes1 { get => Belepes; set => Belepes = value; }
        public int Ber1 { get => Ber; set => Ber = value; }

        public Berek(string nev1, string neme1, string reszleg1, int belepes1, int ber1)
        {
            Nev1 = nev1;
            Neme1 = neme1;
            Reszleg1 = reszleg1;
            Belepes1 = belepes1;
            Ber1 = ber1;
        }

        public Berek(string sor)
        {
            string[] darab = sor.Split(';');
            Nev = darab[0];
            Neme = darab[1];
            Reszleg = darab[2];
            Belepes = int.Parse(darab[3]);
            Ber = int.Parse(darab[4]);
        }
    }
}
