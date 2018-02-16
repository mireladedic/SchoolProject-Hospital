using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    class Klinika
    {
        private List<Ordinacija> ordinacije;
        private List<Uposlenik> uposlenici;
        private List<Pacijent> pacijenti;
        private static Anamneza anamneza;

        public Klinika()
        {
            ordinacije = new List<Ordinacija>();
            uposlenici = new List<Uposlenik>();
            pacijenti = new List<Pacijent>();
            anamneza = new Anamneza();
        }
    
   /*     public List<Racun> DajRacune()
        {
            Console.WriteLine("Maticni broj: ");
            long m_b = long.Parse(Console.ReadLine());
            Pacijent p = PronadjiPacijenta(m_b);
            List<Racun> racuni = p.DajNeplaceneRacune();
            return racuni;
        }
   */
        public void Analiziraj()
        {
            Console.WriteLine("Najposjeceniji doktori: ");
            List<MedicinskiRadnik> najposjeceniji = DajMedicinskeUposlenike().OrderByDescending((a) => { return a.brojPacijenata; }).ToList<MedicinskiRadnik>();

            najposjeceniji.ForEach(mr =>
            {
                Console.WriteLine(mr.ToString());
            });
        }
        public List<Uposlenik> DajUposlenike()
        {
            return uposlenici;
        }
        public List<MedicinskiRadnik> DajMedicinskeUposlenike()
        {
            return uposlenici.FindAll(delegate (Uposlenik u) { return "MedicinskiRadnik" == u.GetType().Name; }).ConvertAll(x => (MedicinskiRadnik) x);
        }
        public Uposlenik DajUposlenika(string ime, string prezime)
        {
            return uposlenici.Find(delegate (Uposlenik u) { return u.Ime == ime && u.Prezime == prezime; });
        }

        public void DodajUposlenika(Uposlenik uposlenik)
        {
            uposlenici.Add(uposlenik);
        }
        public void RegistrujPregled()
        {
            Console.WriteLine("Maticni broj:");
            long m_b = long.Parse(Console.ReadLine());
            Pacijent p = PronadjiPacijenta(m_b);
            if(p.DajKarton() == null)
            {
                Console.WriteLine("Pacijent nema jos kartona. Zelite li kreirati karton za pacijenta?");
                string o = Console.ReadLine();
                if(o == "da")
                {
                    PokreniAnamnezu(p);
                }
                else
                {
                    RegistrujPregled();
                }
            }
            UnesiPregled(p);
        }

        public void UnesiPregled(Pacijent pacijent)
        {

            if (pacijent.DajKarton() == null)
                throw new Exception("Pacijent nema jos karton.");
            pacijent.ZabiljeziPosjetu();
            Console.WriteLine("Hitan(da/ne): ");
            string unos = Console.ReadLine();
            bool hitan = false;
            if (unos.ToLower() == "da") hitan = true;
            else if (unos.ToLower() == "ne") hitan = false;

            Console.WriteLine("Zabiljeske:");
            string biljeske = Console.ReadLine();

            Console.WriteLine("Datum pregleda: ");
            DateTime datum = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Prva pomoc(Da/Ne):");
            string pp = Console.ReadLine();
            bool prvaPomoc = false;
            if (pp.ToLower() == "da") prvaPomoc = true;
            else if (pp.ToLower() == "ne") prvaPomoc = false;
            else { Console.WriteLine("Pogesan unos.Prva Pomoc."); }

            Console.WriteLine("rezultat pregleda(zivot/smrt): ");
            string rezultat = Console.ReadLine();
            RezultatPregleda rez = RezultatPregleda.zivot;

            string uzrokSmrti = "";
            DateTime vrijemeSmrti = new DateTime();
            bool obdukcija = false;
            DateTime vrijemeObdukcije = new DateTime();

            if (rezultat.ToLower() == "smrt")
            {
                rez = RezultatPregleda.smrt;

                Console.WriteLine("uzrok: ");
                string uzrok = Console.ReadLine();
                uzrokSmrti = uzrok;

                Console.WriteLine("vrijeme: ");
                DateTime vrijeme = DateTime.Parse(Console.ReadLine());
                vrijemeSmrti = vrijeme;

                Console.WriteLine("potrebna odukcija(Da/Ne):");
                string o = Console.ReadLine();
                if (o.ToLower() == "da")
                {
                    obdukcija = true;
                    Console.WriteLine("vrijeme obdukcija: ");
                    DateTime vrijemeO = DateTime.Parse(Console.ReadLine());
                    vrijemeObdukcije = vrijemeO;
                }
                else if (o.ToLower() == "ne")
                {
                    obdukcija = false;
                    vrijemeObdukcije = DateTime.Now;
                }
                else
                {
                    Console.WriteLine("Pogresan Unos. Obdukcija.");
                }
            }
            else if (rezultat.ToLower() == "zivot")
            {
                rez = RezultatPregleda.zivot;
                uzrokSmrti = "";
                vrijemeSmrti = DateTime.Now;
                obdukcija = false;
                vrijemeObdukcije = DateTime.Now;
            }
            
            else
            {
                Console.WriteLine("Pogresan Unos. Rezultat Pregleda.");
            }

            try
            {
                Pregled p = new Pregled(hitan, biljeske, datum, prvaPomoc, rez, uzrokSmrti, vrijemeSmrti, obdukcija, vrijemeObdukcije);
                pacijent.DodajPregled(p);

            }catch(Exception e)
            {
                Console.WriteLine("nije kreiran pregled");
            }
        }

        public void KreirajRacunPacijentu(Pacijent pacijent, Pregled pregled)
        {
            Console.WriteLine("Unesite iznos racuna: ");
            double iznos = double.Parse(Console.ReadLine());
            Console.WriteLine("Unesite nacin placanja (puno/rate): ");
            string placanje = Console.ReadLine();
            int broj_rata = 0;
            VrstaPlacanjaRacuna vrstaPlacanja = VrstaPlacanjaRacuna.Potpuno;
            if(placanje.ToLower() == "puno")
            {
                vrstaPlacanja = VrstaPlacanjaRacuna.Potpuno;
            }
            else
            {
                vrstaPlacanja = VrstaPlacanjaRacuna.Rate;
                Console.WriteLine("Unesite broj rata: ");
                broj_rata = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Da li je pacijentu propisana terapija?(da/ne)");
            string terapija = Console.ReadLine();
            List<StavkeRacuna> stavke = new List<StavkeRacuna>();
            stavke.Add(StavkeRacuna.Pregled);
            if(terapija.ToLower() == "da")
            {
                stavke.Add(StavkeRacuna.Terapija);
            }
            pacijent.DodajRacun(new Racun(iznos, broj_rata, new Random().Next(), pacijent.JeLiRedovan(), vrstaPlacanja, stavke));
        }

        
        public void IspisiPregledPacijenta()
        {
            Console.WriteLine("Maticni broj: ");
            long m_b = long.Parse(Console.ReadLine());
            Pacijent p = PronadjiPacijenta(m_b);
          
            p.IspisiPregledP();
        }
        public void PretraziKartonPacijenta(long maticni_broj)
        {
            Pacijent p = pacijenti.Find(delegate (Pacijent b) { return b.DajMaticniBroj() == maticni_broj; });
            if (p == null)
                throw new Exception("Pacijent sa ovim maticnim brojem nije upisan.");
            p.IspisiKartonPacijenta();
        }

        public Pacijent PronadjiPacijenta(long maticni_broj)
        {
            Pacijent p = pacijenti.Find(delegate (Pacijent b) { return b.DajMaticniBroj() == maticni_broj; });
            if (p == null)
                throw new Exception("Pacijent sa ovim maticnim brojem nije upisan.");
            return p;
        }
        public void PokreniAnamnezu(Pacijent pacijent)
        {
            Console.WriteLine("Unesite bolesti koje su dijagnosticirane pacijentu: ");
            List<Bolest> bolesti = new List<Bolest>();
            while(true)
            {
                Console.WriteLine("Unesite naziv dijagnoze: ");
                string naziv = Console.ReadLine();
                Console.WriteLine("Unesite datum bolovanja: ");
                DateTime datum_bolovanja = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Unesite opis dijagnoze: ");
                string opis = Console.ReadLine();
                Console.WriteLine("Da li je alergija ili bolest?");
                string vrsta = Console.ReadLine();
                VrstaBolovanja vrsta_bolovanja = VrstaBolovanja.Bolest;
                if (vrsta.ToLower() == "alergija")
                    vrsta_bolovanja = VrstaBolovanja.Alergija;
                else
                    vrsta_bolovanja = VrstaBolovanja.Bolest;
                bolesti.Add(new Bolest(naziv, datum_bolovanja, opis, vrsta_bolovanja));
                Console.WriteLine("Da li zelite dodati jos jednu dijagnozu? (Da/Ne)");
                string opcija = Console.ReadLine();
                if (opcija.ToLower() == "ne")
                    break;
            }
            Console.WriteLine("Unesite misljenje: ");
            string misljenje = Console.ReadLine();
            Console.WriteLine("Unesite zdravstveno stanje u porodici: ");
            string porodicno_stanje = Console.ReadLine();

            Anamneza.PokreniProtokol(pacijent, misljenje, porodicno_stanje, bolesti);
        }

        public void ObrisiPacijenta()
        {
            Console.WriteLine("Maticni broj: ");
            long m_b = long.Parse(Console.ReadLine());
            Pacijent p = pacijenti.Find(delegate (Pacijent b) { return b.DajMaticniBroj() == m_b; });
            if (p == null)
                throw new Exception("Pacijent sa ovim maticnim brojem nije upisan.");
            pacijenti.RemoveAll(x => x.DajMaticniBroj() == m_b);
        }
        // Prva opcija
        public void RegistrujPacijenta()//(string ime, string prezime, DateTime datum_rodjenja, long maticni_broj, char spol, string adresa, string bracno_stanje)
        {
            Console.WriteLine("Upisite ime: ");
            string ime = Console.ReadLine();
            Console.WriteLine("Upisite prezime: ");
            string prezime = Console.ReadLine();
            Console.WriteLine("Datum rodjenja: ");
            DateTime datum_rodjenja = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Maticni broj: ");
            long maticni_broj = long.Parse(Console.ReadLine());
            Console.WriteLine("Spol(M/Ž): ");
            char spol = Console.ReadLine()[0];
            Console.WriteLine("Adresa: ");
            string adresa = Console.ReadLine();
            Console.WriteLine("Bracno stanje: ");
            string bracno_stanje = Console.ReadLine();

            
            pacijenti.Add(new Pacijent(ime, prezime, datum_rodjenja, maticni_broj, spol, adresa, bracno_stanje));
            

        }

    }
}
