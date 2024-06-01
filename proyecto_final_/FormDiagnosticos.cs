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
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO PacienteMas (Sintomas, Procedimiento_med, Diagnosis, Alergias, Medicamentos, pid) VALUES (@Sintomas, @Procedimiento_med, @Diagnosis, @Alergias, @Medicamentos, @pid)", connection))
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
            catch (Exception ex)
            {
                MessageBox.Show("Error "+  ex.Message);
            }
        }

        private void txtpid_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtpid.Text))
            {
                // Verificar si el texto es un número entero válido
                if (int.TryParse(txtpid.Text, out int pid))
                {
                    string cadenaConexion = "Persist Security Info=False;User ID=sa; pwd=12345678;Initial Catalog=hospital;Encrypt=True;TrustServerCertificate=True;Data Source=LAPTOP-GDV6M1II\\SQLEXPRESS";
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(cadenaConexion))
                        {
                            connection.Open();
                            using (SqlCommand cmd = new SqlCommand("SELECT * FROM AgregarPaciente WHERE pid = @pid", connection))
                            {
                                cmd.Parameters.AddWithValue("@pid", pid);

                                using (SqlDataAdapter DA = new SqlDataAdapter(cmd))
                                {
                                    DataSet DS = new DataSet();
                                    DA.Fill(DS);
                                    dataGridViewDiagnosis.DataSource = DS.Tables[0];
                                }
                            }
                        }
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show($"Error de base de datos: {sqlEx.Message}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un ID de paciente válido.");
                }
            }

        }

        private void btnbuscarpid_Click(object sender, EventArgs e)
        {

        }
    }
}
    

