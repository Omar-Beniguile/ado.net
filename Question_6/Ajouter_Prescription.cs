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

namespace tp_hopital_Ado.Question_6
{
    public partial class Ajouter_Prescription : Form
    {
        HopitalEntities My_Contexxt = new HopitalEntities();
        public Ajouter_Prescription()
        {
            InitializeComponent();
        }

        private void Ajouter_Prescription_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = My_Contexxt.medecins.ToList<medecin>();
            comboBox1.DisplayMember = "nom";
            comboBox1.ValueMember = "id_medecin";

            comboBox2.DataSource = My_Contexxt.patients.ToList<patient>();
            comboBox2.DisplayMember = "nom";
            comboBox2.ValueMember = "id_patient";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            My_Contexxt.soignes.Add(new soigne()
            {
                id_soin = int.Parse(textBox1.Text),
                id_patientt_ = int.Parse(comboBox2.SelectedValue.ToString()),
                id_medecinn_ = comboBox2.SelectedValue.ToString(),
                nom_maladie = textBox2.Text,
                commentaire = richTextBox1.Text,
                date_soigne = dateTimePicker1.Value
            });
            My_Contexxt.SaveChanges();
        }
    }
}
