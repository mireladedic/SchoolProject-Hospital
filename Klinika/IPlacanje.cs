using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klinika
{
    public enum VrstaPlacanjaRacuna { Potpuno, Rate };
    public enum StavkeRacuna { Pregled, Terapija };
    public interface IPlacanje
    {
        VrstaPlacanjaRacuna VrstaPlacanja
        {
            get;
            set;
        }
        List<StavkeRacuna> Stavke
        {
            get;
            set;
        }
        
    }
}
