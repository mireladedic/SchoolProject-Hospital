using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    public enum VrstaBolovanja { Bolest, Alergija };
    class Bolest
    {
        private string naziv;
        private DateTime vrijemeBolovanja;
        private string opis;
        private VrstaBolovanja vrstaBolovanja;

        public Bolest(string naziv, DateTime vrijemeBolovanja, string opis, VrstaBolovanja vrstaBolovanja)
        {
            this.naziv = naziv;
            this.vrijemeBolovanja = vrijemeBolovanja;
            this.opis = opis;
            this.vrstaBolovanja = vrstaBolovanja;
        }

     /*   public Bolest UnesiBolest()
        {
            Console.WriteLine("naziv bolesti: ");
            string n = Console.ReadLine();
            Console.WriteLine("vrijeme bolovanja: ");
            DateTime datum = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("opis bolesti: ");
            string o = Console.ReadLine();
            Console.WriteLine("vrsta bolovanja(Bolest/Alergija): ");
            string vrsta = Console.ReadLine();
            if (vrsta.ToLower() == "bolest") vrstaBolovanja = VrstaBolovanja.Bolest;
            else if (vrsta.ToLower() == "alergija") vrstaBolovanja = VrstaBolovanja.Alergija;
            Bolest b = new Bolest(n, datum, o, vrstaBolovanja);
            return b;
        }
        */
        public void IspisiBolest()
        {
            Console.WriteLine("Bolest:");
            Console.WriteLine("naziv bolesti: ",naziv);
            Console.WriteLine("vrijeme bolovanja: ",vrijemeBolovanja);
            Console.WriteLine("opis bolesti: ",opis);
            Console.WriteLine("vrsta bolovanja: ",vrstaBolovanja);
        }

    }
}
