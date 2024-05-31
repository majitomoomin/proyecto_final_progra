using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_final_
{
    public partial class FormHistorial : Form
    {
        public FormHistorial()
        {
            InitializeComponent();

            using (SqlConnection con = new SqlConnection("data source=LAPTOP-GDV6M1II\\SQLEXPRESS;database=clinica;integrated security=True"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from AddPatient inner join ParientMore on AddPatient.pid = PatientMore.pid";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridViewHistorial.DataSource = dataSet.Tables[0];
            }
        }
        private void FormHistorial_Load(object sender, EventArgs e)
        {

        }
    }
}
