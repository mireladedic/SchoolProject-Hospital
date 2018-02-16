using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLINIKAWinApp
{
   public abstract class Uposlenik
    {
        private double plata;
        private string ime;
        private string prezime;
        private string naziv;
        private string username;
        private string password;
        private Image slika;
        private Uloga uloga;
        public Uposlenik(double plata, string ime, string prezime, string naziv)
        {
            this.plata = plata;
            this.ime = ime;
            this.prezime = prezime;
            this.naziv = naziv;
        }
        public Uposlenik(double plata, string ime, string prezime, string naziv, string username, string password)
        {
            this.plata = plata;
            this.ime = ime;
            this.prezime = prezime;
            this.naziv = naziv;
            this.Username = username;
            this.Password = password;
        }
        public Uposlenik(double plata, string ime, string prezime, string naziv, string username, string password, Image image)
        {
            this.plata = plata;
            this.ime = ime;
            this.prezime = prezime;
            this.naziv = naziv;
            this.Username = username;
            this.Password = password;
            this.Slika = image;
        }
        public void DajUlogu(Uloga u)
        {
            this.uloga = u;
        }
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
        public Uloga Uloga
        {
            get
            {
                return uloga;
            }

            set
            {
                uloga = value;
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

        public string Username { get { return username; } set { username = value; } }
        public string Password { get {return password; } set { password = value; } }
        public Image Slika { get {return slika; } set { slika = value; } }

        /*  public virtual void IspisiUposlenika()
          {
              Console.WriteLine("uposlenik {0} {1} {2} ",Ime,Prezime,Naziv);
              Console.WriteLine("plata {0}",Plata);

          }
       */
    }
}
