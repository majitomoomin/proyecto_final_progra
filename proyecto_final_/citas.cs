﻿using System;
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
        }

        private void Citas_Load(object sender, EventArgs e)
        {

        }
        private void btnGuardarCita_Click(object sender, EventArgs e)
        {
            try
            {
                //textboxs
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

                //base de datos
                string connectionString = "data source=LAPTOP-GDV6M1II\\SQLEXPRESS;database=clinica;integrated security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Citas (NombrePaciente, FechaCita, HoraCita, MotivoCita) " +
                                   "VALUES (@NombrePaciente, @FechaCita, @HoraCita, @MotivoCita)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@NombrePaciente", nombrePaciente);
                        cmd.Parameters.AddWithValue("@FechaCita", fechaCita);
                        cmd.Parameters.AddWithValue("@HoraCita", horaCita);
                        cmd.Parameters.AddWithValue("@MotivoCita", motivoCita);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                }

                MessageBox.Show("Cita guardada");
            }
            catch (Exception)
            {
                MessageBox.Show("Se ingresaron datos no válidos. Error: ");
            }

            // Limpia los campos después de guardar los datos
            txtNombrePaciente.Clear();
            dtpFechaCita.Value = DateTime.Now;
            dtpHoraCita.Value = DateTime.Now;
            txtMotivoCita.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}