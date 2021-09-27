using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_hopital_Ado.Mis_a_jour_Medecin
{
    public partial class Gestion_medecin : Form
    {
        int Max_Nbr_Medecin;
        int Position_Actuel = 0;
        My_typed_dataset.The_DataSet _DataSet = new My_typed_dataset.The_DataSet();
        My_typed_dataset.The_DataSetTableAdapters.medecinTableAdapter medecin_ADAPTER;
        My_typed_dataset.The_DataSetTableAdapters.specialiteTableAdapter specialite_ADAPTER;
        My_typed_dataset.The_DataSetTableAdapters.serviceeTableAdapter service_ADAPTER;

        public Gestion_medecin()
        {
            InitializeComponent();
        }

        private void Gestion_medecin_Load(object sender, EventArgs e)
        {


            medecin_ADAPTER = new My_typed_dataset.The_DataSetTableAdapters.medecinTableAdapter();
            medecin_ADAPTER.ClearBeforeFill = true;
            medecin_ADAPTER.Fill(_DataSet.medecin);

            Max_Nbr_Medecin = _DataSet.medecin.Rows.Count - 1;

            specialite_ADAPTER = new My_typed_dataset.The_DataSetTableAdapters.specialiteTableAdapter();
            specialite_ADAPTER.ClearBeforeFill = true;
            specialite_ADAPTER.Fill(_DataSet.specialite);

            service_ADAPTER = new My_typed_dataset.The_DataSetTableAdapters.serviceeTableAdapter();
            service_ADAPTER.ClearBeforeFill = true;
            service_ADAPTER.Fill(_DataSet.servicee);

            comboBox4.DataSource = _DataSet.medecin;
            comboBox4.DisplayMember = "nom";
            comboBox4.ValueMember = "id_medecin";

            comboBox2.DataSource = _DataSet.servicee;
            comboBox2.DisplayMember = "id_service";
            comboBox2.ValueMember = "id_service";

            comboBox1.DataSource = _DataSet.specialite;
            comboBox1.DisplayMember = "libelle";
            comboBox1.ValueMember = "id_specialite";

            comboBox5.DataSource = _DataSet.servicee;
            comboBox5.DisplayMember = "id_service";
            comboBox5.ValueMember = "id_service";

            Combo_specialite.DataSource = _DataSet.specialite;
            Combo_specialite.DisplayMember = "libelle";
            Combo_specialite.ValueMember = "id_specialite";

            comboBox3.Items.Add("Homme");
            comboBox3.Items.Add("Femme");

            comboBox7.Items.Add("Homme");
            comboBox7.Items.Add("Femme");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            _DataSet.medecin.AddmedecinRow(
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                dateTimePicker1.Value,
                comboBox3.Text,
                _DataSet.specialite.FindByid_specialite(int.Parse(comboBox1.SelectedValue.ToString())),
                _DataSet.servicee.FindByid_service(int.Parse(comboBox2.SelectedValue.ToString()))
                );
            Max_Nbr_Medecin++;
            MessageBox.Show(" MEdecin ajouté avec succée !");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            medecin_ADAPTER.Update(_DataSet.medecin);
        }

        private void ComboBox4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            textBox4.Text = _DataSet.medecin.FindByid_medecin(comboBox4.SelectedValue.ToString()).id_medecin;
            textBox5.Text = _DataSet.medecin.FindByid_medecin(comboBox4.SelectedValue.ToString()).nom;
            textBox6.Text = _DataSet.medecin.FindByid_medecin(comboBox4.SelectedValue.ToString()).prenom;
            dateTimePicker1.Value = _DataSet.medecin.FindByid_medecin(comboBox4.SelectedValue.ToString()).dtn;
            comboBox7.Text = _DataSet.medecin.FindByid_medecin(comboBox4.SelectedValue.ToString()).sexe;
            Combo_specialite.SelectedValue = _DataSet.medecin.FindByid_medecin(comboBox4.SelectedValue.ToString()).specialiteRow.id_specialite;
            Combo_specialite.Text = _DataSet.medecin.FindByid_medecin(comboBox4.SelectedValue.ToString()).specialiteRow.libelle;
            comboBox5.SelectedValue = _DataSet.medecin.FindByid_medecin(comboBox4.SelectedValue.ToString()).serviceeRow.id_service;
            comboBox5.Text = _DataSet.medecin.FindByid_medecin(comboBox4.SelectedValue.ToString()).serviceeRow.id_service.ToString();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text))
            {

                try
                {
                    if (DialogResult.Yes.Equals(MessageBox.Show("Avertissement !", "Voulez vous vraiment modifier Ce medecin ..?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)))
                    {
                        _DataSet.medecin.FindByid_medecin(textBox4.Text).BeginEdit();
                        _DataSet.medecin.FindByid_medecin(textBox4.Text).nom = textBox5.Text;
                        _DataSet.medecin.FindByid_medecin(textBox4.Text).prenom = textBox6.Text;
                        _DataSet.medecin.FindByid_medecin(textBox4.Text).serviceeRow = _DataSet.servicee.FindByid_service(int.Parse(comboBox5.SelectedValue.ToString()));
                        _DataSet.medecin.FindByid_medecin(textBox4.Text).dtn = dateTimePicker2.Value;
                        _DataSet.medecin.FindByid_medecin(textBox4.Text).sexe = comboBox7.Text;
                        _DataSet.medecin.FindByid_medecin(textBox4.Text).specialiteRow = _DataSet.specialite.FindByid_specialite(int.Parse(Combo_specialite.SelectedValue.ToString()));
                        _DataSet.medecin.FindByid_medecin(textBox4.Text).EndEdit();
                        MessageBox.Show("Medecin modifié avec succées !");
                    }
                }
                catch (Exception ee)
                { MessageBox.Show(ee.Message); }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            // if (DialogResult.Yes.Equals(MessageBox.Show("Avertissement !", "Voulez vous vraiment supprimer Ce medecin ..?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)))
            //   _DataSet.medecin.RemovemedecinRow(_DataSet.medecin.FindByid_medecin(textBox4.Text));
            // ou bien : 
            try
            {
                if (DialogResult.Yes.Equals(MessageBox.Show("Avertissement !", "Voulez vous vraiment supprimer Ce medecin ..?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)))
                {
                    _DataSet.medecin.FindByid_medecin(textBox4.Text).Delete();
                    MessageBox.Show("Medecin supprimé avec succées !");
                }
            }
            catch (Exception ee)
            { MessageBox.Show(ee.Message); }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox9.Text = _DataSet.medecin.First().id_medecin;
            //    .
            //    .
            //    .
            //    .
            // navigation des autres champs ...
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox9.Text = _DataSet.medecin.Last().id_medecin;
            //    .
            //    .
            //    .
            //    .
            // navigation des autres champs ...
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (Position_Actuel != 0)
            {
                Position_Actuel--;
                Move_To_Position();
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (Position_Actuel < Max_Nbr_Medecin)
            {
                Position_Actuel++;
                Move_To_Position();
            }
        }

        private void Move_To_Position()
        {
            textBox9.Text = _DataSet.medecin[Position_Actuel].id_medecin;
            //    .
            //    .
            //    .
            //    .
            // navigation des autres champs ...
        }
    }
}
