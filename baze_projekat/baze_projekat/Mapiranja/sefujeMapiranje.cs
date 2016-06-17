using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baze_projekat.Entiteti;
using FluentNHibernate.Mapping;

namespace baze_projekat.Mapiranja
{
    class sefujeMapiranje:ClassMap<sefuje>
    {
        public sefujeMapiranje()
        {
            Table("SEFUJE");

            CompositeId(x => x.id_sefovanja)
                 .KeyReference(x => x.zaposleniSefujeU, "ID_ZAPOSLENOG")
                 .KeyReference(x => x.sefujeUPoslovnici, "ID_POSLOVNICE");

            Map(x => x.datum_postavljenja, "DATUM_POSTAVLJANJA");

            //References(x => x.Upravnik).Column("ID_ZAPOSLENOG");
            //References(x => x.Upravlja).Column("ID_POSLOVNICE");
        }
    }
}
