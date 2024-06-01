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
using System.Configuration;

namespace proyecto_final_.Properties
{
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
            using (SqlConnection con = new SqlConnection("Persist Security Info=False;User ID=sa; pwd=12345678;Initial Catalog=hospital;Encrypt=True;TrustServerCertificate=True;Data Source=LAPTOP-GDV6M1II\\SQLEXPRESS"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from Citas";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dgwCitas.DataSource = dataSet.Tables[0];
            }
        }

        private void Citas_Load(object sender, EventArgs e)
        {

        }
        private void btnGuardarCita_Click(object sender, EventArgs e)
        {
            try
            {
                // Textboxes
                int pid = Convert.ToInt32(txtpid.Text);
                string nombrePaciente = txtNombrePaciente.Text;
                DateTime fechaCita = dtpFechaCita.Value;
                DateTime horaCita = dtpHoraCita.Value;
                string motivoCita = txtMotivoCita.Text;

                // Validar que todos los campos requeridos están completos
                if (string.IsNullOrEmpty(nombrePaciente) || string.IsNullOrEmpty(motivoCita))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                // Base de datos conexión
                string cadenaConexion = "Persist Security Info=False;User ID=sa; pwd=12345678;Initial Catalog=hospital;Encrypt=True;TrustServerCertificate=True;Data Source=LAPTOP-GDV6M1II\\SQLEXPRESS";
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    string query = "INSERT INTO Citas (pid, NombrePaciente, FechaCita, HoraCita, MotivoCita) " +
                                   "VALUES (@pid, @NombrePaciente, @FechaCita, @HoraCita, @MotivoCita)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@pid", pid);
                        cmd.Parameters.AddWithValue("@NombrePaciente", nombrePaciente);
                        cmd.Parameters.AddWithValue("@FechaCita", fechaCita.Date); // Solo la fecha
                        cmd.Parameters.AddWithValue("@HoraCita", horaCita.TimeOfDay); // Solo la hora
                        cmd.Parameters.AddWithValue("@MotivoCita", motivoCita);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                MessageBox.Show("Cita guardada");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ingresaron datos no válidos. Error: " + ex.Message + "\nDetalles: " + ex.StackTrace);
            }

            // Limpiar los campos después de guardar los datos
            txtNombrePaciente.Clear();
            txtpid.Clear();
            dtpFechaCita.Value = DateTime.Now;
            dtpHoraCita.Value = DateTime.Now;
            txtMotivoCita.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgwCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
