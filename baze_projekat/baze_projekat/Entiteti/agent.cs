using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class agent
    {
        public virtual int id_zaposlenog { get; set; }
        public virtual int id_agenta { get; protected set; }
        public virtual string lime { get; set; }
        public virtual string sslovo { get; set; }
        public virtual string prezime { get; set; }
        public virtual int telefon { get; set; }
        public virtual int procenat { get; set; }
    }
}
