using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using baze_projekat.Entiteti;
using NHibernate;
using baze_projekat.Data_Access;
using NHibernate.Linq;

namespace baze_projekat
{
    public partial class obrisi_izmeni_radnika_forma : Form
    {
        public obrisi_izmeni_radnika_forma()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();


                if (textBox2.Text != "" && textBox3.Text !="" && textBox4.Text !="")
                {
                    IList<zaposleni> zaposleni = (from o in s.Query<zaposleni>()
                                                  where (o.lime == textBox2.Text && o.sslovo == textBox3.Text && o.prezime == textBox4.Text)
                                                  select o).ToList<zaposleni>();
                    dataGridView1.DataSource = zaposleni;
                }
                else
                if (textBox2.Text!="" && textBox3.Text!="")
                {
                    IList<zaposleni> zaposleni = (from o in s.Query<zaposleni>()
                                                  where (o.lime==textBox2.Text && o.sslovo==textBox3.Text)
                                                  select o).ToList<zaposleni>();
                    dataGridView1.DataSource = zaposleni;
                }
                else
                if (textBox3.Text != "" && textBox4.Text != "")
                {
                    IList<zaposleni> zaposleni = (from o in s.Query<zaposleni>()
                                                  where (o.sslovo == textBox3.Text && o.prezime == textBox4.Text)
                                                  select o).ToList<zaposleni>();
                    dataGridView1.DataSource = zaposleni;
                }
                else
                if (textBox2.Text != "" && textBox4.Text != "")
                {
                    IList<zaposleni> zaposleni = (from o in s.Query<zaposleni>()
                                                  where (o.lime == textBox2.Text && o.prezime == textBox4.Text)
                                                  select o).ToList<zaposleni>();
                    dataGridView1.DataSource = zaposleni;
                }
                else
                if (textBox1.Text != "")
                {
                    IList<zaposleni> zaposleni = (from o in s.Query<zaposleni>()
                                                  where (o.jmbg == textBox1.Text)
                                                  select o).ToList<zaposleni>();
                    dataGridView1.DataSource = zaposleni;
                }
                else
                if(textBox2.Text != "")
                {
                    IList<zaposleni> zaposleni = (from o in s.Query<zaposleni>()
                                                  where (o.lime == textBox2.Text)
                                                  select o).ToList<zaposleni>();
                    dataGridView1.DataSource = zaposleni;
                }
                else
                if (textBox3.Text != "")
                {
                    IList<zaposleni> zaposleni = (from o in s.Query<zaposleni>()
                                                  where (o.lime == textBox3.Text)
                                                  select o).ToList<zaposleni>();
                    dataGridView1.DataSource = zaposleni;
                }
                else
                if (textBox4.Text != "")
                {
                    IList<zaposleni> zaposleni = (from o in s.Query<zaposleni>()
                                                  where (o.lime == textBox4.Text)
                                                  select o).ToList<zaposleni>();
                    dataGridView1.DataSource = zaposleni;
                }
                else
                {
                    //IList<zaposleni> zaposleni = (from o in s.Query<zaposleni>()
                    //                              select o).ToList<zaposleni>();
                    //dataGridView1.DataSource = zaposleni;
                    IList<sef> sef = (from o in s.Query<sef>()
                                      select o).ToList<sef>();
                   
                    IList<prodavac> prodavac = (from o in s.Query<prodavac>()
                                                select o).ToList<prodavac>();
                    dataGridView1.DataSource = sef;
                    dataGridView2.DataSource = prodavac;
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                int a = dataGridView1.CurrentCell.RowIndex;

            DataGridViewRow red = dataGridView1.Rows[a];
            string b = Convert.ToString(red.Cells[0].Value);
            
            if(red.Cells[5].ToString()=="1")
            {
                    prodavac p = s.Load<prodavac>(Int32.Parse(b));
            }
            }
            catch (Exception ex)
            {

            }

        }

    }
}
