using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLINIKAWinApp
{
    public class Oprema
    {
        private bool zauzeta = false;
        private bool uKvaru = false;
        private DateTime neRadiOd;
        private DateTime neRadiDo;
        private string nazivOpreme;


        public Oprema(string nazivOpreme)
        {
            this.nazivOpreme = nazivOpreme;
        }

        public void OznaciDaNeRadi(DateTime od_,DateTime do_)
        {
            neRadiOd = od_;
            neRadiDo = do_;
        }

        public void UKvaru()
        {
            uKvaru = true;
        }

        public void NijeUKvaru()
        {
            uKvaru = false;
        }

        public void Zauzeta()
        {
            zauzeta = true;
        }

        public void Slobodna()
        {
            zauzeta = false;
        }

        public bool DaLiJeZauzeta()
        {
            return zauzeta;
        }

        public bool DaLiJeUKvaru()
        {
            return uKvaru;
        }
    }
}
