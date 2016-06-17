using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baze_projekat.Entiteti;
using FluentNHibernate.Mapping;

namespace baze_projekat.Mapiranja
{
    class poslovnicaMapiranje:ClassMap<poslovnica>
    {
        public poslovnicaMapiranje()
        {
            Table("POSLOVNICA");

            Id(x => x.id_poslovnice, "ID_POSLOVNICE").GeneratedBy.TriggerIdentity();

            Map(x => x.ime_ulice, "IME_ULICE");
            Map(x => x.radno_vreme, "RADNO_VREME");
            Map(x => x.broj_ulice, "BROJ_ULICE");


            HasMany(x => x.Kvart).KeyColumn("ID_POSLOVNICE").LazyLoad().Cascade.All().Inverse();

            HasMany(x => x.RadiURadnici).KeyColumn("ID_POSLOVNICE").LazyLoad().Cascade.All().Inverse();

            HasMany(x => x.SefujeSefovi).KeyColumn("ID_POSLOVNICE").LazyLoad().Cascade.All().Inverse();

        }
    }
}
