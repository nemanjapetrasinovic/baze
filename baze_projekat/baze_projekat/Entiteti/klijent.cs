using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baze_projekat.Entiteti
{
    public class klijent
    {
        public virtual int id_klijenta { get; protected set; }
        public virtual string jmbg { get; set; }
        public virtual string lime { get; set; }
        public virtual string sslovo { get; set; }
        public virtual string prezime { get; set; }
        public virtual string ime_ulice { get; set; }
        public virtual string broj_ulice { get; set; }
        public virtual string telefon { get; set; }
        public virtual string email { get; set; }
        //public virtual int flag_tip { get; set; }

        public virtual IList<prodaje> Vlasnik { get; set; }

        public virtual IList<kupoprodajni> Ugovori { get; set; }

        public klijent()
        {

            Vlasnik = new List<prodaje>();

            Ugovori = new List<kupoprodajni>();
        }
    }

    public class vlasnikfizicko : klijent
    {
        public vlasnikfizicko()
        {

        }
    }
    public class vlasnikpravno : klijent
    {
        public virtual string pib { get; set; }
        public virtual string adresa_sedista { get; set; }
        public vlasnikpravno()
        {

        }
    }

    public class kupacfizicko : klijent
    {
        //public virtual IList<trazi> Vlasnik { get; set; }

        public virtual IList<iznajmljivanje> Ugovori1 { get; set; }

        public kupacfizicko()
        {

            //Vlasnik = new List<trazi>();

            Ugovori1 = new List<iznajmljivanje>();
        }
    }
    public class kupacpravno : klijent
    {
        public virtual string pib { get; set; }
        public virtual string adresa_sedista { get; set; }
        public kupacpravno()
        {

        }
    }
}
