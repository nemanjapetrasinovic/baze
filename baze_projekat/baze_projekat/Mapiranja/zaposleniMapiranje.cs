using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baze_projekat.Entiteti;
using FluentNHibernate.Mapping;

namespace baze_projekat.Mapiranja
{
    class zaposleniMapiranje:ClassMap<zaposleni>
    {
        public zaposleniMapiranje()
        {
            Table("ZAPOSLENI");
            DiscriminateSubClassesOnColumn("FLAG_PRODAVAC");

            Id(x => x.id_zaposlenog, "ID_ZAPOSLENOG").GeneratedBy.TriggerIdentity();
            Map(x => x.jmbg, "JMBG");
            Map(x => x.lime, "LIME");
            Map(x => x.sslovo, "SSLOVO");
            Map(x => x.prezime, "PREZIME");
            //Map(x => x.flag_prodavac, "FLAG_PRODAVAC");
            HasMany(x => x.Ugovor).KeyColumn("ID_ZAPOSLENOG").Not.LazyLoad().Cascade.All().Inverse();
        }
    }

    public class sefMapiranje : SubclassMap<sef>
    {
        public sefMapiranje()
        {
            DiscriminatorValue(0);
            HasMany(x => x.SefujeUProdavnicama).KeyColumn("ID_ZAPOSLENOG").LazyLoad().Cascade.All().Inverse();
        }
    }
    public class prodavacMapiranje : SubclassMap<prodavac>
    {
        public prodavacMapiranje()
        {
            DiscriminatorValue(1);
            Map(x => x.strucna_sprema, "STRUCNA_SPREMA");
            HasMany(x => x.ProdajeUProdavnicama).KeyColumn("ID_ZAPOSLENOG").LazyLoad().Cascade.All().Inverse();
        }
    }
}
