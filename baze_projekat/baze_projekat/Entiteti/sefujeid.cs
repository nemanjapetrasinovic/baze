using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class sefujeid
    {
        public virtual zaposleni zaposleniSefujeU { get; set; }
        public virtual poslovnica sefujeUPoslovnici { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(sefujeid))
                return false;

            sefujeid recievedObject = (sefujeid)obj;

            if ((zaposleniSefujeU.id_zaposlenog == recievedObject.zaposleniSefujeU.id_zaposlenog) &&
                (sefujeUPoslovnici.id_poslovnice == recievedObject.sefujeUPoslovnici.id_poslovnice))
            {
                return true;
            }
            return false;
        }
            public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
