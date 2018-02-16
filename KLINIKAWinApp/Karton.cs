using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLINIKAWinApp
{
    public class Karton
    {
        private PacijentInfo pacijentInfo;
        private List<Pregled> pregledi;
        private List<Terapija> terapije;
        private List<Bolest> bolesti;
        private string zakljucakDoktora = "";
        private string zdravstvenoStanjePorodice;

        public string ZakljucakDoktora { get { return zakljucakDoktora; } set { zakljucakDoktora = value; } }
        public List<Pregled> Pregledi { get { return pregledi; } set{ pregledi = value; } }
        public List<Terapija> Terapije { get { return terapije; } set { terapije = value; } }
        public List<Bolest> Bolesti { get { return bolesti; } set { bolesti = value; } }

        public Karton(string ime,string prezime,DateTime datum_rodjenja,long maticni_broj,char spol,string adresa,string bracno_stanje)
        {
            pacijentInfo = new PacijentInfo(ime, prezime, datum_rodjenja, maticni_broj, spol, adresa, bracno_stanje);
            Pregledi = new List<Pregled>();
            Terapije = new List<Terapija>();
            Bolesti = new List<Bolest>();
        }

        /*   public IspisiKarton()
         * {
         *      Console.WriteLine("Zakljucak doktora:\n" , zakljucakDoktora);
         *      Console.WriteLine("Zdravstveno stanje porodine:\n",zdravstvenoStanjePorodice);
         *      foreach (Bolest b in bolesti) b.IspisiBolest();
         *      foreach (Terapija t in terapije) t.IspisiTerapiju();
         *      foreach (Pregled p in pregledi) p.IspisiPregled();
         *  }
         */

      /*public override string ToString()
        {
            return zakljucakDoktora + "\n" + zdravstvenoStanjePorodice + "\n";
        }
       */
        public Karton(PacijentInfo pInfo)
        {
            pacijentInfo = pInfo;
            Pregledi = new List<Pregled>();
            Terapije = new List<Terapija>();
            Bolesti = new List<Bolest>();
        }

        public void DodajPregled(Pregled pregled)
        {
            try
            {
                Pregledi.Add(pregled);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /* public void IspisiPregledKarton(){
         *      foreach(Pregled p in pregledi) p.IspisiPregled();
         * }
         */
        public void DodajTerapiju(Terapija terapija)
        {

            Terapije.Add(terapija);
        }

        public void ObrisiTerapiju(Terapija terapija)
        {
            Terapije.Remove(terapija);
        }

        public void ObrisiPregled(Pregled pregled)
        {
            Pregledi.Remove(pregled);
        }

        public void DodajBolest(Bolest bolest)
        {
            Bolesti.Add(bolest);
        }

        public void ObrisiBolest(Bolest bolest)
        {
            Bolesti.Remove(bolest);
        }

        public void DodajBolesti(List<Bolest> bolest_list)
        {
            Bolesti.AddRange(bolest_list);
        }

        public void DodajZakljucak(string zakljucak)
        {
            ZakljucakDoktora = zakljucak;
        }

        public void DodajZdravstvenoStanjePorodice(string stanje)
        {
            zdravstvenoStanjePorodice += stanje;
        }



    }
}
