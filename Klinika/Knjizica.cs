using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    class Knjizica
    {
        private int id;
        private DateTime datum_izdavanja;
        private DateTime do_kad_vazi;

        public Knjizica(int id, DateTime di, DateTime dkv)
        {
            this.id = id;
            datum_izdavanja = di;
            do_kad_vazi = dkv;
        }
        
    }
}
