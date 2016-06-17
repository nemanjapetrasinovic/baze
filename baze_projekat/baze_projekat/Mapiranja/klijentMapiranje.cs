using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baze_projekat.Entiteti;
using FluentNHibernate.Mapping;

namespace baze_projekat.Mapiranja
{
    public class klijentMapiranje:ClassMap<klijent>
    {
        public klijentMapiranje()
        {
            Table("KLIJENT");
            DiscriminateSubClassesOnColumn("FLAG_TIP", 0);
            Id(x => x.id_klijenta, "ID_KLIJENTA").GeneratedBy.TriggerIdentity();

            
            Map(x => x.broj_ulice, "BROJ_ULICE");
            Map(x => x.email, "EMAIL");
            Map(x => x.ime_ulice, "IME_ULICE");
            Map(x => x.jmbg, "JMBG");
            Map(x => x.lime, "LIME");
            Map(x => x.prezime, "PREZIME");
            Map(x => x.sslovo, "SSLOVO");
            Map(x => x.telefon, "TELEFON");


            HasManyToMany(x => x.Ugovori)
               .Table("PRODAJE")
               .ParentKeyColumn("ID_KLIJENTA")
               .ChildKeyColumn("ID_UGOVORA")
               .Cascade.All();

            HasMany(x => x.Vlasnik).KeyColumn("ID_KLIJENTA").LazyLoad().Cascade.All().Inverse();

        }
        public class kupacfizickoMapiranje : SubclassMap<kupacfizicko>
        {
            public kupacfizickoMapiranje()
            {
                Table("KLIJENT");
                DiscriminatorValue(1);
                //KeyColumn("ID_KLIJENTA");

                HasManyToMany(x => x.Ugovori1)
               .Table("TRAZI")
               .ParentKeyColumn("ID_KLIJENTA")
               .ChildKeyColumn("ID_UGOVORA")
               .Cascade.All();

                // HasMany(x => x.Vlasnik).KeyColumn("ID_UGOVORA").LazyLoad().Cascade.All().Inverse();
            }
        }
        public class vlasnikfizickoMapiranje : SubclassMap<vlasnikfizicko>
        {
            public vlasnikfizickoMapiranje()
            {
                DiscriminatorValue(2);
                //KeyColumn("ID_KLIJENTA");
            }
        }
        public class kupacpravnoMapiranje : SubclassMap<kupacpravno>
        {
            public kupacpravnoMapiranje()
            {
                DiscriminatorValue(3);
                Map(x => x.adresa_sedista, "ADRESA_SEDISTA");
                Map(x => x.pib, "PIB");
            }
        }
        public class vlasnikpravnoMapiranje : SubclassMap<vlasnikpravno>
        {

            public vlasnikpravnoMapiranje()
            {
                DiscriminatorValue(4);
                Map(x => x.adresa_sedista, "ADRESA_SEDISTA");
                Map(x => x.pib, "PIB");

            }
        }
    }
}
