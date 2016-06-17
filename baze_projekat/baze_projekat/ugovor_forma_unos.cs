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
    public partial class ugovor_forma_unos : Form
    {
        public ugovor_forma_unos()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                ISession s = DataLayer.GetSession();
                ISQLQuery q = s.CreateSQLQuery("SELECT O.* FROM NEKRETNINA O WHERE FLAG_STAMBENI=0");
                q.AddEntity(typeof(poslovni));


                IList<poslovni> svenekretnine = q.List<poslovni>();
                dataGridView1.DataSource = svenekretnine;
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                ISession s = DataLayer.GetSession();
                ISQLQuery q = s.CreateSQLQuery("SELECT O.* FROM NEKRETNINA O WHERE FLAG_STAMBENI=1");
                q.AddEntity(typeof(stambeni));
                

                IList<stambeni> svenekretnine = q.List<stambeni>();
                foreach (stambeni o in svenekretnine)
                {
                    //MessageBox.Show(o.id_kvarta.ToString());
                }
                dataGridView1.DataSource = svenekretnine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
