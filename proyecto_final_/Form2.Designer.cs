namespace proyecto_final_
{
    partial class Form2
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
            label2 = new Label();
            dataGridViewListado = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListado).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(358, 33);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(199, 26);
            label2.TabIndex = 1;
            label2.Text = "Listado de pacientes";
            // 
            // dataGridViewListado
            // 
            dataGridViewListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewListado.Location = new Point(69, 77);
            dataGridViewListado.Margin = new Padding(2);
            dataGridViewListado.Name = "dataGridViewListado";
            dataGridViewListado.RowHeadersWidth = 82;
            dataGridViewListado.Size = new Size(713, 367);
            dataGridViewListado.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dataGridViewListado);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Listado de pacientes";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private DataGridView dataGridViewListado;
    }
}