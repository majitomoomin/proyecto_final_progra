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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void labeltitulo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_pacientes_Click(object sender, EventArgs e)
        {
            //para que el > cambie de color cuando se presiona el boton
            labelindicador1.ForeColor = System.Drawing.Color.Red;
            labelindicador2.ForeColor = System.Drawing.Color.Black;
            labelindicador3.ForeColor = System.Drawing.Color.Black;
            labelindicador4.ForeColor = System.Drawing.Color.Black;
            labelindicador5.ForeColor = System.Drawing.Color.Black;

            //mostrar panel de agregar pacientes
            panel1.Visible = true;

        }

        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            labelindicador3.ForeColor = System.Drawing.Color.Red;
            labelindicador2.ForeColor = System.Drawing.Color.Black;
            labelindicador1.ForeColor = System.Drawing.Color.Black;
            labelindicador4.ForeColor = System.Drawing.Color.Black;
            labelindicador5.ForeColor = System.Drawing.Color.Black;
        }

        private void btnHistorial_Med_Click(object sender, EventArgs e)
        {
            labelindicador4.ForeColor = System.Drawing.Color.Red;
            labelindicador2.ForeColor = System.Drawing.Color.Black;
            labelindicador3.ForeColor = System.Drawing.Color.Black;
            labelindicador1.ForeColor = System.Drawing.Color.Black;
            labelindicador5.ForeColor = System.Drawing.Color.Black;
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            labelindicador5.ForeColor = System.Drawing.Color.Red;
            labelindicador2.ForeColor = System.Drawing.Color.Black;
            labelindicador3.ForeColor = System.Drawing.Color.Black;
            labelindicador4.ForeColor = System.Drawing.Color.Black;
            labelindicador1.ForeColor = System.Drawing.Color.Black;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
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
                String Sangre = txtSangre.Text;
                String Enfermedades = txtEnfermedades.Text;
                int pid = Convert.ToInt32(txtIDPaciente.Text);

                //base de datos
                string connectionString = "data source=LAPTOP-GDV6M1II\\SQLEXPRESS;database=clinica;integrated security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                using (SqlConnection con = sqlConnection)
                {
                    string query = "INSERT INTO AgregarPaciente (Nombre, Correo, Contacto, Edad, Sexo, Sangre, Enfermedades, pid) " +
                                   "VALUES (@Nombre, @Correo, @Contacto, @Edad, @Sexo, @Sangre, @Enfermedades, @pid)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", Nombre);
                        cmd.Parameters.AddWithValue("@Correo", Correo);
                        cmd.Parameters.AddWithValue("@Contacto", Contacto);
                        cmd.Parameters.AddWithValue("@Edad", Edad);
                        cmd.Parameters.AddWithValue("@Sexo", Sexo);
                        cmd.Parameters.AddWithValue("@Sangre", Sangre);
                        cmd.Parameters.AddWithValue("@Enfermedades", Enfermedades);
                        cmd.Parameters.AddWithValue("@pid", pid);
                        cmd.CommandText = "insert into AgregarPaciente values ('\"+ Nombre+ \"','\"+ Correo + \"','\"+ Contacto + \"','\" + Edad + \"','\" + Sexo + \"','\" + Sangre + \"','\" + Enfermedades \"','\"+ pid + \"',\")";

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                MessageBox.Show("Paciente agregado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ingresaron datos no válidos o un ID no disponible. Error: " );
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

