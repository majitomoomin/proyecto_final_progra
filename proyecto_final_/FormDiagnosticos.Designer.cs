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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(388, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 53);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "label2";
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
            // textBox1
            // 
            textBox1.Location = new Point(326, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 316);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(108, 380);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(223, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(176, 452);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(599, 27);
            textBox4.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(369, 495);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(565, 316);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(223, 27);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(399, 387);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(376, 27);
            textBox6.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(830, 191);
            dataGridView1.TabIndex = 16;
            // 
            // FormDiagnosticos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 592);
            Controls.Add(dataGridView1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private TextBox textBox5;
        private TextBox textBox6;
        private DataGridView dataGridView1;
    }
}