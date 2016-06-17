using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class za_iznajmljivanje
    {
        public virtual int id_nekretnine { get; set; }
        public virtual int id_ugovora { get; set; }
        public virtual iznajmljivanje iznajmljujeUgovor { get; set; }
    }
}
