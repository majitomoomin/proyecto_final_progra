namespace proyecto_final_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static string UsuarioLogeado { get; private set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String contrase�a = txtContrase�a.Text;

            if (usuario == "Alicia Lima" && contrase�a == "1234")
            {
                UsuarioLogeado = usuario; // Guardar el nombre del usuario que inici� sesi�n
                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();
            }
            else
            {
                MessageBox.Show("El nombre de usuario o contrase�a es incorrecto");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
