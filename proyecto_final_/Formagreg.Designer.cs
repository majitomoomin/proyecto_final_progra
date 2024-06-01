namespace proyecto_final_
{
    partial class Formagreg
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
            labelcontrol = new Label();
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
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelcontrol
            // 
            labelcontrol.AutoSize = true;
            labelcontrol.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelcontrol.Location = new Point(393, 284);
            labelcontrol.Name = "labelcontrol";
            labelcontrol.Size = new Size(0, 25);
            labelcontrol.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
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
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(823, 592);
            panel1.TabIndex = 16;
            // 
            // btnGuardarPaciente
            // 
            btnGuardarPaciente.BackColor = Color.SkyBlue;
            btnGuardarPaciente.Location = new Point(144, 488);
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
            // button1
            // 
            button1.BackColor = Color.Pink;
            button1.Location = new Point(374, 488);
            button1.Name = "button1";
            button1.Size = new Size(176, 29);
            button1.TabIndex = 18;
            button1.Text = "Ver listado de pacientes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Formagreg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 592);
            Controls.Add(panel1);
            Controls.Add(labelcontrol);
            Name = "Formagreg";
            Text = "Agregar Pacientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelcontrol;
        private Panel panel1;
        private Button btnGuardarPaciente;
        private TextBox txtIDPaciente;
        private Label label_ID;
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
        private ComboBox ComboSexo;
        private Button button1;
    }
}