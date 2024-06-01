using models;
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
    public partial class NotasClinicas : Form
    {
        string cadenaConexion = "Persist Security Info=False;User ID=sa; pwd=12345678;Initial Catalog=hospital;Encrypt=True;TrustServerCertificate=True;Data Source=LAPTOP-GDV6M1II\\SQLEXPRESS";

        public NotasClinicas()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarNota_Click(object sender, EventArgs e)
        {
            string sintomas = txtSintomas.Text;
            string observaciones = txtObservaciones.Text;
            string diagnosticoProvisional = txtDiagnosticoProv.Text;
            string planTratamiento = txtPlanTra.Text;
            int pid = Convert.ToInt32(txtpid.Text);

            if (!int.TryParse(txtpid.Text, out pid))
            {
                MessageBox.Show("Por favor, ingresa un ID de paciente válido.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    connection.Open();
                    string query = "INSERT INTO NotasClinicas (pid, Sintomas, Observaciones, DiagnosticoProvisional, PlanTratamiento) " +
                                   "VALUES (@pid, @Sintomas, @Observaciones, @DiagnosticoProvisional, @PlanTratamiento)";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@pid", pid);
                        cmd.Parameters.AddWithValue("@Sintomas", sintomas);
                        cmd.Parameters.AddWithValue("@Observaciones", observaciones);
                        cmd.Parameters.AddWithValue("@DiagnosticoProvisional", diagnosticoProvisional);
                        cmd.Parameters.AddWithValue("@PlanTratamiento", planTratamiento);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Nota clínica guardada exitosamente.");

                txtpid.Clear();
                txtSintomas.Clear();
                txtObservaciones.Clear();
                txtDiagnosticoProv.Clear();
                txtPlanTra.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la nota clínica: " + ex.Message);
            }
        }
    }
}
