using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class ugovor
    {
        public virtual int id_ugovora { get; protected set; }
        public virtual int id_zaposlenog { get; set; }
        public virtual zaposleni ugovorio { get; set; }
    }
}
