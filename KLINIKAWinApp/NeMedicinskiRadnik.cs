using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLINIKAWinApp
{
    public class NeMedicinskiRadnik : Uposlenik
    {
        public NeMedicinskiRadnik(string ime,string prezime,string naziv,double plata) : base(plata, ime, prezime, naziv) { }
        public NeMedicinskiRadnik(string ime, string prezime, string naziv, string username, string password, double plata, Image image) : base(plata, ime, prezime, naziv, username, password, image) { }
        /*  public override string ToString()
          {
              return "uposlenik " + Ime + " " + Prezime + " " + Naziv + "\nplata " + Plata;
          }
          */
    }
}
