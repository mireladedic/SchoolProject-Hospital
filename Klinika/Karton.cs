using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    sealed class Karton
    {
        private PacijentInfo pacijentInfo;
        private List<Pregled> pregledi;
        private List<Terapija> terapije;
        private List<Bolest> bolesti;
        private string zakljucakDoktora = "";
        private string zdravstvenoStanjePorodice;
        public Karton(string ime, string prezime, DateTime datum_rodjenja, long maticni_broj, char spol, string adresa, string bracno_stanje)
        {
            pacijentInfo = new PacijentInfo(ime, prezime, datum_rodjenja, maticni_broj, spol, adresa, bracno_stanje);
            pregledi = new List<Pregled>();
            terapije = new List<Terapija>();
            bolesti = new List<Bolest>();
        }
      
        public void IspisiKarton()
        {
            Console.WriteLine("Zakljucak doktora: \n", zakljucakDoktora);
            Console.WriteLine("\nZdravstveno stanje porodice: \n", zdravstvenoStanjePorodice);
            foreach(Bolest b in bolesti) b.IspisiBolest();
            foreach(Terapija t in terapije) t.IspisiTerapiju();
            foreach (Pregled p in pregledi) p.IspisiPregled();
        }
        public Karton(PacijentInfo pInfo)
        {
            pacijentInfo = pInfo;
            pregledi = new List<Pregled>();
            terapije = new List<Terapija>();
            bolesti = new List<Bolest>();
        }
        public void DodajPregled(Pregled pregled)
        {
            try
            {
                pregledi.Add(pregled);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void IspisiPregledKarton()
        {
            foreach (Pregled p in pregledi) p.IspisiPregled();
        }

        public void DodajTerapiju(Terapija terapija)
        {
            Console.WriteLine("Maticni broj:" );
            long maticni_broj = long.Parse(Console.ReadLine());
            int i = 0;
            if (pacijentInfo.MaticniBroj == maticni_broj) terapije[i].UnesiTerapiju();
            terapije.Add(terapija); i++;
        }

       
        
        public void ObrisiTerapiju(Terapija terapija)
        {
            terapije.Remove(terapija);
        }
        public void ObrisiPregled(Pregled pregled)
        {
            pregledi.Remove(pregled);
        }

        public void DodajBolest(Bolest bolest)
        {
            bolesti.Add(bolest);
        }
        public void ObrisiBolest(Bolest bolest)
        {
            bolesti.Remove(bolest);
        }
        public void DodajBolesti(List<Bolest> bolest_list)
        {
            bolesti.AddRange(bolest_list);
        }

        public void DodajZakljucak(string zakljucak)
        {
            zakljucakDoktora += zakljucak;
        }
        public void DodajZdravstvenoStanjePorodice(string stanje)
        {
            zdravstvenoStanjePorodice = stanje;
        }
    }
}
