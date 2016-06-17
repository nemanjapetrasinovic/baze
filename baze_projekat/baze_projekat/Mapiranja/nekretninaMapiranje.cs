using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baze_projekat.Entiteti;
using FluentNHibernate.Mapping;

namespace baze_projekat.Mapiranja
{
    public class nekretninaMapiranje:ClassMap<nekretnina>
    {
        public nekretninaMapiranje()
        {
            Table("NEKRETNINA");
            DiscriminateSubClassesOnColumn("FLAG_STAMBENI",0);
            Id(x => x.id_nekretnine, "ID_NEKRETNINE").GeneratedBy.TriggerIdentity();
            Map(x => x.broj_ulice, "BROJ_ULICE");
            Map(x => x.cena, "CENA");
            Map(x => x.datum_izgradnje, "DATUM_IZGRADNJE");
           // Map(x => x.flag_stambeni, "FLAG_STAMBENI");
            Map(x => x.ime_ulice, "IME_ULICE");
            Map(x => x.sprat, "SPRAT");
            Map(x => x.starost, "STAROST");
            References(x => x.pripadaKvartu).Column("ID_KVARTA").LazyLoad();
        }
        
    }
    public class stambeniMapiranje : SubclassMap<stambeni>
    {
       public stambeniMapiranje()
        {
            DiscriminatorValue(1);
            //KeyColumn("ID_NEKRETNINE"); 
            Map(x => x.broj_kupatila, "BROJ_KUPATILA");
        }
    }
    public class poslovniMapiranje : SubclassMap<poslovni>
    {
        public poslovniMapiranje()
        {
            DiscriminatorValue(0);
            //KeyColumn("ID_NEKRETNINE");
            Map(x => x.konf_sala, "KONF_SALA");
            Map(x => x.oprema, "OPREMA");
        }
    }
}
