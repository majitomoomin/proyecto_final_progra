namespace proyecto_final_
{
    partial class Mensajes
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
            Chat = new ListBox();
            txtMensaje = new TextBox();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // Chat
            // 
            Chat.FormattingEnabled = true;
            Chat.ItemHeight = 15;
            Chat.Location = new Point(63, 21);
            Chat.Name = "Chat";
            Chat.Size = new Size(666, 319);
            Chat.TabIndex = 0;
            Chat.SelectedIndexChanged += Chat_SelectedIndexChanged;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(72, 358);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(571, 23);
            txtMensaje.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.BackColor = Color.LightSalmon;
            btnEnviar.Location = new Point(650, 356);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(83, 27);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = false;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // Mensajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnviar);
            Controls.Add(txtMensaje);
            Controls.Add(Chat);
            Name = "Mensajes";
            Text = "Mensajes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox Chat;
        private TextBox txtMensaje;
        private Button btnEnviar;
    }
}