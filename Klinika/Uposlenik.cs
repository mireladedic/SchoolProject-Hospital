using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
   
    public abstract class Uposlenik
    {
        private double plata;
        private string ime;
        private string prezime;
        private string naziv;

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                ime = value;
            }
        }

        public string Prezime
        {
            get
            {
                return prezime;
            }

            set
            {
                prezime = value;
            }
        }

        public string Naziv
        {
            get
            {
                return naziv;
            }

            set
            {
                naziv = value;
            }
        }

        public double Plata
        {
            get
            {
                return plata;
            }

            set
            {
                plata = value;
            }
        }

        public Uposlenik(string ime, string prezime, string naziv, double plata)
        {
            this.Plata = plata;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Naziv = naziv;
        }

        /*  public virtual void IspisiUposlenika()
          {
              Console.WriteLine("uposlenik {0} {1} {2} ",Ime,Prezime,Naziv);
              Console.WriteLine("plata {0}",Plata);

          }*/
        override
        public abstract string ToString();
    
    }
}
