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
    public partial class formAlta : Form
    {
        public formAlta()
        {
            InitializeComponent();
        }

        public formAlta(Alumno alumnoAModificar)
        {
            InitializeComponent();
            btnAceptar.Text = "Modificar";
            txtDNI.Text = alumnoAModificar.DNI;
            txtAyN.Text = alumnoAModificar.ApellidoNombre;
            txtEmail.Text = alumnoAModificar.Email;
            dtpFechNac.Value = alumnoAModificar.FechaNacimiento;
            txtProm.Text = Convert.ToString(alumnoAModificar.NotaPromedio);
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            var alu = new Alumno();
            alu.DNI = txtDNI.Text;
            alu.ApellidoNombre = txtAyN.Text;
            alu.Email = txtEmail.Text;
            alu.FechaNacimiento = dtpFechNac.Value;
            alu.NotaPromedio = Convert.ToDecimal(txtProm.Text);

            if (btnAceptar.Text == "Modificar")
            {
                await AlumnoNegocio.Update(alu);
            }
            else
            {
                await AlumnoNegocio.Add(alu);
            }

            Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
