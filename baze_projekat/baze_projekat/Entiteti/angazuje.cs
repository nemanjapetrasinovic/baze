using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class angazuje
    {
        public virtual angazujeid id_angazovanja { get; set; }
        public virtual DateTime datum_angazovanja { get; set; }
    }
}
