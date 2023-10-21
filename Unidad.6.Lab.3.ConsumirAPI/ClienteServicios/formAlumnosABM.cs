using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteServicios
{
    public partial class formAlumnosABM : Form
    {
        private Task<IEnumerable<Alumno>>? l;

        public formAlumnosABM()
        {
            InitializeComponent();
        }

        public IEnumerable<Alumno> CargarTabla()
        {
            l = AlumnoNegocio.GetAll();
            return l.Result;
        }

        private async void btnListar_Click(object sender, EventArgs e)
        {
            Task<IEnumerable<Alumno>> task = new Task<IEnumerable<Alumno>>(CargarTabla);
            task.Start();
            dgvAlumnos.DataSource = await task;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dgvAlumnos.SelectedRows[0].Index;
            await AlumnoNegocio.Delete(l.Result.ToList()[filaSeleccionada]);
            btnListar_Click(sender, e);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            new formAlta().ShowDialog();
            btnListar_Click(sender, e);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int filaSeleccionada = dgvAlumnos.SelectedRows[0].Index;
            new formAlta(l.Result.ToList()[filaSeleccionada]).ShowDialog();
            btnListar_Click(sender, e);
        }
    }
}
