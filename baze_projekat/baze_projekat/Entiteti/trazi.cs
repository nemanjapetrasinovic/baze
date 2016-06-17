using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class trazi
    {
        public virtual traziid id_trazenja { get; set; }

        public trazi()
        {
            id_trazenja = new traziid();
        }
    }
}
