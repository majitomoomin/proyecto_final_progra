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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String contraseña = txtContraseña.Text;

            if( usuario == "Alicia Lima" && contraseña == "1234")
            {
                //MessageBox.Show("Has ingresado el usuario y contraseña correctos");
                this.Hide();
                Form2 ds = new Form2();
                ds.Show();
            }
            else
            {
                MessageBox.Show("El nombre de usuario o contraseña es incorrecto");
            }
        }
    }
}
