using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    enum RezultatPregleda { smrt, zivot }
    class Pregled
    {
       
        private bool hitan = false;
        private string zabiljeske;
        private DateTime datumPregleda = DateTime.Now;
        private bool prvaPomoc = false;
        private RezultatPregleda rezultatPregleda = RezultatPregleda.zivot;
        private string uzrokSmrti;
        private DateTime vrijemeSmrti;
        private bool obdukcija = false;
        private DateTime vrijemeObdukcije;

        public DateTime DatumPregleda
        {
            get
            {
                return datumPregleda;
            }

            set
            {
                datumPregleda = value;
            }
        }

        public Pregled(bool hitan,string zabiljeske,DateTime datumPregleda,bool prvaPomoc,RezultatPregleda rezultatPregleda,string uzrokSmrti,DateTime vrijemeSmrti,bool obdukcija,DateTime vrijemeObdukcije)
        {
            this.hitan = hitan;
            this.zabiljeske = zabiljeske;
            this.DatumPregleda = datumPregleda;
            this.prvaPomoc = prvaPomoc;
            this.rezultatPregleda = rezultatPregleda;
            this.uzrokSmrti = uzrokSmrti;
            this.vrijemeSmrti = vrijemeSmrti;
            this.obdukcija = obdukcija;
            this.vrijemeObdukcije = vrijemeObdukcije;

        
        }
        
        
        public void IspisiPregled()
        {
            Console.WriteLine("Pregled: ");
            Console.WriteLine("zabiljeske: ",zabiljeske);
            Console.WriteLine("datum pregleda: ",DatumPregleda);
            if(rezultatPregleda == 0)
            {
                Console.WriteLine("uzrok smrti: ",uzrokSmrti );
                Console.WriteLine("vrijeme smrti: ",vrijemeSmrti);
                if(obdukcija == true)
                    Console.WriteLine("vrijeme obdukcija: ",vrijemeObdukcije);
            }
        }



    }
}
