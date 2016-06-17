using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class zaposleni
    {
        public virtual int id_zaposlenog { get; set; }
        public virtual string jmbg { get; set; }
        public virtual string lime { get; set; }
        public virtual string sslovo { get; set; }
        public virtual string prezime { get; set; }
        //public virtual int flag_prodavac { get; set; }
        public virtual IList<ugovor> Ugovor { get; set; }


        public zaposleni()
        {
            Ugovor = new List<ugovor>();
        }
    }
    public class prodavac : zaposleni
    {

        public virtual IList<radi_u> ProdajeUProdavnicama { get; set; }

        public virtual string strucna_sprema { get; set; }

        public prodavac()
        {
           ProdajeUProdavnicama = new List<radi_u>();
        }
    }

    public class sef : zaposleni
    {
        public virtual IList<sefuje> SefujeUProdavnicama { get; set; }

        public sef()
        {
            SefujeUProdavnicama = new List<sefuje>();
        }
    }

}
