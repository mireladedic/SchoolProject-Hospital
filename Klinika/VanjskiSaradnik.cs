using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    class VanjskiSaradnik : Uposlenik
    {
        public VanjskiSaradnik(string ime, string prezime, string naziv, double plata) : base(ime, prezime, naziv, plata) { }

        public override string ToString()
        {
            return "uposlenik " + Ime + " " + Prezime + " " + Naziv + "\nplata " + Plata;
        }
    }
}
