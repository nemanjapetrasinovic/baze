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
    public partial class nekretnina_forma_unos : Form
    {
        public nekretnina_forma_unos()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                groupBox2.Enabled = true;
            else groupBox2.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                groupBox3.Enabled = true;
            else groupBox3.Enabled = false;
        }

        private void nekretnina_forma_unos_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            ISQLQuery q = s.CreateSQLQuery("SELECT O.* FROM KVART O");
            q.AddEntity(typeof(kvart));


            IList<kvart> svikvartovi = q.List<kvart>();
            String comboboxitem;
            int i = 0;
            foreach (kvart o in svikvartovi)
            {
                comboboxitem = i.ToString() + ' ' + o.id_kvarta + ' ' + o.gradska_zona;
                comboBox1.Items.Add(comboboxitem);
                i++;
            }
            s.Close();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
            {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    //stambeni

                    ISession s = DataLayer.GetSession();
                    string kvartizcombo = comboBox1.GetItemText(comboBox1.SelectedItem);
                    string str = kvartizcombo.Substring(2, 2);
                    Entiteti.kvart k = s.Load<Entiteti.kvart>(3);
                    string godina1 = dateTimePicker1.Value.Date.Year.ToString();
                    string godina2 = DateTime.Now.Date.Year.ToString();
                    stambeni st = new stambeni()
                    {
                        ime_ulice = textBox1.Text,
                        broj_ulice = textBox2.Text,
                        sprat = Int32.Parse(textBox3.Text),
                        datum_izgradnje = dateTimePicker1.Value.Date,
                        starost = Int32.Parse(godina2)-Int32.Parse(godina1),
                        cena = Int32.Parse(textBox7.Text),
                        flag_stambeni = 1,
                        broj_kupatila = Int32.Parse(textBox8.Text),
                    };

                    st.pripadaKvartu = k;
                    k.Nekretnina.Add(st);
                    s.Save(st);
                    s.Flush();
                    s.Close();

                }
                if(radioButton2.Checked)
                {
                        //poslovni

                        ISession s = DataLayer.GetSession();
                        string kvartizcombo = comboBox1.GetItemText(comboBox1.SelectedItem);
                        string str = kvartizcombo.Substring(2, 2);
                        Entiteti.kvart k = s.Load<Entiteti.kvart>(3);
                        string godina1 = dateTimePicker1.Value.Date.Year.ToString();
                        string godina2 = DateTime.Now.Date.Year.ToString();
                        string konfsalastr;
                        if (radioButton3.Checked)
                            konfsalastr = "Da";
                        else if (radioButton4.Checked)
                            konfsalastr = "Ne";
                        else konfsalastr = "Ne";
                        poslovni po = new poslovni()
                        {
                            ime_ulice = textBox1.Text,
                            broj_ulice = textBox2.Text,
                            sprat = Int32.Parse(textBox3.Text),
                            datum_izgradnje = dateTimePicker1.Value.Date,
                            starost = Int32.Parse(godina2) - Int32.Parse(godina1),
                            cena = Int32.Parse(textBox7.Text),
                            flag_stambeni = 1,
                            konf_sala=konfsalastr,
                            oprema=richTextBox1.Text
                        };

                        po.pripadaKvartu = k;
                        k.Nekretnina.Add(po);
                        s.Save(po);
                        s.Flush();
                        s.Close();

                    }
            }
            catch (Exception ec)
            {
                System.Windows.Forms.MessageBox.Show(ec.Message);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox7.Clear();
            textBox8.Clear();
            richTextBox1.Clear();
            if (radioButton1.Checked)
                radioButton1.Checked = false;
            if (radioButton2.Checked)
                radioButton2.Checked = false;
            if (radioButton3.Checked)
                radioButton3.Checked = false;
            if (radioButton4.Checked)
                radioButton4.Checked = false;
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Today;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
