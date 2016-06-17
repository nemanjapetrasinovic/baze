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
    public partial class klijent_forma_unos : Form
    {
        public klijent_forma_unos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.GetItemText(comboBox1.SelectedItem) == "kupac_fizicko")
                {
                    ISession s = DataLayer.GetSession();
                    kupacfizicko kp = new kupacfizicko()
                    {
                        jmbg = textBox1.Text,
                        lime = textBox2.Text,
                        sslovo = textBox3.Text,
                        prezime = textBox4.Text,
                        ime_ulice = textBox9.Text,
                        broj_ulice = textBox10.Text,
                        telefon = textBox5.Text,
                        email = textBox6.Text,
                    };
                    s.Save(kp);
                    s.Flush();
                    s.Close();
                }
                if (comboBox1.GetItemText(comboBox1.SelectedItem) == "vlasnik_fizicko")
                {
                    ISession s = DataLayer.GetSession();
                    vlasnikfizicko kp = new vlasnikfizicko()
                    {
                        jmbg = textBox1.Text,
                        lime = textBox2.Text,
                        sslovo = textBox3.Text,
                        prezime = textBox4.Text,
                        ime_ulice = textBox9.Text,
                        broj_ulice = textBox10.Text,
                        telefon = textBox5.Text,
                        email = textBox6.Text,
                    };
                    s.Save(kp);
                    s.Flush();
                    s.Close();
                }
                if (comboBox1.GetItemText(comboBox1.SelectedItem) == "kupac_pravno")
                {

                    ISession s = DataLayer.GetSession();
                    kupacpravno kp = new kupacpravno()
                    {
                        jmbg = textBox1.Text,
                        lime = textBox2.Text,
                        sslovo = textBox3.Text,
                        prezime = textBox4.Text,
                        ime_ulice = textBox9.Text,
                        broj_ulice = textBox10.Text,
                        telefon = textBox5.Text,
                        email = textBox6.Text,
                        pib = textBox8.Text,
                        adresa_sedista = textBox7.Text
                    };
                    s.Save(kp);
                    s.Flush();
                    s.Close();
                }
                if (comboBox1.GetItemText(comboBox1.SelectedItem) == "vlasnik_pravno")
                {

                    ISession s = DataLayer.GetSession();
                    vlasnikpravno kp = new vlasnikpravno()
                    {
                        jmbg = textBox1.Text,
                        lime = textBox2.Text,
                        sslovo = textBox3.Text,
                        prezime = textBox4.Text,
                        ime_ulice = textBox9.Text,
                        broj_ulice = textBox10.Text,
                        telefon = textBox5.Text,
                        email = textBox6.Text,
                        pib = textBox8.Text,
                        adresa_sedista = textBox7.Text
                    };
                    s.Save(kp);
                    s.Flush();
                    s.Close();
                }

            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.GetItemText(comboBox1.SelectedItem) == "kupac_pravno" || comboBox1.GetItemText(comboBox1.SelectedItem) == "vlasnik_pravno")
            {
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                label11.Enabled = true;
                label12.Enabled = true;
            }
            else
            {
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                label11.Enabled = false;
                label12.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
