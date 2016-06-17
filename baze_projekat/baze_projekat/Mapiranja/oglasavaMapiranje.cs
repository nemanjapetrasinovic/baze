using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baze_projekat.Entiteti;
using FluentNHibernate.Mapping;

namespace baze_projekat.Mapiranja
{
    class oglasavaMapiranje:ClassMap<oglasava>
    {
        public oglasavaMapiranje()
        {
            Table("OGLASAVA");

            CompositeId(x => x.id_oglasavanja)
                  .KeyReference(x => x.ugovorOIznajmljivanju, "ID_UGOVORA")
                  .KeyReference(x => x.klijentIzdavac, "ID_KLIJENTA");
        }
    }
}
