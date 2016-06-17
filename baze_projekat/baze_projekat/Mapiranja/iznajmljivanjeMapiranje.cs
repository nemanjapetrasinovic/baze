using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baze_projekat.Entiteti;
using FluentNHibernate.Mapping;

namespace baze_projekat.Mapiranja
{
    class iznajmljivanjeMapiranje:ClassMap<iznajmljivanje>
    {
        public iznajmljivanjeMapiranje()
        {
            Table("IZNAJMLJIVANJE");

            Id(x => x.id_ugovora, "ID_UGOVORA").GeneratedBy.TriggerIdentity();

            Map(x => x.datum_isteka_zakupa, "DATUM_ISTEKA_ZAKUPA");
            Map(x => x.datum_sklapanja, "DATUM_SKLAPANJA");
            Map(x => x.kirija, "KIRIJA");

            HasManyToMany(x => x.Ugovori)
             .Table("TRAZI")
             .ParentKeyColumn("ID_UGOVORA")
             .ChildKeyColumn("ID_KLIJENTA")
             .Inverse()
             .Cascade.All();

            //HasMany(x => x.Vlasnik).KeyColumn("ID_KLIJENTA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
