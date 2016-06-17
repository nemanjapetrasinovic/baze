using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baze_projekat.Entiteti;
using FluentNHibernate.Mapping;

namespace baze_projekat.Mapiranja
{
    class ugovorMapiranje:ClassMap<ugovor>
    {
        public ugovorMapiranje()
        {
            Table("UGOVOR");

            Id(x => x.id_ugovora, "ID_UGOVORA").GeneratedBy.TriggerIdentity();
            References(x => x.ugovorio).Column("ID_ZAPOSLENOG").LazyLoad();
           // References(x => x.id_zaposlenog).Column("ID_ZAPOSLENOG").LazyLoad();
        }
    }
}
