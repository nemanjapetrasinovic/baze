using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baze_projekat.Entiteti;
using FluentNHibernate.Mapping;

namespace baze_projekat.Mapiranja
{
    class kupoprodajniMapiranje:ClassMap<kupoprodajni>
    {
        public kupoprodajniMapiranje()
        {
            Table("KUPOPRODAJNI");

            Id(X => X.id_ugovora, "ID_UGOVORA").GeneratedBy.TriggerIdentity();

            Map(x => x.datum_transakcije, "DATUM_TRANSAKCIJE");

            HasManyToMany(x => x.Vlasnik)
                .Table("PRODAJE")
                .ParentKeyColumn("ID_UGOVORA")
                .ChildKeyColumn("ID_KLIJENTA")
                .Inverse()
                .Cascade.All();

            HasMany(x => x.Ugovori).KeyColumn("ID_KLIJENTA").LazyLoad().Cascade.All().Inverse();

        }
    }
}
