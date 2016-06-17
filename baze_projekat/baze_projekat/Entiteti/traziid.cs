using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class traziid
    {
        public virtual ugovor ugovorOIznajmljivanju { get; set; }
        public virtual kupacfizicko klijentPodstanar { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(traziid))
                return false;

            traziid recievedObject = (traziid)obj;
            if ((ugovorOIznajmljivanju.id_ugovora == recievedObject.ugovorOIznajmljivanju.id_ugovora) &&
                (klijentPodstanar.id_klijenta == recievedObject.klijentPodstanar.id_klijenta))
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
