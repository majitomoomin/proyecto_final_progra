﻿namespace proyecto_final_.Properties
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
            labelpid = new Label();
            txtpid = new TextBox();
            dgwCitas = new DataGridView();
            button1 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwCitas).BeginInit();
            SuspendLayout();
            // 
            // lblNombrePaciente
            // 
            lblNombrePaciente.AutoSize = true;
            lblNombrePaciente.Location = new Point(34, 77);
            lblNombrePaciente.Name = "lblNombrePaciente";
            lblNombrePaciente.Size = new Size(148, 20);
            lblNombrePaciente.TabIndex = 0;
            lblNombrePaciente.Text = "Nombre del Paciente";
            // 
            // lblFechaCita
            // 
            lblFechaCita.AutoSize = true;
            lblFechaCita.Location = new Point(66, 113);
            lblFechaCita.Name = "lblFechaCita";
            lblFechaCita.Size = new Size(114, 20);
            lblFechaCita.TabIndex = 1;
            lblFechaCita.Text = "Fecha de la Cita";
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.Location = new Point(201, 67);
            txtNombrePaciente.Margin = new Padding(3, 4, 3, 4);
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.Size = new Size(442, 27);
            txtNombrePaciente.TabIndex = 2;
            // 
            // txtMotivoCita
            // 
            txtMotivoCita.Location = new Point(201, 183);
            txtMotivoCita.Margin = new Padding(3, 4, 3, 4);
            txtMotivoCita.Name = "txtMotivoCita";
            txtMotivoCita.Size = new Size(442, 27);
            txtMotivoCita.TabIndex = 3;
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Location = new Point(201, 105);
            dtpFechaCita.Margin = new Padding(3, 4, 3, 4);
            dtpFechaCita.MinDate = new DateTime(2024, 5, 29, 0, 0, 0, 0);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(261, 27);
            dtpFechaCita.TabIndex = 4;
            dtpFechaCita.Value = new DateTime(2024, 6, 1, 0, 0, 0, 0);
            // 
            // lblHoraCita
            // 
            lblHoraCita.AutoSize = true;
            lblHoraCita.Location = new Point(72, 148);
            lblHoraCita.Name = "lblHoraCita";
            lblHoraCita.Size = new Size(109, 20);
            lblHoraCita.TabIndex = 5;
            lblHoraCita.Text = "Hora de la Cita";
            // 
            // dtpHoraCita
            // 
            dtpHoraCita.Format = DateTimePickerFormat.Time;
            dtpHoraCita.Location = new Point(201, 144);
            dtpHoraCita.Margin = new Padding(3, 4, 3, 4);
            dtpHoraCita.Name = "dtpHoraCita";
            dtpHoraCita.Size = new Size(91, 27);
            dtpHoraCita.TabIndex = 6;
            dtpHoraCita.Value = new DateTime(2024, 5, 29, 0, 0, 0, 0);
            // 
            // lblMotivoCita
            // 
            lblMotivoCita.AutoSize = true;
            lblMotivoCita.Location = new Point(58, 183);
            lblMotivoCita.Name = "lblMotivoCita";
            lblMotivoCita.Size = new Size(123, 20);
            lblMotivoCita.TabIndex = 7;
            lblMotivoCita.Text = "Motivo de la Cita";
            // 
            // btnGuardarCita
            // 
            btnGuardarCita.BackColor = Color.SkyBlue;
            btnGuardarCita.Location = new Point(34, 244);
            btnGuardarCita.Margin = new Padding(3, 4, 3, 4);
            btnGuardarCita.Name = "btnGuardarCita";
            btnGuardarCita.Size = new Size(154, 36);
            btnGuardarCita.TabIndex = 8;
            btnGuardarCita.Text = "Guardar Cita";
            btnGuardarCita.UseVisualStyleBackColor = false;
            btnGuardarCita.Click += btnGuardarCita_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(34, 288);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(154, 45);
            button2.TabIndex = 9;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // labelpid
            // 
            labelpid.AutoSize = true;
            labelpid.Location = new Point(48, 32);
            labelpid.Name = "labelpid";
            labelpid.Size = new Size(135, 20);
            labelpid.TabIndex = 21;
            labelpid.Text = "No. Id del paciente";
            // 
            // txtpid
            // 
            txtpid.Location = new Point(201, 28);
            txtpid.Margin = new Padding(3, 4, 3, 4);
            txtpid.Name = "txtpid";
            txtpid.Size = new Size(442, 27);
            txtpid.TabIndex = 22;
            // 
            // dgwCitas
            // 
            dgwCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCitas.Location = new Point(201, 244);
            dgwCitas.Margin = new Padding(3, 4, 3, 4);
            dgwCitas.Name = "dgwCitas";
            dgwCitas.RowHeadersWidth = 51;
            dgwCitas.Size = new Size(624, 264);
            dgwCitas.TabIndex = 23;
            dgwCitas.CellContentClick += dgwCitas_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrange;
            button1.Location = new Point(34, 341);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(154, 36);
            button1.TabIndex = 24;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.SkyBlue;
            button3.Location = new Point(34, 385);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(154, 56);
            button3.TabIndex = 25;
            button3.Text = "Guardar Cita Actualizada";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Citas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 524);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(dgwCitas);
            Controls.Add(txtpid);
            Controls.Add(labelpid);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Citas";
            Text = "citas";
            Load += Citas_Load;
            ((System.ComponentModel.ISupportInitialize)dgwCitas).EndInit();
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
        private Label labelpid;
        private TextBox txtpid;
        private DataGridView dgwCitas;
        private Button button1;
        private Button button3;
    }
}