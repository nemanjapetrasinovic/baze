using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class radiuid
    {
        public virtual zaposleni zaposleniRadiU { get; set; }
        public virtual poslovnica radiUPoslovnica { get; set; }

        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj.GetType() != typeof(radiuid))
                return false;

            radiuid recievedObject = (radiuid)obj;
            if((zaposleniRadiU.id_zaposlenog == recievedObject.zaposleniRadiU.id_zaposlenog)&&
                (radiUPoslovnica.id_poslovnice==recievedObject.radiUPoslovnica.id_poslovnice))
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
