using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using baze_projekat.Entiteti;

namespace baze_projekat.Mapiranja
{
    class kvartMapiranje:ClassMap<kvart>
    {
        public kvartMapiranje()
        {
            Table("KVART");

            Id(x => x.id_kvarta, "ID_KVARTA").GeneratedBy.TriggerIdentity();


            Map(x => x.gradska_zona, "GRADSKA_ZONA");

           // References(x => x.id_poslovnice).Column("ID_POSLOVNICE").LazyLoad();
            References(x => x.pripadaPoslovnici).Column("ID_POSLOVNICE").LazyLoad();
            HasMany(x => x.Nekretnina).KeyColumn("ID_KVARTA").LazyLoad().Cascade.All().Inverse();
        }
    }
}
