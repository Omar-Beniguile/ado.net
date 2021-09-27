using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//*************
using tp_hopital_Ado.My_Data;
//*************

namespace tp_hopital_Ado.Mis_a_jour_hoptal
{
    public partial class gestion_hopitaux : Form
    {
        My_Data.HopitalEntities My_Context = new My_Data.HopitalEntities();
        int index_Hopital = 0;
        public gestion_hopitaux()
        {
            InitializeComponent();
        }

        private void Gestion_hopitaux_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = My_Context.hopitales.ToList<hopitale>();
            comboBox1.DisplayMember = "nom";
            comboBox1.ValueMember = "id_hopital";

            textBox10.Text = My_Context.hopitales.First().id_hopital.ToString();
            textBox9.Text = My_Context.hopitales.First().nom;
            textBox11.Text = My_Context.hopitales.First().adresse;
            textBox12.Text = My_Context.hopitales.First().ville;
        }

        private void Btn_ajout_Click(object sender, EventArgs e)
        {
            My_Context.hopitales.Add(new hopitale()
            {
                id_hopital = int.Parse(textBox4.Text),
                nom = textBox1.Text,
                adresse = textBox2.Text,
                ville = textBox3.Text,
            });
        }

        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox6.Text = My_Context.hopitales.Find(int.Parse(comboBox1.SelectedValue.ToString())).id_hopital.ToString();
            textBox5.Text = My_Context.hopitales.Find(int.Parse(comboBox1.SelectedValue.ToString())).nom.ToString();
            textBox7.Text = My_Context.hopitales.Find(int.Parse(comboBox1.SelectedValue.ToString())).adresse.ToString();
            textBox8.Text = My_Context.hopitales.Find(int.Parse(comboBox1.SelectedValue.ToString())).ville.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My_Context.hopitales.Find(int.Parse(textBox6.Text)).nom = textBox5.Text;
            My_Context.hopitales.Find(int.Parse(textBox6.Text)).adresse = textBox7.Text;
            My_Context.hopitales.Find(int.Parse(textBox6.Text)).ville = textBox8.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            My_Context.hopitales.Remove(My_Context.hopitales.Find(int.Parse(textBox6.Text)));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            textBox10.Text = My_Context.hopitales.First().id_hopital.ToString();
            textBox9.Text = My_Context.hopitales.First().nom;
            textBox11.Text = My_Context.hopitales.First().adresse;
            textBox12.Text = My_Context.hopitales.First().ville;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            //textBox10.Text = My_Context.hopitales.Last<hopitale>().id_hopital.ToString();
            //textBox9.Text = My_Context.hopitales.Last<hopitale>().nom;
            //textBox11.Text = My_Context.hopitales.Last<hopitale>().adresse;
            //textBox12.Text = My_Context.hopitales.Last<hopitale>().ville;

            textBox10.Text = My_Context.hopitales.ToList<hopitale>()[My_Context.hopitales.ToList<hopitale>().Count-1].id_hopital.ToString();
            textBox9.Text = My_Context.hopitales.ToList<hopitale>()[My_Context.hopitales.ToList<hopitale>().Count - 1].nom;
            textBox11.Text = My_Context.hopitales.ToList<hopitale>()[My_Context.hopitales.ToList<hopitale>().Count - 1].adresse;
            textBox12.Text = My_Context.hopitales.ToList<hopitale>()[My_Context.hopitales.ToList<hopitale>().Count - 1].ville;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (index_Hopital != 0)
            {
                index_Hopital--;
                Bouge();
            }
        }

        private void Bouge()
        {
            textBox10.Text = My_Context.hopitales.ToList<hopitale>()[index_Hopital].id_hopital.ToString();
            textBox9.Text = My_Context.hopitales.ToList<hopitale>()[index_Hopital].nom;
            textBox11.Text = My_Context.hopitales.ToList<hopitale>()[index_Hopital].adresse;
            textBox12.Text = My_Context.hopitales.ToList<hopitale>()[index_Hopital].ville;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (index_Hopital < My_Context.hopitales.ToList().Count)
            {
                index_Hopital++;
                Bouge();
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            My_Context.SaveChanges();

            comboBox1.DataSource = My_Context.hopitales.ToList<hopitale>();
            comboBox1.DisplayMember = "nom";
            comboBox1.ValueMember = "id_hopital";
        }
    }
}
