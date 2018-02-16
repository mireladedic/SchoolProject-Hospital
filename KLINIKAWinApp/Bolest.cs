using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLINIKAWinApp
{
    public enum VrstaBolovanja { Bolest ,Alergija };
    public class Bolest
    {
        private string naziv;
        private DateTime vrijemeBolovanja;
        private string opis;
        private VrstaBolovanja vrstaBolovanja;

        public Bolest(string naziv, DateTime vrijemeBolovanja, string opis, VrstaBolovanja vrstaBolovanja)
        {
            this.Naziv = naziv;
            this.VrijemeBolovanja = vrijemeBolovanja;
            this.opis = opis;
            this.vrstaBolovanja = vrstaBolovanja;
        }

        public string Naziv { get { return naziv; } set { naziv = value; } }
        public DateTime VrijemeBolovanja { get { return vrijemeBolovanja; } set { vrijemeBolovanja = value; } }

        /* public override string ToString()
         {
             return "Bolest:\nnaziv bolesti: " + naziv + "\nvrijemebolovanja: " + vrijemeBolovanja + "\nopis bolesti: " + opis + "\nvrsta bolovanja: " + vrstaBolovanja;
         }
         */
    }
}
