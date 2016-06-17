using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baze_projekat.Entiteti;
using FluentNHibernate.Mapping;

namespace baze_projekat.Mapiranja
{
    class traziMapiranje:ClassMap<trazi>
    {
        public traziMapiranje()
        {
            Table("TRAZI");

            CompositeId(x => x.id_trazenja)
                  .KeyReference(x => x.ugovorOIznajmljivanju, "ID_UGOVORA")
                  .KeyReference(x => x.klijentPodstanar, "ID_KLIJENTA");
        }
    }
}
