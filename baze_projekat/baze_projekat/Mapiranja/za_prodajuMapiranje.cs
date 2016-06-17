using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baze_projekat.Entiteti;
using FluentNHibernate.Mapping;

namespace baze_projekat.Mapiranja
{
    public class za_prodajuMapiranje:ClassMap<za_prodaju>
    {
        public za_prodajuMapiranje()
        {
            Table("ZA_PRODAJU");
            Id(x => x.id_nekretnine, "ID_NEKRETNINE").GeneratedBy.TriggerIdentity();
            References(x => x.kupoprodajniUgovor).Column("ID_UGOVORA").LazyLoad();
            //References(x => x.id_ugovora, "ID_UGOVORA").Column("ID_UGOVORA");
        }
    }
}
