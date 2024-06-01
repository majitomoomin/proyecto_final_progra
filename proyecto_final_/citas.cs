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
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection("Persist Security Info=False;User ID=sa; pwd=12345678;Initial Catalog=hospital;Encrypt=True;TrustServerCertificate=True;Data Source=LAPTOP-GDV6M1II\\SQLEXPRESS"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM Citas";
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
                int pid = Convert.ToInt32(txtpid.Text);
                string nombrePaciente = txtNombrePaciente.Text;
                DateTime fechaCita = dtpFechaCita.Value;
                DateTime horaCita = dtpHoraCita.Value;
                string motivoCita = txtMotivoCita.Text;

                if (string.IsNullOrEmpty(nombrePaciente) || string.IsNullOrEmpty(motivoCita))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                string cadenaConexion = "Persist Security Info=False;User ID=sa; pwd=12345678;Initial Catalog=hospital;Encrypt=True;TrustServerCertificate=True;Data Source=LAPTOP-GDV6M1II\\SQLEXPRESS";
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    string query;

                    if (string.IsNullOrEmpty(txtpid.Text) || txtpid.Text == "0")
                    {
                        query = "INSERT INTO Citas (NombrePaciente, FechaCita, HoraCita, MotivoCita) VALUES (@NombrePaciente, @FechaCita, @HoraCita, @MotivoCita)";
                    }
                    else
                    {
                        query = "UPDATE Citas SET NombrePaciente=@NombrePaciente, FechaCita=@FechaCita, HoraCita=@HoraCita, MotivoCita=@MotivoCita WHERE pid=@pid";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        if (query.Contains("UPDATE"))
                        {
                            cmd.Parameters.AddWithValue("@pid", pid);
                        }

                        cmd.Parameters.AddWithValue("@NombrePaciente", nombrePaciente);
                        cmd.Parameters.AddWithValue("@FechaCita", fechaCita.Date);
                        cmd.Parameters.AddWithValue("@HoraCita", horaCita.TimeOfDay);
                        cmd.Parameters.AddWithValue("@MotivoCita", motivoCita);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                MessageBox.Show("Cita guardada.");
                LoadData();

                // Limpiar los campos después de guardar los datos
                txtpid.Clear();
                txtNombrePaciente.Clear();
                dtpFechaCita.Value = DateTime.Now;
                dtpHoraCita.Value = DateTime.Now;
                txtMotivoCita.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ingresaron datos no válidos. Error: " + ex.Message + "\nDetalles: " + ex.StackTrace);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgwCitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgwCitas.Rows[e.RowIndex];
                txtpid.Text = row.Cells["pid"].Value.ToString();
                txtNombrePaciente.Text = row.Cells["NombrePaciente"].Value.ToString();
                dtpFechaCita.Value = Convert.ToDateTime(row.Cells["FechaCita"].Value);
                dtpHoraCita.Value = DateTime.Today.Add(Convert.ToDateTime(row.Cells["HoraCita"].Value).TimeOfDay);
                txtMotivoCita.Text = row.Cells["MotivoCita"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
