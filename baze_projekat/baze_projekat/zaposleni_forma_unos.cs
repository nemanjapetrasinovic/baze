using baze_projekat.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baze_projekat
{
    public partial class zaposleni_forma_unos : Form
    {
        public zaposleni_forma_unos()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            ISQLQuery q = s.CreateSQLQuery("SELECT O.* FROM POSLOVNICA O");
            q.AddEntity(typeof(poslovnica));


            IList<poslovnica> sveposlovnice = q.List<poslovnica>();
            String comboboxitem;
            int i = 0;
            foreach (poslovnica o in sveposlovnice)
            {
                comboboxitem = i.ToString() + ' ' + o.id_poslovnice + ' ' + o.ime_ulice;
                comboBox1.Items.Add(comboboxitem);
                i++;
            }
            s.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    //sef
                    ISession s = DataLayer.GetSession();
                    string prodavnicaizcombo = comboBox1.GetItemText(comboBox1.SelectedItem);
                    string str = prodavnicaizcombo.Substring(2, 3);
                    Entiteti.poslovnica p = s.Load<Entiteti.poslovnica>(Int32.Parse(str));

                    sef z = new sef()
                    {
                        jmbg = textBox5.Text,
                        lime = textBox1.Text,
                        sslovo = textBox2.Text,
                        prezime = textBox4.Text
                    };

                    sefuje su = new sefuje()
                    {
                        datum_postavljenja = dateTimePicker1.Value.Date,
                    };
                    su.id_sefovanja.zaposleniSefujeU = z;
                    su.id_sefovanja.sefujeUPoslovnici = p;
                    //ru.Prodavac = z;
                    //ru.Radi = p;
                    z.SefujeUProdavnicama.Add(su);
                    s.Save(z);
                    s.Save(su);
                    s.Flush();
                    s.Close();
                }
                if (radioButton2.Checked)
                {
                    //prodavac
                    ISession s = DataLayer.GetSession();
                    string prodavnicaizcombo = comboBox1.GetItemText(comboBox1.SelectedItem);
                    string str = prodavnicaizcombo.Substring(2, 3);
                    Entiteti.poslovnica p = s.Load<Entiteti.poslovnica>(Int32.Parse(str));

                    prodavac z = new prodavac()
                    {
                        jmbg = textBox5.Text,
                        lime = textBox1.Text,
                        sslovo = textBox2.Text,
                        prezime = textBox4.Text,
                        strucna_sprema = textBox3.Text
                    };

                    radi_u ru = new radi_u()
                    {
                        datum_od = dateTimePicker1.Value.Date,
                    };
                    ru.id_radi_u.radiUPoslovnica = p;
                    ru.id_radi_u.zaposleniRadiU = z;
                    //ru.Prodavac = z;
                    //ru.Radi = p;
                    z.ProdajeUProdavnicama.Add(ru);
                    s.Save(z);
                    s.Save(ru);
                    s.Flush();
                    s.Close();
                }
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                groupBox1.Enabled = true;
            else groupBox1.Enabled = false;
        }
    }
}
