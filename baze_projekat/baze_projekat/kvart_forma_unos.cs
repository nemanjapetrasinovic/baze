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
    public partial class kvart_forma_unos : Form
    {
        public kvart_forma_unos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            string prodavnicaizcombo = comboBox1.GetItemText(comboBox1.SelectedItem);
            string str = prodavnicaizcombo.Substring(2,3);
            Entiteti.poslovnica p = s.Load<Entiteti.poslovnica>(Int32.Parse(str));
            kvart k = new kvart()
            {
                gradska_zona = this.textBox1.Text
            };

            k.pripadaPoslovnici = p;
            p.Kvart.Add(k);
            s.Save(k);
            s.Flush();
            s.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kvart_forma_unos_Load(object sender, EventArgs e)
        {
            ISession s = DataLayer.GetSession();
            ISQLQuery q = s.CreateSQLQuery("SELECT O.* FROM POSLOVNICA O");
            q.AddEntity(typeof(poslovnica));


            IList<poslovnica> sveposlovnice = q.List<poslovnica>();
            String comboboxitem;
            int i = 0;
            foreach (poslovnica o in sveposlovnice)
            {
                comboboxitem = i.ToString()+' '+o.id_poslovnice + ' ' + o.ime_ulice;
                comboBox1.Items.Add(comboboxitem);
                i++;
            }
            s.Close();
        }
    }
}
