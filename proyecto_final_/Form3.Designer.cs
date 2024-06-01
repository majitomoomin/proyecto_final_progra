namespace proyecto_final_
{
    partial class NotasClinicas
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
            txtSintomas = new TextBox();
            btnGuardarNota = new Button();
            txtPlanTra = new TextBox();
            txtDiagnosticoProv = new TextBox();
            txtObservaciones = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtpid = new TextBox();
            SuspendLayout();
            // 
            // txtSintomas
            // 
            txtSintomas.Location = new Point(245, 167);
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(368, 23);
            txtSintomas.TabIndex = 0;
            // 
            // btnGuardarNota
            // 
            btnGuardarNota.BackColor = Color.Coral;
            btnGuardarNota.Location = new Point(358, 356);
            btnGuardarNota.Name = "btnGuardarNota";
            btnGuardarNota.Size = new Size(122, 44);
            btnGuardarNota.TabIndex = 1;
            btnGuardarNota.Text = "Guardar Nota";
            btnGuardarNota.UseVisualStyleBackColor = false;
            btnGuardarNota.Click += btnGuardarNota_Click;
            // 
            // txtPlanTra
            // 
            txtPlanTra.Location = new Point(245, 312);
            txtPlanTra.Name = "txtPlanTra";
            txtPlanTra.Size = new Size(368, 23);
            txtPlanTra.TabIndex = 2;
            // 
            // txtDiagnosticoProv
            // 
            txtDiagnosticoProv.Location = new Point(245, 256);
            txtDiagnosticoProv.Name = "txtDiagnosticoProv";
            txtDiagnosticoProv.Size = new Size(368, 23);
            txtDiagnosticoProv.TabIndex = 3;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(245, 211);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(368, 23);
            txtObservaciones.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(262, 33);
            label1.Name = "label1";
            label1.Size = new Size(268, 30);
            label1.TabIndex = 5;
            label1.Text = "Registro de Notas Clínicas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 175);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "Síntomas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 315);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 7;
            label3.Text = "Plan de Tratamiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 264);
            label4.Name = "label4";
            label4.Size = new Size(148, 15);
            label4.TabIndex = 8;
            label4.Text = "Diagnósticos Provicionales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 219);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 9;
            label5.Text = "Observaciones";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 121);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 10;
            label6.Text = "No. Id paciente";
            // 
            // txtpid
            // 
            txtpid.Location = new Point(245, 113);
            txtpid.Name = "txtpid";
            txtpid.Size = new Size(368, 23);
            txtpid.TabIndex = 11;
            // 
            // NotasClinicas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtpid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtObservaciones);
            Controls.Add(txtDiagnosticoProv);
            Controls.Add(txtPlanTra);
            Controls.Add(btnGuardarNota);
            Controls.Add(txtSintomas);
            Name = "NotasClinicas";
            Text = "NotasClínicas";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSintomas;
        private Button btnGuardarNota;
        private TextBox txtPlanTra;
        private TextBox txtDiagnosticoProv;
        private TextBox txtObservaciones;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtpid;
    }
}