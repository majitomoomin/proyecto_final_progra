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

        }

        private void FormHistorial_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewListado.Rows[e.RowIndex];
                txtIDPaciente.Text = row.Cells["pid"].Value.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value.ToString();
                txtCorreo.Text = row.Cells["Correo"].Value.ToString();
                txtNoContacto.Text = row.Cells["Contact"].Value.ToString();
                txtEdad.Text = row.Cells["Edad"].Value.ToString();
                ComboSexo.Text = row.Cells["Sexo"].Value.ToString();
                txtSangre.Text = row.Cells["Tipo_sangre"].Value.ToString();
                txtEnfermedades.Text = row.Cells["Enfermedades"].Value.ToString();
            }
        }

        private void btnMostrarHistorial_Click(object sender, EventArgs e)
        {
            try
            {
                // Cadena de conexión
                string cadenaConexion = "Persist Security Info=False;User ID=sa; pwd=12345678;Initial Catalog=hospital;Encrypt=True;TrustServerCertificate=True;Data Source=LAPTOP-GDV6M1II\\SQLEXPRESS";

                // Abrir la conexión usando la cadena de conexión
                using (SqlConnection con = new SqlConnection(cadenaConexion))
                {
                    con.Open();

                    // selecciona datos de ambas tablas relacionadas por pid
                    string consulta = "SELECT * FROM AgregarPaciente INNER JOIN PacienteMas ON AgregarPaciente.pid = PacienteMas.pid";

                    // Crear comando SQL usando la conexión abierta
                    using (SqlCommand cmd = new SqlCommand(consulta, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet);
                        if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
                        {
                            dataGridViewHistorial.DataSource = dataSet.Tables[0];
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron registros.");
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
    }
}

