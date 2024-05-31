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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltitulo.Location = new Point(600, 14);
            labeltitulo.Margin = new Padding(5, 0, 5, 0);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(653, 61);
            labeltitulo.TabIndex = 0;
            labeltitulo.Text = "Clínica Médica Dr. Gonzalo";
            labeltitulo.Click += labeltitulo_Click;
            // 
            // btnAgregar_pacientes
            // 
            btnAgregar_pacientes.BackColor = Color.SkyBlue;
            btnAgregar_pacientes.Location = new Point(55, 173);
            btnAgregar_pacientes.Margin = new Padding(5);
            btnAgregar_pacientes.Name = "btnAgregar_pacientes";
            btnAgregar_pacientes.Size = new Size(315, 46);
            btnAgregar_pacientes.TabIndex = 1;
            btnAgregar_pacientes.Text = "Agregar nuevo paciente";
            btnAgregar_pacientes.UseVisualStyleBackColor = false;
            btnAgregar_pacientes.Click += btnAgregar_pacientes_Click;
            // 
            // btnDiagnostico
            // 
            btnDiagnostico.BackColor = Color.SkyBlue;
            btnDiagnostico.Location = new Point(55, 389);
            btnDiagnostico.Margin = new Padding(5);
            btnDiagnostico.Name = "btnDiagnostico";
            btnDiagnostico.Size = new Size(315, 82);
            btnDiagnostico.TabIndex = 2;
            btnDiagnostico.Text = "Agregar información de diagnostico";
            btnDiagnostico.UseVisualStyleBackColor = false;
            btnDiagnostico.Click += btnDiagnostico_Click;
            // 
            // btnHistorial_Med
            // 
            btnHistorial_Med.BackColor = Color.SkyBlue;
            btnHistorial_Med.Location = new Point(55, 523);
            btnHistorial_Med.Margin = new Padding(5);
            btnHistorial_Med.Name = "btnHistorial_Med";
            btnHistorial_Med.Size = new Size(315, 46);
            btnHistorial_Med.TabIndex = 3;
            btnHistorial_Med.Text = "Historial Medico";
            btnHistorial_Med.UseVisualStyleBackColor = false;
            btnHistorial_Med.Click += btnHistorial_Med_Click;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.SkyBlue;
            btnInfo.Location = new Point(55, 627);
            btnInfo.Margin = new Padding(5);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(315, 46);
            btnInfo.TabIndex = 4;
            btnInfo.Text = "Información del hospital";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // labelcontrol
            // 
            labelcontrol.AutoSize = true;
            labelcontrol.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelcontrol.Location = new Point(110, 112);
            labelcontrol.Margin = new Padding(5, 0, 5, 0);
            labelcontrol.Name = "labelcontrol";
            labelcontrol.Size = new Size(169, 42);
            labelcontrol.TabIndex = 5;
            labelcontrol.Text = "Controles";
            // 
            // btnCitas
            // 
            btnCitas.BackColor = Color.SkyBlue;
            btnCitas.Location = new Point(55, 280);
            btnCitas.Margin = new Padding(5);
            btnCitas.Name = "btnCitas";
            btnCitas.Size = new Size(315, 46);
            btnCitas.TabIndex = 6;
            btnCitas.Text = "Agregar nueva cita";
            btnCitas.UseVisualStyleBackColor = false;
            btnCitas.Click += btnCitas_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(380, 96);
            pictureBox1.Margin = new Padding(5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1373, 875);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.LightCoral;
            btnSalir.Location = new Point(102, 704);
            btnSalir.Margin = new Padding(5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(185, 46);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(10, 760);
            pictureBox2.Margin = new Padding(5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(361, 166);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // labelindicador1
            // 
            labelindicador1.AutoSize = true;
            labelindicador1.BackColor = Color.White;
            labelindicador1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelindicador1.Location = new Point(20, 176);
            labelindicador1.Margin = new Padding(5, 0, 5, 0);
            labelindicador1.Name = "labelindicador1";
            labelindicador1.Size = new Size(33, 36);
            labelindicador1.TabIndex = 10;
            labelindicador1.Text = ">";
            // 
            // labelindicador2
            // 
            labelindicador2.AutoSize = true;
            labelindicador2.BackColor = Color.White;
            labelindicador2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelindicador2.Location = new Point(20, 283);
            labelindicador2.Margin = new Padding(5, 0, 5, 0);
            labelindicador2.Name = "labelindicador2";
            labelindicador2.Size = new Size(33, 36);
            labelindicador2.TabIndex = 11;
            labelindicador2.Text = ">";
            // 
            // labelindicador3
            // 
            labelindicador3.AutoSize = true;
            labelindicador3.BackColor = Color.White;
            labelindicador3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelindicador3.Location = new Point(20, 410);
            labelindicador3.Margin = new Padding(5, 0, 5, 0);
            labelindicador3.Name = "labelindicador3";
            labelindicador3.Size = new Size(33, 36);
            labelindicador3.TabIndex = 12;
            labelindicador3.Text = ">";
            labelindicador3.Click += label3_Click;
            // 
            // labelindicador4
            // 
            labelindicador4.AutoSize = true;
            labelindicador4.BackColor = Color.White;
            labelindicador4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelindicador4.Location = new Point(20, 533);
            labelindicador4.Margin = new Padding(5, 0, 5, 0);
            labelindicador4.Name = "labelindicador4";
            labelindicador4.Size = new Size(33, 36);
            labelindicador4.TabIndex = 13;
            labelindicador4.Text = ">";
            // 
            // labelindicador5
            // 
            labelindicador5.AutoSize = true;
            labelindicador5.BackColor = Color.White;
            labelindicador5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelindicador5.Location = new Point(20, 627);
            labelindicador5.Margin = new Padding(5, 0, 5, 0);
            labelindicador5.Name = "labelindicador5";
            labelindicador5.Size = new Size(33, 36);
            labelindicador5.TabIndex = 14;
            labelindicador5.Text = ">";
            // 
            // panel1
            // 
            panel1.Location = new Point(380, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(1383, 875);
            panel1.TabIndex = 15;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(2117, 1078);
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
            Margin = new Padding(5);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
    }
}