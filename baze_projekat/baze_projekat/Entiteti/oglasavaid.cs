using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class oglasavaid
    {
        public virtual ugovor ugovorOIznajmljivanju { get; set; }
        public virtual klijent klijentIzdavac { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(oglasavaid))
                return false;

            oglasavaid recievedObject = (oglasavaid)obj;
            if ((ugovorOIznajmljivanju.id_ugovora == recievedObject.ugovorOIznajmljivanju.id_ugovora) &&
                (klijentIzdavac.id_klijenta == recievedObject.klijentIzdavac.id_klijenta))
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
