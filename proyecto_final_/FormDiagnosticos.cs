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
    public partial class FormDiagnosticos : Form
    {
        public FormDiagnosticos()
        {
            InitializeComponent();
        }

        private void FormDiagnosticos_Load(object sender, EventArgs e)
        {

        }
        //guardar datos
        private void btnGuardardiagnostico_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(txtpid.Text);
                String Sintomas = txtSintomas.Text;
                String Procedimiento_med = txtProcedimiento.Text;
                String Diagnosis = txtDiagnosis.Text;
                String Alergias = txtAlergias.Text;
                String Medicamentos = txtMedicamentos.Text;

                using (SqlConnection con = new SqlConnection("data source=LAPTOP-GDV6M1II\\SQLEXPRESS;database=clinica;integrated security=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO PacienteMas (Sintomas, Procedimiento_med, Diagnosis, Alergias, Medicamentos, pid) VALUES (@Sintomas, @Procedimiento_med, @Diagnosis, @Alergias, @Medicamentos, @pid)", con))
                    {
                        cmd.Parameters.AddWithValue("@Sintomas", Sintomas);
                        cmd.Parameters.AddWithValue("@Procedimiento_med", Procedimiento_med);
                        cmd.Parameters.AddWithValue("@Diagnosis", Diagnosis);
                        cmd.Parameters.AddWithValue("@Alergias", Alergias);
                        cmd.Parameters.AddWithValue("@Medicamentos", Medicamentos);
                        cmd.Parameters.AddWithValue("@pid", pid);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontro o algún caracter es incorrecto");
            }
            MessageBox.Show("Guardado");

            // Limpia los campos después de guardar los datos
            txtSintomas.Clear();
            txtProcedimiento.Clear();
            txtDiagnosis.Clear();
            txtAlergias.Clear();
            txtMedicamentos.Clear();
            txtpid.Clear();
        }

        //para que al esccribir se busque el pid y lo muestre en el datagrid
        private void txtpid_TextChanged(object sender, EventArgs e)
        {
            if (txtpid.Text != "")
            {
                int pid = Convert.ToInt32(txtpid.Text);

                using (SqlConnection con = new SqlConnection("data source=LAPTOP-GDV6M1II\\SQLEXPRESS;database=clinica;integrated security=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM PacienteMas WHERE pid = @pid", con))
                    {
                        cmd.Parameters.AddWithValue("@pid", pid);

                        SqlDataAdapter DA = new SqlDataAdapter(cmd);
                        DataSet DS = new DataSet();
                        DA.Fill(DS);
                        dataGridViewDiagnosis.DataSource = DS.Tables[0];
                    }
                }
            }
        }
    }
}
