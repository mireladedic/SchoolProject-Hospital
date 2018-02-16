using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    class MedicinskiRadnik : Uposlenik
    {
        private double bonus;
        private double iznosBonusa = 0;
        public int brojPacijenata = 0;

        public MedicinskiRadnik(string ime, string prezime, string naziv, double plata, double bonus) : base(ime, prezime, naziv, plata)
        {
            this.bonus = bonus;
        }
        public void DodajBonus()
        {
            if (brojPacijenata > 20)
                return;
            iznosBonusa += bonus;
            brojPacijenata++;
        }



        public override string ToString()
        {
            return "uposlenik " + Ime + " " + Prezime + " " + Naziv + "\nplata " + Plata + "\niznos bonusa " + iznosBonusa + "\nbonus " + bonus + "\nbroj pacijenata " + brojPacijenata;
        }
      
    }
}
