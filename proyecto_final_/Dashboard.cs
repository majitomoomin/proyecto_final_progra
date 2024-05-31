using proyecto_final_.Properties;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;

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

            //mostrar ventana agregar pacientes 
            panel1.Visible = true;
            Formagreg formagreg = new Formagreg();

            formagreg.TopLevel = false; 
            formagreg.FormBorderStyle = FormBorderStyle.None; 
            formagreg.Dock = DockStyle.Fill; 
            panel1.Controls.Clear();
            panel1.Controls.Add(formagreg); 
            formagreg.Show(); 


        }

        private void btnDiagnostico_Click(object sender, EventArgs e)
        {
            labelindicador3.ForeColor = System.Drawing.Color.Red;
            labelindicador2.ForeColor = System.Drawing.Color.Black;
            labelindicador1.ForeColor = System.Drawing.Color.Black;
            labelindicador4.ForeColor = System.Drawing.Color.Black;
            labelindicador5.ForeColor = System.Drawing.Color.Black;

            //mostrar ventana diagnosticos 
            panel1.Visible = true;
            FormDiagnosticos formDiagnosticos = new FormDiagnosticos();

            formDiagnosticos.TopLevel = false;
            formDiagnosticos.FormBorderStyle = FormBorderStyle.None;
            formDiagnosticos.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(formDiagnosticos);
            formDiagnosticos.Show();
        }

        private void btnHistorial_Med_Click(object sender, EventArgs e)
        {
            labelindicador4.ForeColor = System.Drawing.Color.Red;
            labelindicador2.ForeColor = System.Drawing.Color.Black;
            labelindicador3.ForeColor = System.Drawing.Color.Black;
            labelindicador1.ForeColor = System.Drawing.Color.Black;
            labelindicador5.ForeColor = System.Drawing.Color.Black;
            panel1.Visible = true;

            FormHistorial formhistorial = new FormHistorial();

            formhistorial.TopLevel = false;
            formhistorial.FormBorderStyle = FormBorderStyle.None;
            formhistorial.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(formhistorial);
            formhistorial.Show();
            
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            labelindicador5.ForeColor = System.Drawing.Color.Red;
            labelindicador2.ForeColor = System.Drawing.Color.Black;
            labelindicador3.ForeColor = System.Drawing.Color.Black;
            labelindicador4.ForeColor = System.Drawing.Color.Black;
            labelindicador1.ForeColor = System.Drawing.Color.Black;

            panel1.Visible = true;

            FormInfoHospital forminfohospital = new FormInfoHospital();

            forminfohospital.TopLevel = false;
            forminfohospital.FormBorderStyle = FormBorderStyle.None;
            forminfohospital.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(forminfohospital);
            forminfohospital.Show();

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
            
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            labelindicador2.ForeColor = System.Drawing.Color.Red;
            labelindicador1.ForeColor = System.Drawing.Color.Black;
            labelindicador3.ForeColor = System.Drawing.Color.Black;
            labelindicador4.ForeColor = System.Drawing.Color.Black;
            labelindicador5.ForeColor = System.Drawing.Color.Black;

            //mostrar ventana agregar citas
            panel1.Visible = true;
            Citas citas = new Citas();

            citas.TopLevel = false;
            citas.FormBorderStyle = FormBorderStyle.None;
            citas.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(citas);
            citas.Show();
        }
    }
}

