using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class poslovnica
    {
        public virtual int id_poslovnice { get; protected set; }
        public virtual string ime_ulice { get; set; }
        public virtual string broj_ulice { get; set; }
        public virtual string radno_vreme { get; set; }


        public virtual IList<kvart> Kvart { get; set; }


        public virtual IList<radi_u> RadiURadnici { get; set; }

        public virtual IList<sefuje> SefujeSefovi { get; set; }


        public poslovnica()
        {
             Kvart = new List<kvart>();

             RadiURadnici = new List<radi_u>();

             SefujeSefovi = new List<sefuje>();
        }
    }
}
