namespace proyecto_final_.Properties
{
    partial class Citas
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
            lblNombrePaciente = new Label();
            lblFechaCita = new Label();
            txtNombrePaciente = new TextBox();
            txtMotivoCita = new TextBox();
            dtpFechaCita = new DateTimePicker();
            lblHoraCita = new Label();
            dtpHoraCita = new DateTimePicker();
            lblMotivoCita = new Label();
            btnGuardarCita = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblNombrePaciente
            // 
            lblNombrePaciente.AutoSize = true;
            lblNombrePaciente.Location = new Point(42, 42);
            lblNombrePaciente.Name = "lblNombrePaciente";
            lblNombrePaciente.Size = new Size(118, 15);
            lblNombrePaciente.TabIndex = 0;
            lblNombrePaciente.Text = "Nombre del Paciente";
            // 
            // lblFechaCita
            // 
            lblFechaCita.AutoSize = true;
            lblFechaCita.Location = new Point(70, 93);
            lblFechaCita.Name = "lblFechaCita";
            lblFechaCita.Size = new Size(90, 15);
            lblFechaCita.TabIndex = 1;
            lblFechaCita.Text = "Fecha de la Cita";
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.Location = new Point(197, 39);
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.Size = new Size(387, 23);
            txtNombrePaciente.TabIndex = 2;
            // 
            // txtMotivoCita
            // 
            txtMotivoCita.Location = new Point(197, 195);
            txtMotivoCita.Name = "txtMotivoCita";
            txtMotivoCita.Size = new Size(387, 23);
            txtMotivoCita.TabIndex = 3;
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Location = new Point(197, 87);
            dtpFechaCita.MinDate = new DateTime(2024, 5, 29, 0, 0, 0, 0);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(229, 23);
            dtpFechaCita.TabIndex = 4;
            dtpFechaCita.Value = new DateTime(2024, 6, 1, 0, 0, 0, 0);
            // 
            // lblHoraCita
            // 
            lblHoraCita.AutoSize = true;
            lblHoraCita.Location = new Point(75, 148);
            lblHoraCita.Name = "lblHoraCita";
            lblHoraCita.Size = new Size(85, 15);
            lblHoraCita.TabIndex = 5;
            lblHoraCita.Text = "Hora de la Cita";
            // 
            // dtpHoraCita
            // 
            dtpHoraCita.Format = DateTimePickerFormat.Time;
            dtpHoraCita.Location = new Point(197, 140);
            dtpHoraCita.Name = "dtpHoraCita";
            dtpHoraCita.Size = new Size(80, 23);
            dtpHoraCita.TabIndex = 6;
            dtpHoraCita.Value = new DateTime(2024, 5, 29, 0, 0, 0, 0);
            // 
            // lblMotivoCita
            // 
            lblMotivoCita.AutoSize = true;
            lblMotivoCita.Location = new Point(63, 203);
            lblMotivoCita.Name = "lblMotivoCita";
            lblMotivoCita.Size = new Size(97, 15);
            lblMotivoCita.TabIndex = 7;
            lblMotivoCita.Text = "Motivo de la Cita";
            // 
            // btnGuardarCita
            // 
            btnGuardarCita.BackColor = SystemColors.GradientActiveCaption;
            btnGuardarCita.Location = new Point(119, 300);
            btnGuardarCita.Name = "btnGuardarCita";
            btnGuardarCita.Size = new Size(138, 40);
            btnGuardarCita.TabIndex = 8;
            btnGuardarCita.Text = "Guardar Cita";
            btnGuardarCita.UseVisualStyleBackColor = false;
            btnGuardarCita.Click += btnGuardarCita_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(353, 300);
            button2.Name = "button2";
            button2.Size = new Size(131, 40);
            button2.TabIndex = 9;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Citas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 393);
            Controls.Add(button2);
            Controls.Add(btnGuardarCita);
            Controls.Add(lblMotivoCita);
            Controls.Add(dtpHoraCita);
            Controls.Add(lblHoraCita);
            Controls.Add(dtpFechaCita);
            Controls.Add(txtMotivoCita);
            Controls.Add(txtNombrePaciente);
            Controls.Add(lblFechaCita);
            Controls.Add(lblNombrePaciente);
            Name = "Citas";
            Text = "citas";
            Load += Citas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombrePaciente;
        private Label lblFechaCita;
        private TextBox txtNombrePaciente;
        private TextBox txtMotivoCita;
        private DateTimePicker dtpFechaCita;
        private Label lblHoraCita;
        private DateTimePicker dtpHoraCita;
        private Label lblMotivoCita;
        private Button btnGuardarCita;
        private Button button2;
    }
}