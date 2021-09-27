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
    public partial class question_B : Form
    {
        private SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-1FH4R7E\SQLEXPRESS;Initial Catalog=Hopital;Integrated Security=True");
        public question_B()
        {
            InitializeComponent();
            connection.Open();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Test that if you want .. :
            //dateTimePicker1.Value = DateTime.Parse("2000-01-10");
            SqlCommand command = new SqlCommand(@"select p.* , s.date_entree , s.date_sortie
                                                  from sejourne s inner join patient p on s.id_patientt# = p.id_patient
                                                  where s.date_sortie = @LA_Date", connection);
            command.Parameters.AddWithValue("@LA_Date", dateTimePicker1.Value.ToString());
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView1.DataSource = table;
            }
            reader.Close();
        }

        private void Question_B_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        private void question_B_Load(object sender, EventArgs e)
        {

        }
    }
}
