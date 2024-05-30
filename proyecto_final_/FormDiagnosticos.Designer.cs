namespace proyecto_final_
{
    partial class FormDiagnosticos
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
            label1 = new Label();
            label2 = new Label();
            labelSintomas = new Label();
            labelDiagnosis = new Label();
            labelMedicina = new Label();
            label6 = new Label();
            labelAlergias = new Label();
            txtpid = new TextBox();
            txtSintomas = new TextBox();
            txtDiagnosis = new TextBox();
            txtMedicamentos = new TextBox();
            btnGuardardiagnostico = new Button();
            txtProcedimiento = new TextBox();
            txtAlergias = new TextBox();
            dataGridViewDiagnosis = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDiagnosis).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, -2);
            label1.Name = "label1";
            label1.Size = new Size(286, 39);
            label1.TabIndex = 0;
            label1.Text = "Añadir diagnosticos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(210, 53);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 1;
            label2.Text = "ID del paciente";
            // 
            // labelSintomas
            // 
            labelSintomas.AutoSize = true;
            labelSintomas.Location = new Point(32, 320);
            labelSintomas.Name = "labelSintomas";
            labelSintomas.Size = new Size(70, 20);
            labelSintomas.TabIndex = 2;
            labelSintomas.Text = "Sintomas";
            // 
            // labelDiagnosis
            // 
            labelDiagnosis.AutoSize = true;
            labelDiagnosis.Location = new Point(32, 387);
            labelDiagnosis.Name = "labelDiagnosis";
            labelDiagnosis.Size = new Size(74, 20);
            labelDiagnosis.TabIndex = 3;
            labelDiagnosis.Text = "Diagnosis";
            // 
            // labelMedicina
            // 
            labelMedicina.AutoSize = true;
            labelMedicina.Location = new Point(12, 455);
            labelMedicina.Name = "labelMedicina";
            labelMedicina.Size = new Size(158, 20);
            labelMedicina.TabIndex = 4;
            labelMedicina.Text = "Medicamentos y Dosis";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(399, 319);
            label6.Name = "label6";
            label6.Size = new Size(160, 20);
            label6.TabIndex = 5;
            label6.Text = "Procedimiento medico";
            // 
            // labelAlergias
            // 
            labelAlergias.AutoSize = true;
            labelAlergias.Location = new Point(399, 363);
            labelAlergias.Name = "labelAlergias";
            labelAlergias.Size = new Size(255, 20);
            labelAlergias.TabIndex = 6;
            labelAlergias.Text = "Alergias y reaciones a medicamentos";
            // 
            // txtpid
            // 
            txtpid.Location = new Point(326, 50);
            txtpid.Name = "txtpid";
            txtpid.Size = new Size(182, 27);
            txtpid.TabIndex = 7;
            txtpid.TextChanged += txtpid_TextChanged;
            // 
            // txtSintomas
            // 
            txtSintomas.Location = new Point(108, 316);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(223, 27);
            txtSintomas.TabIndex = 8;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.Location = new Point(108, 380);
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Size = new Size(223, 27);
            txtDiagnosis.TabIndex = 9;
            // 
            // txtMedicamentos
            // 
            txtMedicamentos.Location = new Point(176, 452);
            txtMedicamentos.Name = "txtMedicamentos";
            txtMedicamentos.Size = new Size(599, 27);
            txtMedicamentos.TabIndex = 10;
            // 
            // btnGuardardiagnostico
            // 
            btnGuardardiagnostico.Location = new Point(369, 495);
            btnGuardardiagnostico.Name = "btnGuardardiagnostico";
            btnGuardardiagnostico.Size = new Size(94, 29);
            btnGuardardiagnostico.TabIndex = 13;
            btnGuardardiagnostico.Text = "Guardar";
            btnGuardardiagnostico.UseVisualStyleBackColor = true;
            btnGuardardiagnostico.Click += btnGuardardiagnostico_Click;
            // 
            // txtProcedimiento
            // 
            txtProcedimiento.Location = new Point(565, 316);
            txtProcedimiento.Name = "txtProcedimiento";
            txtProcedimiento.Size = new Size(223, 27);
            txtProcedimiento.TabIndex = 14;
            // 
            // txtAlergias
            // 
            txtAlergias.Location = new Point(399, 387);
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(376, 27);
            txtAlergias.TabIndex = 15;
            // 
            // dataGridViewDiagnosis
            // 
            dataGridViewDiagnosis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDiagnosis.Location = new Point(-2, 110);
            dataGridViewDiagnosis.Name = "dataGridViewDiagnosis";
            dataGridViewDiagnosis.RowHeadersWidth = 51;
            dataGridViewDiagnosis.Size = new Size(830, 191);
            dataGridViewDiagnosis.TabIndex = 16;
            // 
            // FormDiagnosticos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 592);
            Controls.Add(dataGridViewDiagnosis);
            Controls.Add(txtAlergias);
            Controls.Add(txtProcedimiento);
            Controls.Add(btnGuardardiagnostico);
            Controls.Add(txtMedicamentos);
            Controls.Add(txtDiagnosis);
            Controls.Add(txtSintomas);
            Controls.Add(txtpid);
            Controls.Add(labelAlergias);
            Controls.Add(label6);
            Controls.Add(labelMedicina);
            Controls.Add(labelDiagnosis);
            Controls.Add(labelSintomas);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDiagnosticos";
            Text = "Agregar Diagnosticos";
            Load += FormDiagnosticos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDiagnosis).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label labelSintomas;
        private Label labelDiagnosis;
        private Label labelMedicina;
        private Label label6;
        private Label labelAlergias;
        private TextBox txtpid;
        private TextBox txtSintomas;
        private TextBox txtDiagnosis;
        private TextBox txtMedicamentos;
        private Button btnGuardardiagnostico;
        private TextBox txtProcedimiento;
        private TextBox txtAlergias;
        private DataGridView dataGridViewDiagnosis;
    }
}