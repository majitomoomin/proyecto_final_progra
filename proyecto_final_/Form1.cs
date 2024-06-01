namespace proyecto_final_
{
    public partial class Form1 : Form
    {
        private Dictionary<string, (string contraseña, string rol)> usuarios = new Dictionary<string, (string, string)>
        {
            { "Alicia Lima", ("1234", "Doctor") },
            { "Juan Perez", ("abcd", "Enfermero") },
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static string UsuarioLogeado { get; private set; }
        public static string RolLogeado { get; private set; }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String contraseña = txtContraseña.Text;
            string rol = cbRol.SelectedItem?.ToString();

            // Validar usuario, contraseña y rol
            if (usuarios.ContainsKey(usuario) && usuarios[usuario].contraseña == contraseña && usuarios[usuario].rol == rol)
            {
                UsuarioLogeado = usuario; // Guarda el nombre del usuario que inició sesión
                RolLogeado = rol; // Guarda el rol del usuario que inició sesión

                this.Hide();
                Dashboard ds = new Dashboard();
                ds.Show();
            }
            else
            {
                MessageBox.Show("El nombre de usuario o contraseña es incorrecto");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
