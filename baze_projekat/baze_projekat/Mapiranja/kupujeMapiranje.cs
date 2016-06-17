using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baze_projekat.Entiteti;
using FluentNHibernate.Mapping;

namespace baze_projekat.Mapiranja
{
    class kupujeMapiranje:ClassMap<kupuje>
    {
        public kupujeMapiranje()
        {
            Table("KUPUJE");

            CompositeId(x => x.id_kupovanja)
                 .KeyReference(x => x.ugovorOKupovini, "ID_UGOVORA")
                 .KeyReference(x => x.klijentKupac, "ID_KLIJENTA");
        }
    }
}
