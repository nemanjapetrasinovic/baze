using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baze_projekat.Entiteti;
using FluentNHibernate.Mapping;

namespace baze_projekat.Mapiranja
{
    class prodajeMapiranje:ClassMap<prodaje>
    {
        public prodajeMapiranje()
        {
            Table("PRODAJE");

            CompositeId(x => x.id_prodaje)
                  .KeyReference(x => x.ugovorOProdaji, "ID_UGOVORA")
                  .KeyReference(x => x.klijentKupac, "ID_KLIJENTA");
        }
    }
}
