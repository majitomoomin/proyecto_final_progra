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

namespace proyecto_final_
{
    public partial class Formagreg : Form
    {
        public Formagreg()
        {
            InitializeComponent();
        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                // Captura los datos de los TextBox
                string Nombre = txtNombre.Text;
                string Correo = txtCorreo.Text;
                long Contacto = Convert.ToInt64(txtNoContacto.Text);
                int Edad = Convert.ToInt32(txtEdad.Text);
                string Sexo = ComboSexo.Text;
                string Tipo_Sangre = txtSangre.Text;
                string Enfermedades = txtEnfermedades.Text;
                int pid = Convert.ToInt32(txtIDPaciente.Text);

                // Cadena de conexión

                string cadenaConexion = "Persist Security Info=False;User ID=sa; pwd= 12345678;Initial Catalog=hospital;Encrypt=True;TrustServerCertificate=True;Data Source=LAPTOP-GDV6M1II\\SQLEXPRESS";
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    try
                    {
                        connection.Open();
                        MessageBox.Show("Conexión a la base de datos exitosa.");
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error de conexión: {ex.Message}");
                        return; // Sal de la función si la conexión falla
                    }
                }

                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    // Consulta SQL
                    string query = "INSERT INTO AgregarPaciente (Nombre, Correo, Contact, Edad, Sexo, Tipo_sangre, Enfermedades, pid) " +
                                   "VALUES (@Nombre, @Correo, @Contact, @Edad, @Sexo, @Tipo_sangre, @Enfermedades, @pid)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Agrega los parámetros
                        cmd.Parameters.AddWithValue("@Nombre", Nombre);
                        cmd.Parameters.AddWithValue("@Correo", Correo);
                        cmd.Parameters.AddWithValue("@Contact", Contacto);
                        cmd.Parameters.AddWithValue("@Edad", Edad);
                        cmd.Parameters.AddWithValue("@Sexo", Sexo);
                        cmd.Parameters.AddWithValue("@Tipo_sangre", Tipo_Sangre);
                        cmd.Parameters.AddWithValue("@Enfermedades", Enfermedades);
                        cmd.Parameters.AddWithValue("@pid", pid);

                        // Abre la conexión
                        connection.Open();
                        MessageBox.Show("Conexión abierta.");

                        // Ejecuta la consulta
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Consulta ejecutada.");

                        // Cierra la conexión
                        connection.Close();
                        MessageBox.Show("Conexión cerrada.");
                    }
                }

                // Muestra un mensaje de éxito
                MessageBox.Show("Paciente agregado.");

                // Limpia los campos después de guardar los datos
                txtNombre.Clear();
                txtCorreo.Clear();
                txtNoContacto.Clear();
                txtEdad.Clear();
                ComboSexo.ResetText();
                txtSangre.Clear();
                txtEnfermedades.Clear();
                txtIDPaciente.Clear();
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error detallado
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }



        
    }
    }
    }
