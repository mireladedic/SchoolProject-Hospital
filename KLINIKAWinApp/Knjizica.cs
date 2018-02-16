using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLINIKAWinApp
{
    public class Knjizica
    {
        private int id;
        private DateTime datum_izdavanja;
        private DateTime do_kad_vazi;

        public Knjizica(int id, DateTime datum_izdavanja, DateTime do_kad_vazi)
        {
            this.id = id;
            this.datum_izdavanja = datum_izdavanja;
            this.do_kad_vazi = do_kad_vazi;
        }
    }
}
