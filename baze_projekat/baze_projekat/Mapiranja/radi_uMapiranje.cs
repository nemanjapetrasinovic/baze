using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using baze_projekat.Entiteti;
using FluentNHibernate.Mapping;

namespace baze_projekat.Mapiranja
{
    class radi_uMapiranje:ClassMap<radi_u>
    {
        public radi_uMapiranje()
        {
            Table("RADI_U");

            CompositeId(x => x.id_radi_u)
                 .KeyReference(x => x.zaposleniRadiU, "ID_ZAPOSLENOG")
                 .KeyReference(x => x.radiUPoslovnica, "ID_POSLOVNICE");

            Map(x => x.datum_do, "DATUM_DO");
            Map(x => x.datum_od, "DATUM_OD");

            //References(x => x.Prodavac).Column("ID_ZAPOSLENOG");
            //References(x => x.Radi).Column("ID_POSLOVNICE");

       
           
        }
    }
}
