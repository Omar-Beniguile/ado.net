using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tp_hopital_Ado.Question_7
{
    public partial class question_A : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1FH4R7E\SQLEXPRESS;Initial Catalog=Hopital;Integrated Security=True");
        public question_A()
        {
            InitializeComponent();
            connection.Open();
        }
        private void Question_A_Load(object sender, EventArgs e)
        {
            using (My_Data.HopitalEntities My_Contexxt = new My_Data.HopitalEntities())
            {
                comboBox1.DataSource = My_Contexxt.hopitales.ToList<My_Data.hopitale>();
                comboBox1.ValueMember = "id_hopital";
                comboBox1.DisplayMember = "nom";
            };
        }

        private void ComboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand(@"select h.id_hopital , h.nom , s.id_service , s.nbr_lit , count( m.id_medecin ) as 'nbr Medecin'
                                                  from servicee s inner join hopitale h on s.id_hopitall# = h.id_hopital inner join medecin m on m.id_service = s.id_service
                                                  where h.id_hopital = @ID_H
                                                  group by  h.id_hopital , h.nom , s.id_service , s.nbr_lit ", connection);
            command.Parameters.AddWithValue("@ID_H", comboBox1.SelectedValue);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView1.DataSource = table;
            }
            reader.Close();
        }

        private void Question_A_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
    }
}
