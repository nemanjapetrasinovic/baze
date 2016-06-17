using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class angazujeid
    {
        public virtual prodavac prodavacAngazuje { get; set; }
        public virtual agent angazovanOd { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(angazujeid))
                return false;

            angazujeid recievedObject = (angazujeid)obj;
            if ((prodavacAngazuje.id_zaposlenog == recievedObject.prodavacAngazuje.id_zaposlenog) &&
                (angazovanOd.id_agenta == recievedObject.angazovanOd.id_agenta))
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
