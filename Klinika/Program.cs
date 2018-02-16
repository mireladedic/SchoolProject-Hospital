using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    class Program
    {
        public static Klinika klinika17082_1;
        static double bonus;
        public static MedicinskiRadnik trenutniUposlenik;
        public static bool prijavljen = false;
        public static bool ulogiran = false;
        
        public static void GlavniMeni()
        {
            if (!ulogiran)
            {

                Console.WriteLine("Prijava za medicinsko osoblje.");
                string ime, prezime;
                Console.WriteLine("Unesite ime:");
                ime = Console.ReadLine();
                Console.WriteLine("Unesite prezime:");
                prezime = Console.ReadLine();

                trenutniUposlenik = (MedicinskiRadnik)klinika17082_1.DajUposlenika(ime, prezime);
                if (trenutniUposlenik == null)
                {
                    GlavniMeni();
                    return;
                }
                else
                    ulogiran = true;
            }

            Console.WriteLine("Dobro dosli! Odaberite jednu od opcija: ");
            Console.WriteLine("1.\tRegistruj/Brisi pacijenta\n2.\tPrikazi raspored pregleda pacijenata\n3.\tKreiranje kartona pacijenta\n4.\tPretraga kartona pacijenta\n5.\tRegistruj novi pregled\n6.\tAnaliza sadrzaja\n7.\tNaplata\n8.\tIzlaz");

            int unos = Int32.Parse(Console.ReadLine());
            switch (unos)
            {
                case 1:
                    RegistrujBrisiPacijenta();
                    GlavniMeni();
                    break;
                case 2:
                    PrikaziRasporedPregledaPacijenta();
                    GlavniMeni();
                    break;
                case 3:
                    PokreniUpisPacijenta();
                    GlavniMeni();
                    break;
                case 4:
                    PretragaKartonaPacijenta();
                    GlavniMeni();
                    break;
                case 5:
                    RegistrujNoviPregled();
                    GlavniMeni();
                    break;
                case 6:
                    AnalizaSadrzaja();
                    GlavniMeni();
                    break;
                case 7:
                    NaplataPacijentu();
                    break;
                case 8:
                    // Izlaz();
                    // break;
                    return;
                default:
                    GlavniMeni();
                    break;

            }
        }
        public static void Izlaz()
        {
            Console.WriteLine("Dovidjenja");
            return;
        }
        public static void NaplataPacijentu()
        {
            Console.WriteLine("Maticni broj: ");
            long m_b = long.Parse(Console.ReadLine());

            Pacijent p = klinika17082_1.PronadjiPacijenta(m_b);
            if (p == null) throw new Exception("Prvo trebate unijeti pacijenta. Nema pacijenta sa tim maticnim brojem");
            List<Racun> neplaceni = p.DajNeplaceneRacune();
            if (neplaceni == null)
            {
                Console.WriteLine("Pacijent nema neplacenih racuna");
                NaplataPacijentu();
                return;
            }
            if (neplaceni.Count == 0)
            {
                Console.WriteLine("Pacijent nema neplacenih racuna");
              
                return;
            }
            Console.WriteLine("Fiskalni Racuni:");
            
            neplaceni.ForEach(r =>
            {
                Console.WriteLine(r.ToString());
            });
            
           // foreach (Racun r in neplaceni) r.ToString();
        }
        public static void Administracija()
        {
            string username ="";
            string sifra = "";
            if (!prijavljen)
            {
                Console.WriteLine("Prijavite se kao administrator: ");
                Console.WriteLine("Korisnicko ime: ");
                username = Console.ReadLine();
                Console.WriteLine("Sifra:");
                sifra = Console.ReadLine();
            }
            if((username == "admin" && sifra == "admin") || prijavljen)
            {
                prijavljen = true;
                Console.WriteLine("Administracijski meni:");
                Console.WriteLine("1.Izmjenite bonuse po pacijentu za medicinsko osoblje\n2.Registruj uposlenika\n3.Odjava");
                int opcija = int.Parse(Console.ReadLine());
                switch(opcija)
                {
                    case 1:
                        Console.WriteLine("Izmjenite bonus za medicinsko osoblje po pacijentu:");
                        bonus = double.Parse(Console.ReadLine());
                        Administracija();
                        break;
                    case 2:
                        string ime, prezime, naziv;
                        Console.WriteLine("Unesite ime:");
                        ime = Console.ReadLine();
                        Console.WriteLine("Unesite prezime:");
                        prezime = Console.ReadLine();
                        Console.WriteLine("Unesite naziv");
                        naziv = Console.ReadLine();
                        Console.WriteLine("Unesite platu: ");
                        double plata = double.Parse(Console.ReadLine());
                        Console.WriteLine("Unesite bonus: ");
                        double b = double.Parse(Console.ReadLine());

                        klinika17082_1.DodajUposlenika(new MedicinskiRadnik(ime, prezime, naziv, plata, b));
                        
                        Administracija();
                        break;
                    case 3:
                        prijavljen = false;
                        GlavniMeni();
                        break;
                    default:
                        Administracija();
                        break;
                }
            } 
        }
        //.........
        public static void AnalizaSadrzaja()
        {
            klinika17082_1.Analiziraj();
        }
        //...REGISTRUJ NOVI PREGLED
        public static void RegistrujNoviPregled()
        {
            klinika17082_1.RegistrujPregled();
            trenutniUposlenik.DodajBonus();

        }
        //...PRIKAZI RASPORED PREGLEDA PACIJENTA - ovo je da ispise sve preglede,tj. osobine pregleda 
        public static void PrikaziRasporedPregledaPacijenta()
        {
            try
            {
                klinika17082_1.IspisiPregledPacijenta();
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        //.. ISPISI KARTON PACIJENTA
        public static void PretragaKartonaPacijenta()
        {
            Console.WriteLine("Unesite maticni broj: ");
            long m_b = long.Parse(Console.ReadLine());
            try
            {
               klinika17082_1.PretraziKartonPacijenta(m_b);

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
       //....DODAJ KARTON PACIJENTA
        public static void PokreniUpisPacijenta()
        {
            Console.WriteLine("Unesite maticni broj: ");
            long m_b = long.Parse(Console.ReadLine());
            try
            {
                Pacijent t = klinika17082_1.PronadjiPacijenta(m_b);
                t.IspisiPacijenta();
                klinika17082_1.PokreniAnamnezu(t);
                trenutniUposlenik.DodajBonus();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Zelite li prekinuti pretragu? (Da/Ne)");
                if (Console.ReadLine().ToLower() == "da")
                    GlavniMeni();
                else 
                    PokreniUpisPacijenta();
            }
            
        }
        public static void RegistrujBrisiPacijenta()
        {
            Console.WriteLine("Odaberite jednu od opcija: ");
            Console.WriteLine("1.\tRegistruj pacijenta\n2.\tBrisi pacijenta\n3.\tPovratak");
            int unos = Int32.Parse(Console.ReadLine());
            switch(unos)
            {
                case 1:
                    klinika17082_1.RegistrujPacijenta();
                    GlavniMeni();
                    break;
                case 2:
                    klinika17082_1.ObrisiPacijenta();
                    GlavniMeni();
                    break;
                case 3:
                    GlavniMeni();
                    break;
                default:
                    RegistrujBrisiPacijenta();
                    break;
            }
        }
        static void Main(string[] args)
        {
            klinika17082_1 = new Klinika();
           /* Console.WriteLine("Prijavite se(Samo za medicinsko osoblje):");
            string ime, prezime;
            ime = Console.ReadLine();
            prezime = Console.ReadLine(); 

            trenutniUposlenik = (MedicinskiRadnik) klinika17082_1.DajUposlenika(ime, prezime); */
            if(trenutniUposlenik == null)
            {
                Administracija();
            }
           
        }
    }
}
