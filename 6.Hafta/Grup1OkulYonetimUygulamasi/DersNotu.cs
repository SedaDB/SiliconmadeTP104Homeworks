using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup1OkulYonetimUygulamasi
{
    internal class DersNotu
    {
        public string DersAdi { get; set; }
        public int Not { get; set; }

        public DersNotu(string dersAdi, int not)
        {
            DersAdi = dersAdi;
            Not = not;
        }
    }
}
