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
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNombrePaciente
            // 
            lblNombrePaciente.AutoSize = true;
            lblNombrePaciente.Location = new Point(48, 56);
            lblNombrePaciente.Name = "lblNombrePaciente";
            lblNombrePaciente.Size = new Size(148, 20);
            lblNombrePaciente.TabIndex = 0;
            lblNombrePaciente.Text = "Nombre del Paciente";
            // 
            // lblFechaCita
            // 
            lblFechaCita.AutoSize = true;
            lblFechaCita.Location = new Point(48, 121);
            lblFechaCita.Name = "lblFechaCita";
            lblFechaCita.Size = new Size(114, 20);
            lblFechaCita.TabIndex = 1;
            lblFechaCita.Text = "Fecha de la Cita";
            // 
            // txtNombrePaciente
            // 
            txtNombrePaciente.Location = new Point(201, 53);
            txtNombrePaciente.Margin = new Padding(3, 4, 3, 4);
            txtNombrePaciente.Name = "txtNombrePaciente";
            txtNombrePaciente.Size = new Size(442, 27);
            txtNombrePaciente.TabIndex = 2;
            // 
            // txtMotivoCita
            // 
            txtMotivoCita.Location = new Point(201, 260);
            txtMotivoCita.Margin = new Padding(3, 4, 3, 4);
            txtMotivoCita.Name = "txtMotivoCita";
            txtMotivoCita.Size = new Size(442, 27);
            txtMotivoCita.TabIndex = 3;
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.Location = new Point(201, 116);
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
            lblHoraCita.Location = new Point(48, 194);
            lblHoraCita.Name = "lblHoraCita";
            lblHoraCita.Size = new Size(109, 20);
            lblHoraCita.TabIndex = 5;
            lblHoraCita.Text = "Hora de la Cita";
            // 
            // dtpHoraCita
            // 
            dtpHoraCita.Format = DateTimePickerFormat.Time;
            dtpHoraCita.Location = new Point(201, 189);
            dtpHoraCita.Margin = new Padding(3, 4, 3, 4);
            dtpHoraCita.Name = "dtpHoraCita";
            dtpHoraCita.Size = new Size(91, 27);
            dtpHoraCita.TabIndex = 6;
            dtpHoraCita.Value = new DateTime(2024, 5, 29, 0, 0, 0, 0);
            // 
            // lblMotivoCita
            // 
            lblMotivoCita.AutoSize = true;
            lblMotivoCita.Location = new Point(48, 267);
            lblMotivoCita.Name = "lblMotivoCita";
            lblMotivoCita.Size = new Size(123, 20);
            lblMotivoCita.TabIndex = 7;
            lblMotivoCita.Text = "Motivo de la Cita";
            // 
            // btnGuardarCita
            // 
            btnGuardarCita.BackColor = SystemColors.GradientActiveCaption;
            btnGuardarCita.Location = new Point(136, 400);
            btnGuardarCita.Margin = new Padding(3, 4, 3, 4);
            btnGuardarCita.Name = "btnGuardarCita";
            btnGuardarCita.Size = new Size(158, 53);
            btnGuardarCita.TabIndex = 8;
            btnGuardarCita.Text = "Guardar Cita";
            btnGuardarCita.UseVisualStyleBackColor = false;
            btnGuardarCita.Click += btnGuardarCita_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(403, 400);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(150, 53);
            button2.TabIndex = 9;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(649, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(253, 485);
            dataGridView1.TabIndex = 10;
            // 
            // Citas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 524);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DataGridView dataGridView1;
    }
}