using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            labelindicador1.ForeColor = System.Drawing.Color.Red;
            labelindicador2.ForeColor = System.Drawing.Color.Black;
            labelindicador3.ForeColor = System.Drawing.Color.Black;
            labelindicador4.ForeColor = System.Drawing.Color.Black;
            labelindicador5.ForeColor = System.Drawing.Color.Black;

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
    }
}
