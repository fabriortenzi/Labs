namespace AcademiaABM
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            dgvUsuarios.AutoGenerateColumns = false;

        }

        public void Listar()
        {
            List<Usuario> usuarios = new();
            usuarios.Add(new Usuario(1, "Juan", "Perez", "juanperez", "juanperez@gmail.com", true));
            usuarios.Add(new Usuario(2, "Federica", "Gutierrez", "fedegutierrez", "fedegutierrez@gmail.com", false));
            usuarios.Add(new Usuario(3, "Pedro", "Gimenez", "pedrogimenez", "pedrogimenez@gmail.com", true));
            dgvUsuarios.DataSource = usuarios;
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
