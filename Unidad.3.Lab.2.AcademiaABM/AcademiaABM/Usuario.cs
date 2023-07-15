using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaABM
{
    internal class Usuario
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string NombreUsuario { get; set; }

        public string EMail { get; set; }

        public bool Habilitado { get; set; }

        public Usuario(int id, string nombre, string apelllido, string nombreUsuario, string email, bool habilitado)
        {
            ID = id;
            Nombre = nombre;
            Apellido = apelllido;
            NombreUsuario = nombreUsuario;
            EMail = email;
            Habilitado = habilitado;
        }        
    }
}
