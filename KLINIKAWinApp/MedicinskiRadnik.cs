using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLINIKAWinApp
{
    public class MedicinskiRadnik : Uposlenik
    {
        private double bonus;
        private double iznosBonusa = 0;
        private int brojPacijenata = 0;


        public MedicinskiRadnik(string ime,string prezime,string naziv,double plata,double bonus) : base(plata,ime, prezime, naziv)
        {
            this.Bonus = bonus;
        }
        public MedicinskiRadnik(string ime, string prezime, string username, string password, string naziv, double plata, double bonus, Image image) : base(plata, ime, prezime, naziv, username, password, image)
        {
            this.Bonus = bonus;
        }

        public double Bonus { get { return bonus; } set { bonus = value; } }

        public void DodajBonus()
        {
            if (brojPacijenata > 20)
                return;
            iznosBonusa += Bonus;
            brojPacijenata++;
        }
    }
}
