using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KLINIKAWinApp
{
    public class SlikaArgumenti : EventArgs
    {
        public Image img;
        public DateTime vrijeme;

        public SlikaArgumenti(Image i, DateTime vrijeme) { img = i; this.vrijeme = vrijeme; }

    }
}
