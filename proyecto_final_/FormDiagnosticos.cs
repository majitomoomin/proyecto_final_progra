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
    public partial class FormDiagnosticos : Form
    {
        public FormDiagnosticos()
        {
            InitializeComponent();
        }

        private void FormDiagnosticos_Load(object sender, EventArgs e)
        {

        }
        //guardar datos
        private void btnGuardardiagnostico_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(txtpid.Text);
                String Sintomas = txtSintomas.Text;
                String Procedimiento_med = txtProcedimiento.Text;
                String Diagnosis = txtDiagnosis.Text;
                String Alergias = txtAlergias.Text;
                String Medicamentos = txtMedicamentos.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=LAPTOP-GDV6M1II\\SQLEXPRESS;database=clinica;integrated security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into AgregarPaciente values("+Sintomas+",'"+ Procedimiento_med+"','"+Diagnosis+"','"+Alergias+"','"+pid+"'")";
                SqlDataAdapter DA = new SqlDataAdapter();
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
            catch (Exception) 
            {
                MessageBox.Show("No se encontro o algún caracter es incorrecto");
            }
            MessageBox.Show("Guardado");

            // Limpia los campos después de guardar los datos
            txtSintomas.Clear();
            txtProcedimiento.Clear();
            txtDiagnosis.Clear();
            txtAlergias.Clear();
            txtMedicamentos.Clear();
            txtpid.Clear();
        }

        //para que al esccribir se busque el pid y lo muestre en el datagrid
        private void txtpid_TextChanged(object sender, EventArgs e)
        {
            if (txtpid.Text != "")
            {
                int pid = Convert.ToInt32(txtpid.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source=LAPTOP-GDV6M1II\\SQLEXPRESS;database=clinica;integrated security=True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from AgregarPaciente where pid = " + pid + "";
                SqlDataAdapter DA = new SqlDataAdapter();
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridViewDiagnosis.DataSource = DS.Tables[0];
            }
        }
    }
}
