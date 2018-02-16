using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    class Pacijent
    {
        private bool hitan = false;
        private PacijentInfo pacijentInfo;
        private DateTime datum_prijema;
        private Knjizica aktivna_knjizica = null;
        private bool redovni = false;
        private int brojPosjeta = 0;
        private int brojUCekaonici = 0;
        private Ordinacija trenutnaOrdinacija = null;
        private Karton Karton { get; set; }
        private Knjizica Knjizica { get; set; }
        private List<Racun> Racuni;
       
        public Pacijent(string ime, string prezime, DateTime datum_rodjenja, long maticni_broj, char spol, string adresa, string bracno_stanje)
        {
            pacijentInfo = new PacijentInfo(ime, prezime, datum_rodjenja, maticni_broj, spol, adresa, bracno_stanje);
            Racuni = new List<Racun>();
            
        }

        public List<Racun> DajNeplaceneRacune()
        {
            return Racuni.FindAll(r =>
            {
                return !r.Placen;
            });
        }
        public List<Racun> DajRacune()
        {
            return Racuni;
        }

        
        public long DajMaticniBroj()
        {
            return pacijentInfo.MaticniBroj;
        }
        public void IspisiPacijenta()
        {
            pacijentInfo.IspisiPacijenta();
        }

        public void DodajKnjizicu(int id, DateTime datum_izdavanja, DateTime do_kad_vazi)
        {
            Knjizica = new Knjizica(id, datum_izdavanja, do_kad_vazi);
        }

        public void DodajRacun(Racun racun)
        {
            
            Racuni.Add(racun);
        }
        public void PlatiRacun(Racun racun, double kes)
        {
            racun.PlatiRacun(redovni, kes);
        }

        public int NovaOrdinacija(Ordinacija ordinacija)
        {
            if (ordinacija == trenutnaOrdinacija)
                throw new Exception("Pacijent je vec u toj ordinaciji");
            trenutnaOrdinacija = ordinacija;
            brojUCekaonici = trenutnaOrdinacija.cekaonica.DodajURed();
            return brojUCekaonici;
        }

        public void OznaciHitan()
        {
            hitan = true;
        }
        public void ZabiljeziPosjetu()
        {
            brojPosjeta++;
            if (brojPosjeta > 3)
                redovni = true;
        }
        public bool JeLiRedovan()
        {
            return redovni;
        }
        
        public void DodajKarton()
        {
            Karton = new Karton(pacijentInfo);
        }
        public void DodajPregled(Pregled pregled)
        {
            try{
                Karton.DodajPregled(pregled);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        
        public void IspisiPregledP()
        {
            Karton.IspisiPregledKarton();
           
        }
        
        public void DodajBolesti(List<Bolest> bolesti)
        {
            Karton.DodajBolesti(bolesti);
        }
        public void DodajBolest(Bolest bolest)
        {
            Karton.DodajBolest(bolest);
        }
        public void DodajTerapiju(Terapija terapija)
        {
           
            Karton.DodajTerapiju(terapija);
        }

        public void DodajMisljenje(string misljenje)
        {
            Karton.DodajZakljucak(misljenje);
        }
        public Karton DajKarton()
        {
            return Karton;
        }

        public void IspisiKartonPacijenta()
        {
            IspisiPacijenta();
            Karton.IspisiKarton();
        }
        public void DodajPorodicnoStanje(string stanje)
        {
            Karton.DodajZdravstvenoStanjePorodice(stanje);
           
        }
    }
}
