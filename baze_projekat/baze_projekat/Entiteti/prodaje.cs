using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class prodaje
    {
        public virtual prodajeid id_prodaje { get; set; }

        public prodaje()
        {
            id_prodaje = new prodajeid();
        }
    }
}
