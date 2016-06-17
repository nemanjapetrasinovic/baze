using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class sefuje
    {
        public virtual sefujeid id_sefovanja { get; set; }
        public virtual DateTime datum_postavljenja { get; set; }

        //public virtual sef Upravnik { get; set; }
        //public virtual poslovnica Upravlja { get; set; }

        public sefuje()
        {
            id_sefovanja = new sefujeid();
        }

    }
}
