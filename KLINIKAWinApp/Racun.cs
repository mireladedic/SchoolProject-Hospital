using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLINIKAWinApp
{
    public class Racun: IPlacanje
    {
        private double iznos;
        private double pdv;
        private int brojRata = 0;
        private int brojPreostalihRata = 0;
        private long brojRacuna = 0;
        private bool placen = false;
        private double iznosRate = 0;

        //...INTERFACE
        private VrstaPlacanjaRacuna _Vrsta;
        private List<StavkeRacuna> _StavkeRacuna;
        //...INTERFACE
        public VrstaPlacanjaRacuna VrstaPlacanja
        {
            get
            {
                return _Vrsta;
            }

            set
            {
                _Vrsta = value;
            }
        }

        public List<StavkeRacuna> Stavke
        {
            get
            {
                return _StavkeRacuna;
            }

            set
            {
                _StavkeRacuna = value;
            }
        }

        public Racun(double iznos, int brojRata, long brojRacuna, bool redovni,VrstaPlacanjaRacuna vrsta,List<StavkeRacuna> stavke)
        {
            this.Iznos = iznos;
            this.BrojRata = brojRata;
            this.BrojRacuna = brojRacuna;

            VrstaPlacanja = vrsta;
            Stavke = stavke;
            Placen = false;
            pdv = Iznos * .17;

            if(vrsta == VrstaPlacanjaRacuna.Rate)
            {
                if (!redovni)
                    this.Iznos = this.Iznos + this.Iznos * 0.15;
                IznosRate = this.Iznos / this.BrojRata;
            }

            if (_Vrsta.Equals(VrstaPlacanjaRacuna.Potpuno)){
                if (redovni)
                {
                    this.Iznos = (this.Iznos - this.Iznos * 0.1);
                }
            }
        }

        public void DodajStavku(StavkeRacuna s)
        {
            Stavke.Add(s);
        }

        public double PlatiRacun(bool redovni,double kes)
        {
            if (Placen)
                throw new Exception("Racun je vec placen");
            if(_Vrsta == VrstaPlacanjaRacuna.Rate)
            {
                if(BrojPreostalihRata > 0)
                {
                    if (kes >= IznosRate)
                    {
                        BrojPreostalihRata--;
                        if (BrojPreostalihRata == 0)
                            Placen = true;

                        return kes - IznosRate;
                    }
                    else
                        throw new Exception("Nedovoljno sredstava");
                }
            }
            else
            {
                if (kes >= Iznos)
                {
                    Placen = true;
                    return (kes - Iznos);
                }
                else
                    throw new Exception("Nedovoljno sredstava");
            }

            throw new Exception("Doslo je do greske u placanju");
        }


       /* public override string ToString()
        {
            return "iznos " + Iznos + "\nbroj rata " + BrojRata + "\niznos rate " + IznosRate + "\nbroj preostalih rata " + BrojPreostalihRata;
        }
        */
        public double Iznos
        {
            get
            {
                return iznos;
            }

            set
            {
                iznos = value;
            }
        }

        public int BrojRata
        {
            get
            {
                return brojRata;
            }

            set
            {
                brojRata = value;
            }
        }

        public int BrojPreostalihRata
        {
            get
            {
                return brojPreostalihRata;
            }

            set
            {
                brojPreostalihRata = value;
            }
        }

        public long BrojRacuna
        {
            get
            {
                return brojRacuna;
            }

            set
            {
                brojRacuna = value;
            }
        }

        public bool Placen
        {
            get
            {
                return placen;
            }

            set
            {
                placen = value;
            }
        }

        public double IznosRate
        {
            get
            {
                return iznosRate;
            }

            set
            {
                iznosRate = value;
            }
        }
  
    }
}
