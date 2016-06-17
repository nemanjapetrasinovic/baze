using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class kupujeid
    {
        public virtual ugovor ugovorOKupovini { get; set; }
        public virtual klijent klijentKupac { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(kupujeid))
                return false;

            kupujeid recievedObject = (kupujeid)obj;
            if ((ugovorOKupovini.id_ugovora == recievedObject.ugovorOKupovini.id_ugovora) &&
                (klijentKupac.id_klijenta == recievedObject.klijentKupac.id_klijenta))
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
