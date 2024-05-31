namespace proyecto_final_
{
    partial class FormHistorial
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
            dataGridViewHistorial = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(346, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 26);
            label1.TabIndex = 0;
            label1.Text = "Historial del Paciente";
            // 
            // dataGridViewHistorial
            // 
            dataGridViewHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistorial.Location = new Point(15, 91);
            dataGridViewHistorial.Margin = new Padding(2);
            dataGridViewHistorial.Name = "dataGridViewHistorial";
            dataGridViewHistorial.RowHeadersWidth = 82;
            dataGridViewHistorial.Size = new Size(892, 501);
            dataGridViewHistorial.TabIndex = 1;
            dataGridViewHistorial.CellContentClick += dataGridViewHistorial_CellContentClick;
            // 
            // FormHistorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dataGridViewHistorial);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "FormHistorial";
            Text = "Form2";
            Load += FormHistorial_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistorial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridViewHistorial;
    }
}