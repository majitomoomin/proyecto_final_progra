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
                //textboxs
                String Nombre = txtNombre.Text;
                String Correo = txtCorreo.Text;
                long Contacto = Convert.ToInt64(txtNoContacto);
                int Edad = Convert.ToInt32(txtEdad.Text);
                String Sexo = ComboSexo.Text;
                String Tipo_Sangre = txtSangre.Text;
                String Enfermedades = txtEnfermedades.Text;
                int pid = Convert.ToInt32(txtIDPaciente.Text);

                //base de datos
                string connectionString = "data source=LAPTOP-GDV6M1II\\SQLEXPRESS;database=clinica;integrated security=True";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO AgregarPaciente (Nombre, Correo, Contact, Edad, Sexo, Tipo_sangre, Enfermedades, pid) " +
                                   "VALUES (@Nombre, @Correo, @Contact, @Edad, @Sexo, @Tipo_sangre, @Enfermedades, @pid)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", Nombre);
                        cmd.Parameters.AddWithValue("@Correo", Correo);
                        cmd.Parameters.AddWithValue("@Contact", Contacto);
                        cmd.Parameters.AddWithValue("@Edad", Edad);
                        cmd.Parameters.AddWithValue("@Sexo", Sexo);
                        cmd.Parameters.AddWithValue("@Tipo_sangre", Tipo_Sangre);
                        cmd.Parameters.AddWithValue("@Enfermedades", Enfermedades);
                        cmd.Parameters.AddWithValue("@pid", pid);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }

                MessageBox.Show("Paciente agregado.");
            }
            catch (Exception)
            {
                MessageBox.Show("Se ingresaron datos no válidos o un ID no disponible. Error: ");
            }

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
    }
    }
