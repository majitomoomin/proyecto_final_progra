namespace proyecto_final_
{
    public partial class Form1 : Form
    {
        private Dictionary<string, (string contrase�a, string rol)> usuarios = new Dictionary<string, (string, string)>
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
            String contrase�a = txtContrase�a.Text;
            string rol = cbRol.SelectedItem?.ToString();

            // Validar usuario, contrase�a y rol
            if (usuarios.ContainsKey(usuario) && usuarios[usuario].contrase�a == contrase�a && usuarios[usuario].rol == rol)
            {
                UsuarioLogeado = usuario; // Guarda el nombre del usuario que inici� sesi�n
                RolLogeado = rol; // Guarda el rol del usuario que inici� sesi�n

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
