using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    class PacijentInfo
    {

        private string ime;
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                
                if (value.Length > 20)
                    throw new Exception("Greska: Ime nije validno");
                else ime = value;
            }
            
        }
        private string prezime;
        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                if (value.Length > 20)
                    throw new Exception("Greska: Prezime nije validno");
                else prezime = value;
            }
            
        }
        private DateTime datumRodjenja;
        public DateTime DatumRodjenja
        {
            set
            {
                if (value.CompareTo(DateTime.Now) > 0 )
                    throw new Exception("Greska: Datum nije validan");
                else datumRodjenja = value;
            }
            get
            {
                return datumRodjenja;
            }
        }
        private long maticniBroj;
        public long MaticniBroj
        {
            set
            {
                maticniBroj = value;
            }
            get
            {
                return maticniBroj;
            }
        }
        private char spol;
        private string adresa;
        private string bracnoStanje;
        public PacijentInfo(string ime, string prezime, DateTime datum_rodjenja, long maticni_broj, char spol, string adresa, string bracno_stanje)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datum_rodjenja;
            maticniBroj = maticni_broj;
            bracnoStanje = bracno_stanje;
            this.spol = spol;
            this.adresa = adresa;
        }
        public void IspisiPacijenta()
        {
            Console.WriteLine("Ime : " + Ime + "\nPrezime: " + Prezime + "\nDatum rodjenja: " + (DatumRodjenja.ToLongDateString()) + "\nAdresa: "
                + adresa + "\nMaticni broj: " + maticniBroj + "\nSpol: " + spol + "\nBracno stanje: " + bracnoStanje);
        }
    }
}
