using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class prodajeid
    {
        public virtual ugovor ugovorOProdaji { get; set; }
        public virtual klijent klijentKupac { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(prodajeid))
                return false;

            prodajeid recievedObject = (prodajeid)obj;
            if ((ugovorOProdaji.id_ugovora == recievedObject.ugovorOProdaji.id_ugovora) &&
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
