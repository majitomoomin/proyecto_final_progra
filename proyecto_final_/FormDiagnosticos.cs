using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
                string Sintomas = txtSintomas.Text;
                string Procedimiento_med = txtProcedimiento.Text;
                string Diagnosis = txtDiagnosis.Text;
                string Alergias = txtAlergias.Text;
                string Medicamentos = txtMedicamentos.Text;

                string cadenaConexion = "Persist Security Info=False;User ID=sa; pwd=12345678;Initial Catalog=hospital;Encrypt=True;TrustServerCertificate=True;Data Source=LAPTOP-GDV6M1II\\SQLEXPRESS";
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO PacientesMas (Sintomas, Procedimiento_med, Diagnosis, Alergias, Medicamentos, pid) VALUES (@Sintomas, @Procedimiento_med, @Diagnosis, @Alergias, @Medicamentos, @pid)", connection))
                    {
                        cmd.Parameters.AddWithValue("@Sintomas", Sintomas);
                        cmd.Parameters.AddWithValue("@Procedimiento_med", Procedimiento_med);
                        cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                        cmd.Parameters.AddWithValue("@Alergias", Alergias);
                        cmd.Parameters.AddWithValue("@Medicamentos", Medicamentos);
                        cmd.Parameters.AddWithValue("@pid", pid);

                        cmd.ExecuteNonQuery();
                    }
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
            catch (Exception)
            {
                MessageBox.Show("No se encontró el registro o algún carácter es incorrecto.");
            }
        }

        private void txtpid_TextChanged(object sender, EventArgs e)
        {
              
            
        }
    }
}
    

