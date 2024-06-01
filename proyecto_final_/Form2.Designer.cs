namespace proyecto_final_
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            dataGridViewListado = new DataGridView();
            btnSalir = new Button();
            labelGenero = new Label();
            ComboSexo = new ComboBox();
            panelcampos = new Panel();
            txtSangre = new TextBox();
            labelTipoSangre = new Label();
            txtEdad = new TextBox();
            labelEdad = new Label();
            txtNoContacto = new TextBox();
            labelContactoNum = new Label();
            txtCorreo = new TextBox();
            labelCorreo = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            btnGuardarPaciente = new Button();
            txtIDPaciente = new TextBox();
            label_ID = new Label();
            txtEnfermedades = new TextBox();
            labelEnfermedades = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListado).BeginInit();
            panelcampos.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(199, 26);
            label2.TabIndex = 1;
            label2.Text = "Listado de pacientes";
            // 
            // dataGridViewListado
            // 
            dataGridViewListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListado.Location = new Point(31, 61);
            dataGridViewListado.Margin = new Padding(2);
            dataGridViewListado.Name = "dataGridViewListado";
            dataGridViewListado.RowHeadersWidth = 82;
            dataGridViewListado.Size = new Size(837, 158);
            dataGridViewListado.TabIndex = 2;
            dataGridViewListado.CellContentClick += dataGridViewListado_CellContentClick;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.SkyBlue;
            btnSalir.Location = new Point(329, 13);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(114, 37);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Editar";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(3, 145);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(41, 20);
            labelGenero.TabIndex = 21;
            labelGenero.Text = "Sexo";
            // 
            // ComboSexo
            // 
            ComboSexo.FormattingEnabled = true;
            ComboSexo.Items.AddRange(new object[] { "Femenino", "Masculino" });
            ComboSexo.Location = new Point(50, 142);
            ComboSexo.Name = "ComboSexo";
            ComboSexo.Size = new Size(305, 28);
            ComboSexo.TabIndex = 22;
            // 
            // panelcampos
            // 
            panelcampos.Controls.Add(txtSangre);
            panelcampos.Controls.Add(labelTipoSangre);
            panelcampos.Controls.Add(txtEdad);
            panelcampos.Controls.Add(labelEdad);
            panelcampos.Controls.Add(txtNoContacto);
            panelcampos.Controls.Add(labelContactoNum);
            panelcampos.Controls.Add(txtCorreo);
            panelcampos.Controls.Add(labelCorreo);
            panelcampos.Controls.Add(txtNombre);
            panelcampos.Controls.Add(label1);
            panelcampos.Controls.Add(btnGuardarPaciente);
            panelcampos.Controls.Add(txtIDPaciente);
            panelcampos.Controls.Add(label_ID);
            panelcampos.Controls.Add(txtEnfermedades);
            panelcampos.Controls.Add(labelEnfermedades);
            panelcampos.Controls.Add(labelGenero);
            panelcampos.Controls.Add(ComboSexo);
            panelcampos.Location = new Point(46, 222);
            panelcampos.Margin = new Padding(2, 1, 2, 1);
            panelcampos.Name = "panelcampos";
            panelcampos.Size = new Size(822, 368);
            panelcampos.TabIndex = 25;
            // 
            // txtSangre
            // 
            txtSangre.Location = new Point(473, 147);
            txtSangre.Name = "txtSangre";
            txtSangre.Size = new Size(290, 27);
            txtSangre.TabIndex = 26;
            // 
            // labelTipoSangre
            // 
            labelTipoSangre.AutoSize = true;
            labelTipoSangre.Location = new Point(366, 150);
            labelTipoSangre.Name = "labelTipoSangre";
            labelTipoSangre.Size = new Size(110, 20);
            labelTipoSangre.TabIndex = 26;
            labelTipoSangre.Text = "Tipo de Sangre";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(417, 96);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(346, 27);
            txtEdad.TabIndex = 26;
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(377, 96);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(43, 20);
            labelEdad.TabIndex = 26;
            labelEdad.Text = "Edad";
            // 
            // txtNoContacto
            // 
            txtNoContacto.Location = new Point(153, 89);
            txtNoContacto.Name = "txtNoContacto";
            txtNoContacto.Size = new Size(188, 27);
            txtNoContacto.TabIndex = 29;
            // 
            // labelContactoNum
            // 
            labelContactoNum.AutoSize = true;
            labelContactoNum.Location = new Point(6, 93);
            labelContactoNum.Name = "labelContactoNum";
            labelContactoNum.Size = new Size(146, 20);
            labelContactoNum.TabIndex = 28;
            labelContactoNum.Text = "Número de contacto";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(426, 34);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(357, 27);
            txtCorreo.TabIndex = 26;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(366, 41);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(54, 20);
            labelCorreo.TabIndex = 26;
            labelCorreo.Text = "Correo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(116, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 27);
            txtNombre.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 34);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 26;
            label1.Text = "Nombre";
            // 
            // btnGuardarPaciente
            // 
            btnGuardarPaciente.BackColor = Color.SkyBlue;
            btnGuardarPaciente.Location = new Point(315, 303);
            btnGuardarPaciente.Name = "btnGuardarPaciente";
            btnGuardarPaciente.Size = new Size(94, 29);
            btnGuardarPaciente.TabIndex = 27;
            btnGuardarPaciente.Text = "Guardar";
            btnGuardarPaciente.UseVisualStyleBackColor = false;
            btnGuardarPaciente.Click += btnGuardarPaciente_Click;
            // 
            // txtIDPaciente
            // 
            txtIDPaciente.Location = new Point(157, 248);
            txtIDPaciente.Name = "txtIDPaciente";
            txtIDPaciente.Size = new Size(198, 27);
            txtIDPaciente.TabIndex = 26;
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Location = new Point(46, 251);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(106, 20);
            label_ID.TabIndex = 25;
            label_ID.Text = "ID de paciente";
            // 
            // txtEnfermedades
            // 
            txtEnfermedades.Location = new Point(347, 206);
            txtEnfermedades.Name = "txtEnfermedades";
            txtEnfermedades.Size = new Size(425, 27);
            txtEnfermedades.TabIndex = 24;
            // 
            // labelEnfermedades
            // 
            labelEnfermedades.AutoSize = true;
            labelEnfermedades.Location = new Point(3, 206);
            labelEnfermedades.Name = "labelEnfermedades";
            labelEnfermedades.Size = new Size(338, 20);
            labelEnfermedades.TabIndex = 23;
            labelEnfermedades.Text = "Enfermedad importante que se sufra/haya sufrido";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnSalir);
            Controls.Add(dataGridViewListado);
            Controls.Add(label2);
            Controls.Add(panelcampos);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Listado de pacientes";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListado).EndInit();
            panelcampos.ResumeLayout(false);
            panelcampos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridViewListado;
        private Button btnSalir;
        private Label labelGenero;
        private ComboBox ComboSexo;
        private Panel panelcampos;
        private Label labelEnfermedades;
        private TextBox txtEnfermedades;
        private Label label_ID;
        private TextBox txtIDPaciente;
        private Button btnGuardarPaciente;
        private TextBox txtNoContacto;
        private Label labelContactoNum;
        private TextBox txtCorreo;
        private Label labelCorreo;
        private TextBox txtNombre;
        private Label label1;
        private TextBox txtEdad;
        private Label labelEdad;
        private TextBox txtSangre;
        private Label labelTipoSangre;
    }
}