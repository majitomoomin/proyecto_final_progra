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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            panelcampos.Visible = false;
            LoadData();

        }
        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection("Persist Security Info=False;User ID=sa; pwd=12345678;Initial Catalog=hospital;Encrypt=True;TrustServerCertificate=True;Data Source=LAPTOP-GDV6M1II\\SQLEXPRESS"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM AgregarPaciente";
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridViewListado.DataSource = dataSet.Tables[0];
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        //boton editar campos de pacientes 
        private void btnSalir_Click(object sender, EventArgs e)
        {
            panelcampos.Visible = true;
        }

        //boton para eliminar campos de pacientes
        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                string cadenaConexion = "Persist Security Info=False;User ID=sa; pwd=12345678;Initial Catalog=hospital;Encrypt=True;TrustServerCertificate=True;Data Source=LAPTOP-GDV6M1II\\SQLEXPRESS";
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    string query = "UPDATE AgregarPaciente SET Nombre=@Nombre, Correo=@Correo, Contact=@Contact, Edad=@Edad, Sexo=@Sexo, Tipo_sangre=@Tipo_sangre, Enfermedades=@Enfermedades WHERE pid=@pid";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);
                        cmd.Parameters.AddWithValue("@Contact", txtNoContacto.Text);
                        cmd.Parameters.AddWithValue("@Edad", txtEdad.Text);
                        cmd.Parameters.AddWithValue("@Sexo", ComboSexo.Text);
                        cmd.Parameters.AddWithValue("@Tipo_sangre", txtSangre.Text);
                        cmd.Parameters.AddWithValue("@Enfermedades", txtEnfermedades.Text);
                        cmd.Parameters.AddWithValue("@pid", txtIDPaciente.Text);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                MessageBox.Show("Paciente actualizado.");
                LoadData();
                panelcampos.Visible = false; // Ocultar panel después de guardar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}");
            }
        }

        private void dataGridViewListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
