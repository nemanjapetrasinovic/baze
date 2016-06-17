using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class kupoprodajni
    {
        public virtual int id_ugovora { get; protected set; }
        public virtual DateTime datum_transakcije { get; set;  }

        public virtual IList<klijent> Vlasnik { get; set; }
        public virtual IList<prodaje> Ugovori { get; set; }

        public kupoprodajni()
        {
            Vlasnik = new List<klijent>();

            Ugovori = new List<prodaje>();
        }
    }
}
