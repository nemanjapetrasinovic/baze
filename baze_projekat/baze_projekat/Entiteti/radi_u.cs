using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class radi_u
    {
        public virtual radiuid id_radi_u { get; set; }
        public virtual DateTime datum_od { get; set; }
        public virtual DateTime? datum_do { get; set; }

        //public virtual prodavac Prodavac { get; set; }
        //public virtual poslovnica Radi { get; set; }

        public radi_u()
        {
            id_radi_u = new radiuid();
        }

    }
}
