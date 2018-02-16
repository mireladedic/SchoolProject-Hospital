using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLINIKAWinApp
{
    public enum VrstaTerapije { kratkorocna,dugorocna };
    public class Terapija
    {
        private VrstaTerapije vrstaTerapije;
        private bool garancija = false;
        private DateTime datumPropisivanja;
        private bool blokirana = false;

        public DateTime DatumPropisivanja { get { return datumPropisivanja; } set { datumPropisivanja = value; } }

        public Terapija(VrstaTerapije vrstaTerapije, bool garancija, DateTime datumPropisivanja, bool blokirana)
        {
            this.vrstaTerapije = vrstaTerapije;
            this.garancija = garancija;
            this.DatumPropisivanja = datumPropisivanja;
            this.blokirana = blokirana;
        }
        
        public void UnesiTerapiju()
        {

            Console.WriteLine("Unesite vrstu terapije (Kratkorocna/Dugorocna):  ");
            string vrstaTerapije = Console.ReadLine();
            VrstaTerapije t = VrstaTerapije.kratkorocna;
            if (vrstaTerapije.ToLower() == "kratkorocna")
                t = VrstaTerapije.kratkorocna;
            else if (vrstaTerapije.ToLower() == "dugorocna")
                t = VrstaTerapije.dugorocna;

            Console.WriteLine("Vazi li garancija? (da/ne)");
            string unos = Console.ReadLine();
            bool g = false;
            if (unos.ToLower() == "ne") g = false;
            else if (unos.ToLower() == "da") g = true;

            Console.WriteLine("datum propisivanja terapije: ");
            DateTime datumPropisivanja = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("blokirana (da/ne) : ");
            string bunos = Console.ReadLine();
            bool b = false;
            if (bunos.ToLower() == "da") b = true;
            else if (bunos.ToLower() == "ne") b = false;
            Terapija terapija = new Terapija(t, g, datumPropisivanja, b);
        }
       
        public void IspisiTerapiju()
        {
            Console.WriteLine("Terapija: ");
            Console.WriteLine("vrsta trapije: ", vrstaTerapije);
            Console.WriteLine("garancija: ", garancija);
            Console.WriteLine("datum propisivanja: ",DatumPropisivanja);
            Console.WriteLine("blokirana", blokirana);

        }
    

    }


}
