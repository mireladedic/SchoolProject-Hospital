using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    class Ordinacija
    {
        public Cekaonica cekaonica;
        private Oprema oprema = null;
        private List<Uposlenik> uposlenici;
        private string naziv;
        

        public Ordinacija(string naziv, Oprema oprema)
        {
            this.naziv = naziv;
            this.oprema = oprema;
            uposlenici = new List<Uposlenik>();
            cekaonica = new Cekaonica();
        }

        public void DodajUposlenike(List<Uposlenik> up)
        {
            uposlenici.AddRange(up);
        }

        public void DodajUposlenika(Uposlenik up)
        {
            uposlenici.Add(up);
        }

        public void OznaciUKvaru()
        {
            oprema.UKvaru();
        }
        public void OznaciNijeUKvaru()
        {
            oprema.NijeUKvaru();
        }

        public bool DaLiJeUKvaru()
        {
            return oprema.DaLiJeUKvaru();
        }
        public void OznaciZauzeta()
        {
            oprema.Zauzeta();
        }
        public void OznaciSlobodna()
        {
            oprema.Slobodna();
        }
        public bool Slobodna()
        {
            return oprema.DaLiJeZauzeta();
        }
    }
}
