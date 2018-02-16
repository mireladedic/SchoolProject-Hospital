using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLINIKAWinApp
{
    public class PacijentInfo
    {
        private string ime;
        private string prezime;
        private DateTime datumRodjenja;
        private long maticniBroj;
        private char spol;
        private string adresa;
        private string bracnoStanje;

        public PacijentInfo(string ime, string prezime, DateTime datumRodjenja, long maticniBroj, char spol, string adresa, string bracnoStanje)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.DatumRodjenja = datumRodjenja;
            this.MaticniBroj = maticniBroj;
            this.Spol = spol;
            this.Adresa = adresa;
            this.BracnoStanje = bracnoStanje;
        }

        public override string ToString()
        {
            return ime + " " + prezime + "\n" + datumRodjenja + " " + maticniBroj + "\n" + adresa + "\n" + spol + " " + bracnoStanje;
        }

        public string Ime
        {
            get
            {
                return ime;
            }

            set
            {
                if (value.Length > 20) throw new Exception("Greska: Ime nije validno");
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
                if (value.Length > 20) throw new Exception("Greska: Prezime nije validno");
                prezime = value;
            }
        }

        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }

            set
            {
                if (value.CompareTo(DateTime.Now) > 0)
                    throw new Exception("Greska: Datum nije validan");
                datumRodjenja = value;
            }
        }

        public long MaticniBroj
        {
            get
            {
                return maticniBroj;
            }

            set
            {
                maticniBroj = value;
            }
        }

        public char Spol
        {
            get
            {
                return spol;
            }

            set
            {
                spol = value;
            }
        }

        public string Adresa
        {
            get
            {
                return adresa;
            }

            set
            {
                adresa = value;
            }
        }

        public string BracnoStanje
        {
            get
            {
                return bracnoStanje;
            }

            set
            {
                bracnoStanje = value;
            }
        }

     
    }
}
