using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYonetimUygulamasi
{
    internal class DersNotu
    {
        public string DersAdi;
        public float Not;

        public DersNotu(string dersAdi, float not)
        {
            this.DersAdi = dersAdi;
            this.Not = not;
        }
    }
}

