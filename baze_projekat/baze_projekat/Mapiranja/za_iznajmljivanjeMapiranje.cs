using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baze_projekat.Entiteti;
using FluentNHibernate.Mapping;

namespace baze_projekat.Mapiranja
{
    public class za_iznajmljivanjeMapiranje : ClassMap<za_iznajmljivanje>
    {
        public za_iznajmljivanjeMapiranje()
        {
            Table("ZA_IZNAJMLJIVANJE");
            Id(x => x.id_nekretnine, "ID_NEKRETNINE").GeneratedBy.TriggerIdentity();
            References(x => x.iznajmljujeUgovor).Column("ID_UGOVORA").LazyLoad();
            //References(x => x.id_ugovora, "ID_UGOVORA").Column("ID_UGOVORA");
        }
    }
}
