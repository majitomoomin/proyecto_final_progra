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
            String contrase�a = txtContrase�a.Text;

            if( usuario == "Alicia Lima" && contrase�a == "1234")
            {
                //MessageBox.Show("Has ingresado el usuario y contrase�a correctos");
                this.Hide();
                Form2 ds = new Form2();
                ds.Show();
            }
            else
            {
                MessageBox.Show("El nombre de usuario o contrase�a es incorrecto");
            }
        }
    }
}
