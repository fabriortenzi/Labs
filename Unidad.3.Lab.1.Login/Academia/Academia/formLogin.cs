namespace Academia
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //la propiedad Text de los TextBox contiene el texto escrito en ellos
            if (this.txtUsuario.Text == "Admin" && this.txtPass.Text == "admin")
            {
                MessageBox.Show("Usted ha ingresado al sistema correctamente.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario y/o contrase�a incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkOlvidaPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Es Ud. un usuario muy descuidado, haga memoria", "Olvid� mi contrase�a", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}