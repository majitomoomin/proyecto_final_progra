namespace proyecto_final_
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            labeltitulo = new Label();
            btnAgregar_pacientes = new Button();
            btnDiagnostico = new Button();
            btnHistorial_Med = new Button();
            btnInfo = new Button();
            labelcontrol = new Label();
            btnCitas = new Button();
            pictureBox1 = new PictureBox();
            btnSalir = new Button();
            pictureBox2 = new PictureBox();
            labelindicador1 = new Label();
            labelindicador2 = new Label();
            labelindicador3 = new Label();
            labelindicador4 = new Label();
            labelindicador5 = new Label();
            panel1 = new Panel();
            btnGuardarPaciente = new Button();
            txtIDPaciente = new TextBox();
            label_ID = new Label();
            txtCorreo = new TextBox();
            txtNoContacto = new TextBox();
            txtSangre = new TextBox();
            txtEnfermedades = new TextBox();
            txtEdad = new TextBox();
            labelTipoSangre = new Label();
            labelGenero = new Label();
            labelEdad = new Label();
            labelEnfermedades = new Label();
            labelContactoNum = new Label();
            labelCorreo = new Label();
            txtNombre = new TextBox();
            labelNombre = new Label();
            ComboSexo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltitulo.Location = new Point(369, 9);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(419, 38);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "Clínica Médica Dr. Gonzalo";
            labeltitulo.Click += labeltitulo_Click;
            // 
            // btnAgregar_pacientes
            // 
            btnAgregar_pacientes.BackColor = Color.SkyBlue;
            btnAgregar_pacientes.Location = new Point(34, 108);
            btnAgregar_pacientes.Name = "btnAgregar_pacientes";
            btnAgregar_pacientes.Size = new Size(194, 29);
            btnAgregar_pacientes.TabIndex = 1;
            btnAgregar_pacientes.Text = "Agregar nuevo paciente";
            btnAgregar_pacientes.UseVisualStyleBackColor = false;
            btnAgregar_pacientes.Click += btnAgregar_pacientes_Click;
            // 
            // btnDiagnostico
            // 
            btnDiagnostico.BackColor = Color.SkyBlue;
            btnDiagnostico.Location = new Point(34, 243);
            btnDiagnostico.Name = "btnDiagnostico";
            btnDiagnostico.Size = new Size(194, 51);
            btnDiagnostico.TabIndex = 2;
            btnDiagnostico.Text = "Agregar información de diagnostico";
            btnDiagnostico.UseVisualStyleBackColor = false;
            btnDiagnostico.Click += btnDiagnostico_Click;
            // 
            // btnHistorial_Med
            // 
            btnHistorial_Med.BackColor = Color.SkyBlue;
            btnHistorial_Med.Location = new Point(34, 327);
            btnHistorial_Med.Name = "btnHistorial_Med";
            btnHistorial_Med.Size = new Size(194, 29);
            btnHistorial_Med.TabIndex = 3;
            btnHistorial_Med.Text = "Historial Medico";
            btnHistorial_Med.UseVisualStyleBackColor = false;
            btnHistorial_Med.Click += btnHistorial_Med_Click;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.SkyBlue;
            btnInfo.Location = new Point(34, 392);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(194, 29);
            btnInfo.TabIndex = 4;
            btnInfo.Text = "Información del hospital";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // labelcontrol
            // 
            labelcontrol.AutoSize = true;
            labelcontrol.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelcontrol.Location = new Point(68, 70);
            labelcontrol.Name = "labelcontrol";
            labelcontrol.Size = new Size(109, 25);
            labelcontrol.TabIndex = 5;
            labelcontrol.Text = "Controles";
            // 
            // btnCitas
            // 
            btnCitas.BackColor = Color.SkyBlue;
            btnCitas.Location = new Point(34, 175);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(194, 29);
            btnCitas.TabIndex = 6;
            btnCitas.Text = "Agregar nueva cita";
            btnCitas.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(234, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(715, 519);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightCoral;
            btnSalir.Location = new Point(63, 440);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(114, 29);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(6, 475);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(222, 104);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // labelindicador1
            // 
            labelindicador1.AutoSize = true;
            labelindicador1.BackColor = Color.White;
            labelindicador1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelindicador1.Location = new Point(12, 110);
            labelindicador1.Name = "labelindicador1";
            labelindicador1.Size = new Size(21, 23);
            labelindicador1.TabIndex = 10;
            labelindicador1.Text = ">";
            // 
            // labelindicador2
            // 
            labelindicador2.AutoSize = true;
            labelindicador2.BackColor = Color.White;
            labelindicador2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelindicador2.Location = new Point(12, 177);
            labelindicador2.Name = "labelindicador2";
            labelindicador2.Size = new Size(21, 23);
            labelindicador2.TabIndex = 11;
            labelindicador2.Text = ">";
            // 
            // labelindicador3
            // 
            labelindicador3.AutoSize = true;
            labelindicador3.BackColor = Color.White;
            labelindicador3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelindicador3.Location = new Point(12, 256);
            labelindicador3.Name = "labelindicador3";
            labelindicador3.Size = new Size(21, 23);
            labelindicador3.TabIndex = 12;
            labelindicador3.Text = ">";
            labelindicador3.Click += label3_Click;
            // 
            // labelindicador4
            // 
            labelindicador4.AutoSize = true;
            labelindicador4.BackColor = Color.White;
            labelindicador4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelindicador4.Location = new Point(12, 333);
            labelindicador4.Name = "labelindicador4";
            labelindicador4.Size = new Size(21, 23);
            labelindicador4.TabIndex = 13;
            labelindicador4.Text = ">";
            // 
            // labelindicador5
            // 
            labelindicador5.AutoSize = true;
            labelindicador5.BackColor = Color.White;
            labelindicador5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelindicador5.Location = new Point(12, 392);
            labelindicador5.Name = "labelindicador5";
            labelindicador5.Size = new Size(21, 23);
            labelindicador5.TabIndex = 14;
            labelindicador5.Text = ">";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGuardarPaciente);
            panel1.Controls.Add(txtIDPaciente);
            panel1.Controls.Add(label_ID);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtNoContacto);
            panel1.Controls.Add(txtSangre);
            panel1.Controls.Add(txtEnfermedades);
            panel1.Controls.Add(txtEdad);
            panel1.Controls.Add(labelTipoSangre);
            panel1.Controls.Add(labelGenero);
            panel1.Controls.Add(labelEdad);
            panel1.Controls.Add(labelEnfermedades);
            panel1.Controls.Add(labelContactoNum);
            panel1.Controls.Add(labelCorreo);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(labelNombre);
            panel1.Controls.Add(ComboSexo);
            panel1.Location = new Point(234, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(715, 519);
            panel1.TabIndex = 15;
            // 
            // btnGuardarPaciente
            // 
            btnGuardarPaciente.BackColor = Color.SkyBlue;
            btnGuardarPaciente.Location = new Point(585, 470);
            btnGuardarPaciente.Name = "btnGuardarPaciente";
            btnGuardarPaciente.Size = new Size(94, 29);
            btnGuardarPaciente.TabIndex = 17;
            btnGuardarPaciente.Text = "Guardar";
            btnGuardarPaciente.UseVisualStyleBackColor = false;
            btnGuardarPaciente.Click += btnGuardarPaciente_Click;
            // 
            // txtIDPaciente
            // 
            txtIDPaciente.Location = new Point(153, 421);
            txtIDPaciente.Name = "txtIDPaciente";
            txtIDPaciente.Size = new Size(198, 27);
            txtIDPaciente.TabIndex = 16;
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Location = new Point(27, 424);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(106, 20);
            label_ID.TabIndex = 15;
            label_ID.Text = "ID de paciente";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(125, 92);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(556, 27);
            txtCorreo.TabIndex = 14;
            // 
            // txtNoContacto
            // 
            txtNoContacto.Location = new Point(194, 140);
            txtNoContacto.Name = "txtNoContacto";
            txtNoContacto.Size = new Size(487, 27);
            txtNoContacto.TabIndex = 13;
            // 
            // txtSangre
            // 
            txtSangre.Location = new Point(153, 286);
            txtSangre.Name = "txtSangre";
            txtSangre.Size = new Size(528, 27);
            txtSangre.TabIndex = 12;
            // 
            // txtEnfermedades
            // 
            txtEnfermedades.Location = new Point(8, 364);
            txtEnfermedades.Name = "txtEnfermedades";
            txtEnfermedades.Size = new Size(673, 27);
            txtEnfermedades.TabIndex = 11;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(125, 195);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(556, 27);
            txtEdad.TabIndex = 9;
            // 
            // labelTipoSangre
            // 
            labelTipoSangre.AutoSize = true;
            labelTipoSangre.Location = new Point(45, 293);
            labelTipoSangre.Name = "labelTipoSangre";
            labelTipoSangre.Size = new Size(110, 20);
            labelTipoSangre.TabIndex = 8;
            labelTipoSangre.Text = "Tipo de Sangre";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Location = new Point(62, 236);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(41, 20);
            labelGenero.TabIndex = 7;
            labelGenero.Text = "Sexo";
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(76, 198);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(43, 20);
            labelEdad.TabIndex = 6;
            labelEdad.Text = "Edad";
            // 
            // labelEnfermedades
            // 
            labelEnfermedades.AutoSize = true;
            labelEnfermedades.Location = new Point(3, 341);
            labelEnfermedades.Name = "labelEnfermedades";
            labelEnfermedades.Size = new Size(338, 20);
            labelEnfermedades.TabIndex = 5;
            labelEnfermedades.Text = "Enfermedad importante que se sufra/haya sufrido";
            // 
            // labelContactoNum
            // 
            labelContactoNum.AutoSize = true;
            labelContactoNum.Location = new Point(42, 147);
            labelContactoNum.Name = "labelContactoNum";
            labelContactoNum.Size = new Size(146, 20);
            labelContactoNum.TabIndex = 4;
            labelContactoNum.Text = "Número de contacto";
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(65, 92);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(54, 20);
            labelCorreo.TabIndex = 3;
            labelCorreo.Text = "Correo";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(125, 46);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(556, 27);
            txtNombre.TabIndex = 2;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(55, 52);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(64, 20);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre";
            // 
            // ComboSexo
            // 
            ComboSexo.FormattingEnabled = true;
            ComboSexo.Items.AddRange(new object[] { "Femenino", "Masculino" });
            ComboSexo.Location = new Point(125, 233);
            ComboSexo.Name = "ComboSexo";
            ComboSexo.Size = new Size(556, 28);
            ComboSexo.TabIndex = 0;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(979, 614);
            Controls.Add(panel1);
            Controls.Add(labelindicador5);
            Controls.Add(labelindicador4);
            Controls.Add(labelindicador3);
            Controls.Add(labelindicador2);
            Controls.Add(labelindicador1);
            Controls.Add(pictureBox2);
            Controls.Add(btnSalir);
            Controls.Add(pictureBox1);
            Controls.Add(btnCitas);
            Controls.Add(labelcontrol);
            Controls.Add(btnInfo);
            Controls.Add(btnHistorial_Med);
            Controls.Add(btnDiagnostico);
            Controls.Add(btnAgregar_pacientes);
            Controls.Add(labeltitulo);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labeltitulo;
        private Button btnAgregar_pacientes;
        private Button btnDiagnostico;
        private Button btnHistorial_Med;
        private Button btnInfo;
        private Label labelcontrol;
        private Button btnCitas;
        private PictureBox pictureBox1;
        private Button btnSalir;
        private PictureBox pictureBox2;
        private Label labelindicador1;
        private Label labelindicador2;
        private Label labelindicador3;
        private Label labelindicador4;
        private Label labelindicador5;
        private Panel panel1;
        private ComboBox ComboSexo;
        private TextBox txtCorreo;
        private TextBox txtNoContacto;
        private TextBox txtSangre;
        private TextBox txtEnfermedades;
        private TextBox txtEdad;
        private Label labelTipoSangre;
        private Label labelGenero;
        private Label labelEdad;
        private Label labelEnfermedades;
        private Label labelContactoNum;
        private Label labelCorreo;
        private TextBox txtNombre;
        private Label labelNombre;
        private Label label_ID;
        private Button btnGuardarPaciente;
        private TextBox txtIDPaciente;
    }
}