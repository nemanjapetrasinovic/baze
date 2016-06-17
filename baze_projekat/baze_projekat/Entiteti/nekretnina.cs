using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class nekretnina
    {
        public virtual int id_nekretnine { get; set; }
        public virtual string ime_ulice { get; set; }
        public virtual string broj_ulice { get; set; }
        public virtual int sprat { get; set; }
        public virtual DateTime datum_izgradnje { get; set; }
        public virtual int starost { get; set; }
        public virtual int cena { get; set; }
        public virtual int flag_stambeni { get; set; }
        public virtual int id_kvarta { get; set; }
        public virtual kvart pripadaKvartu { get; set; }
    }
    public class stambeni:nekretnina
    {
        public virtual int broj_kupatila { get; set; }
        public stambeni()
        {
            
        }
    }
    public class poslovni : nekretnina
    {
        public virtual string konf_sala { get; set; }
        public virtual string oprema { get; set; }
        public poslovni()
        {

        }
    }
}
