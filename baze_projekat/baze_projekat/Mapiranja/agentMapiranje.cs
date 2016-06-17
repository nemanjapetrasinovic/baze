using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using baze_projekat.Entiteti;

namespace baze_projekat.Mapiranja
{
    class agentMapiranje:ClassMap<agent>
    {
        public agentMapiranje()
        {
            Table("AGENT");
            Id(x => x.id_agenta, "ID_AGENTA").GeneratedBy.TriggerIdentity();

            
            Map(x => x.lime, "LIME");
            Map(x => x.prezime, "PREZIME");
            Map(x => x.procenat, "PROCENAT");
            Map(x => x.sslovo, "SSLOVO");
            Map(x => x.telefon, "TELEFON");

            //References(x => x.id_zaposlenog).Column("ID_ZAPOSLENOG").LazyLoad();
        }
    }
}
