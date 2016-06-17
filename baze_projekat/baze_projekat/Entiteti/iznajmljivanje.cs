using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class iznajmljivanje
    {
        public virtual int id_ugovora { get; protected set; }
        public virtual DateTime datum_sklapanja { get; set; }
        public virtual DateTime datum_isteka_zakupa { get; set; }
        public virtual int kirija { get; set; }

        //public virtual IList<trazi> Vlasnik { get; set; }

        public virtual IList<kupacfizicko> Ugovori { get; set; }

        public iznajmljivanje()
        {
            //Vlasnik = new List<trazi>();

            Ugovori = new List<kupacfizicko>();
        }
    }
}
