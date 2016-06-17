using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using baze_projekat.Entiteti;

namespace baze_projekat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Entiteti.nekretnina p = s.Load<Entiteti.nekretnina>(333);

                MessageBox.Show(p.ime_ulice.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            ISQLQuery q = s.CreateSQLQuery("SELECT O.* FROM POSLOVNICA O");
            q.AddEntity(typeof(poslovnica));


            IList<poslovnica> sveposlovnice = q.List<poslovnica>();

            foreach (poslovnica o in sveposlovnice)
            {
                MessageBox.Show(o.ime_ulice.ToString());
            }

            s.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                
                Entiteti.klijent p = s.Load<Entiteti.klijent>(323);

                MessageBox.Show(p.lime.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();

            ISQLQuery q = s.CreateSQLQuery("SELECT O.* FROM KVART O");
            q.AddEntity(typeof(kvart));


            IList<kvart> svikvartovi = q.List<kvart>();

            foreach (kvart o in svikvartovi)
            {
                MessageBox.Show(o.gradska_zona.ToString());
            }

            s.Close();
        }
        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Entiteti.nekretnina p = s.Load<Entiteti.nekretnina>(333);

                MessageBox.Show(p.ime_ulice.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Entiteti.agent p = s.Load<Entiteti.agent>(8);

                MessageBox.Show(p.lime.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Entiteti.ugovor p = s.Load<Entiteti.ugovor>(11);

                MessageBox.Show(p.ugovorio.id_zaposlenog.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Entiteti.za_iznajmljivanje p = s.Load<Entiteti.za_iznajmljivanje>(444);

                MessageBox.Show(p.iznajmljujeUgovor.kirija.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Entiteti.za_prodaju p = s.Load<Entiteti.za_prodaju>(333);

                MessageBox.Show(p.kupoprodajniUgovor.datum_transakcije.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Entiteti.kvart p = s.Load<Entiteti.kvart>(3);

                MessageBox.Show(p.pripadaPoslovnici.id_poslovnice.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                //Ucitavaju se podaci o prodavnici za zadatim brojem
                Entiteti.stambeni p =s.Load<Entiteti.stambeni>(333);
                //zaposleni z = (zaposleni)s.GetSessionImplementation().PersistenceContext.Unproxy(p);
                MessageBox.Show(p.broj_kupatila.ToString());

                s.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            Entiteti.poslovnica p = s.Load<Entiteti.poslovnica>(333);
            kvart k = new kvart()
            {
                gradska_zona = "Podunavci",
                //id_poslovnice = p.id_poslovnice
               
            };

            k.pripadaPoslovnici = p;
            p.Kvart.Add(k);
            s.Save(p);
            s.Flush();
            s.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            nekretnina_forma_unos forma = new nekretnina_forma_unos();
            forma.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ugovor_forma_unos forma = new ugovor_forma_unos();
            forma.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            kvart_forma_unos forma = new kvart_forma_unos();
            forma.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            nekretnina_forma_unos forma = new nekretnina_forma_unos();
            forma.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            zaposleni_forma_unos forma = new zaposleni_forma_unos();
            forma.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            klijent_forma_unos forma = new klijent_forma_unos();
            forma.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            obrisi_izmeni_radnika_forma forma = new obrisi_izmeni_radnika_forma();
            forma.Show();
        }
    }
}
