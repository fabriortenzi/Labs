using Negocio;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace LabGrilla
{
    public partial class formListaUsuarios : Form
    {
        private Usuarios _usuarios;

        public Negocio.Usuarios oUsuarios
        {
            get { return _usuarios; }
            set { _usuarios = value; }
        }

        public formListaUsuarios()
        {
            InitializeComponent();
            this.oUsuarios = new Negocio.Usuarios();
            this.dgvUsuarios.DataSource = this.oUsuarios.GetAll();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.GuardarCambios();
            this.RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            this.dgvUsuarios.DataSource = this.oUsuarios.GetAll();
        }
        private void GuardarCambios()
        {
            this.oUsuarios.GuardarCambios((DataTable)this.dgvUsuarios.DataSource);
        }
    }
}