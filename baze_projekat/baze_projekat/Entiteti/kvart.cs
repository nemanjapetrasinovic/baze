using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class kvart
    {
        public virtual int id_kvarta { get; protected set; }
        public virtual string gradska_zona { get; set; }
        public virtual int id_poslovnice { get; set; }

        public virtual IList<nekretnina> Nekretnina { get; set; }
        public virtual poslovnica pripadaPoslovnici { get; set; }


        public kvart()
        {
            Nekretnina = new List<nekretnina>();
        }
    }
}
