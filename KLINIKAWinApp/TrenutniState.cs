using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLINIKAWinApp
{
    public static class TrenutniState
    {
        public static Uposlenik prijavljeni;
        public static List<Uposlenik> uposlenici = new List<Uposlenik>();
        public static List<Pacijent> pacijenti = new List<Pacijent>();
        public static List<Ordinacija> ordinacije = new List<Ordinacija>();
        //public static Klinika klinika;
        public static List<Oprema> oprema = new List<Oprema>();

        public static Pacijent odabraniPacijent = null;
        
        public static void DodajUposlenika(Uposlenik u)
        {
            uposlenici.Add(u);
        }

        public static void DodajPacijenta(Pacijent p)
        {
            pacijenti.Add(p);
        }
        public static void DodajTerapiju(Pacijent p, Terapija t)
        {
            p.DodajTerapiju(t);
        }
    }
}
