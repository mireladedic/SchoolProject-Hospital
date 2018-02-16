using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{

    class Anamneza
    {

        public delegate void Odziv(string rezultat, string misljenje, string porodicno_stanje, int broj_bolesti);

        public static void Spremi(Pacijent pacijent, List<Bolest> bolesti, string misljenje, string porodicno_stanje, Odziv odziv)
        {
            if (pacijent == null)
                throw new Exception("Pacijent nije inicijaliziran.");
            pacijent.DodajKarton();
            pacijent.DodajBolesti(bolesti);
            pacijent.DodajMisljenje(misljenje);
            pacijent.DodajPorodicnoStanje(porodicno_stanje);
            odziv("[INFO] Anamneza uspjesno provedena.", misljenje, porodicno_stanje, bolesti.Count);
        }
        public static void PokreniProtokol(Pacijent pacijent, string misljenje, string porodicno_stanje, List<Bolest> bolesti)
        {
            Spremi(pacijent, bolesti, misljenje, porodicno_stanje, (rez, m, ps, bb) =>
            {
                Console.WriteLine(rez);
                Console.WriteLine("Upisani podaci: ");
                Console.WriteLine("Misljenje: " + m);
                Console.WriteLine("Porodicno stanje: " + ps);
                Console.WriteLine("Upisanih bolesti i alergija: " + bb);
            });
        }


    }
}
