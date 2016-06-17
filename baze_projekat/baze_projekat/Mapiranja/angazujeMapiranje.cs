using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baze_projekat.Entiteti;
using FluentNHibernate.Mapping;

namespace baze_projekat.Mapiranja
{
    class angazujeMapiranje:ClassMap<angazuje>
    {
        public angazujeMapiranje()
        {
            Table("ANGAZUJE");

            Map(x => x.datum_angazovanja, "DATUM_ANGAZOVANJA");

            CompositeId(x => x.id_angazovanja)
                .KeyReference(x => x.prodavacAngazuje, "ID_ZAPOSLENOG")
                .KeyReference(x => x.angazovanOd, "ID_AGENTA");
        }
    }
}
