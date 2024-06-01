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
    public partial class Mensajes : Form
    {
        string connectionString = "Persist Security Info=False;User ID=sa; pwd=12345678;Initial Catalog=hospital;Encrypt=True;TrustServerCertificate=True;Data Source=LAPTOP-GDV6M1II\\SQLEXPRESS";
        public Mensajes()
        {
            InitializeComponent();
            CargarMensajes();
        }

        private void Chat_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void CargarMensajes()
        { 
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT Emisor, MensajeTexto, fechaEnvio FROM Mensajes";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Chat.Items.Clear();
                    while (reader.Read())
                    {
                        string emisor = reader["Emisor"].ToString();
                        string mensaje = reader["MensajeTexto"].ToString();
                        DateTime fechaEnvio = (DateTime)reader["fechaEnvio"];

                        Chat.Items.Add($"{fechaEnvio}: {emisor} - {mensaje}");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los mensajes: {ex.Message}");
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string emisor = Form1.UsuarioLogeado; // Obtener el nombre del usuario que inició sesión
            string mensajeTexto = txtMensaje.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Mensajes (Emisor, MensajeTexto) VALUES (@Emisor, @MensajeTexto)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Emisor", emisor);
                cmd.Parameters.AddWithValue("@MensajeTexto", mensajeTexto);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            // Limpiar el campo de texto después de enviar el mensaje
            txtMensaje.Clear();
            MessageBox.Show("Mensaje enviado exitosamente.");
            CargarMensajes(); // Recargar los mensajes después de enviar uno nuevo


        }
    }
}

