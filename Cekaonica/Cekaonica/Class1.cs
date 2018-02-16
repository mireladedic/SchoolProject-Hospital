using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    public class Cekaonica
    {
        private List<int> red;

        public Cekaonica()
        {
            red = new List<int>();
        }

        public int DodajURed()
        {
            red.Add(red.Count + 1);
            return red.Count;
        }

        public void UkloniIzReda(int r)
        {
            red.Remove(r);
        }
        public int DajVelicinu()
        {
            return red.Count;
        }
    }
}
