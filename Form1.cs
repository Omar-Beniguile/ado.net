using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_hopital_Ado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void MiseÀJourDesHopitauxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mis_a_jour_hoptal.gestion_hopitaux gestion_Hopitaux = new Mis_a_jour_hoptal.gestion_hopitaux();
            gestion_Hopitaux.MdiParent = this;
            gestion_Hopitaux.Show();
        }


        private void PréscrireUneOrdonnanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question_6.Ajouter_Prescription ajouter_Prescription = new Question_6.Ajouter_Prescription();
            ajouter_Prescription.MdiParent = this;
            ajouter_Prescription.Show();
        }

        private void GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question_7.question_A _A = new Question_7.question_A();
            _A.MdiParent = this;
            _A.Show();
        }

        private void GérerLesPatientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question_7.question_B _B = new Question_7.question_B();
            _B.MdiParent = this;
            _B.Show();
        }

    

        private void MiseÀJourDesMedecinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mis_a_jour_Medecin.Gestion_medecin _Medecin = new Mis_a_jour_Medecin.Gestion_medecin();
            _Medecin.MdiParent = this;
            _Medecin.Show();
        }

        private void Impr_Click(object sender, EventArgs e)
        {
            My_Reports.Form_container_Rapport form = new My_Reports.Form_container_Rapport();
            form.MdiParent = this;
            form.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
