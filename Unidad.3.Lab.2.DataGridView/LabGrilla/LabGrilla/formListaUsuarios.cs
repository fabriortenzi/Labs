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

        private DataTable getTiposDocumento()
        {
            // Creo DataTable
            DataTable dtTiposDoc = new DataTable();
            // Agrego columnas al DataTable
            dtTiposDoc.Columns.Add("cod_tipo_doc", typeof(int));
            dtTiposDoc.Columns.Add("desc_tipo_doc", typeof(string));
            // Agrego filas al DataTable
            dtTiposDoc.Rows.Add(new object[] { 1, "DNI" });
            dtTiposDoc.Rows.Add(new object[] { 2, "Cédula" });
            dtTiposDoc.Rows.Add(new object[] { 3, "Pasaporte" });
            dtTiposDoc.Rows.Add(new object[] { 4, "Libreta Cívica" });
            dtTiposDoc.Rows.Add(new object[] { 5, "Libreta Enrolamiento" });
            return dtTiposDoc;
        }


        private void GenerarColumnas()
        {
            // Creando la columna Nro. Documento

            // Creamos la nueva columna y definimos el tipo de columna
            DataGridViewTextBoxColumn colNroDoc = new DataGridViewTextBoxColumn();
            // Asignamos un nombre a la columna
            colNroDoc.Name = "nro_doc";
            // Indicamos el título a mostrar
            colNroDoc.HeaderText = "Nro. Documento";
            // Indicamos con cual columna del DataTable que asignamos al DataSource de la grilla debe vincularse
            colNroDoc.DataPropertyName = "nro_doc";
            // En que posición debe mostrarse, todas las columnas a la derecha de la posición que indiquemos se moverán una posción a la derecha
            colNroDoc.DisplayIndex = 0;
            // Cambiamos el ancho
            colNroDoc.Width = 180;
            // Agregamos la columna al DataGridView para que la muestre
            this.dgvUsuarios.Columns.Add(colNroDoc);

            // Creando la columna Tipo Documento
            DataGridViewComboBoxColumn colTipoDoc = new DataGridViewComboBoxColumn();
            colTipoDoc.Name = "tipo_doc";
            colTipoDoc.HeaderText = "Tipo Documento";
            colTipoDoc.DataPropertyName = "tipo_doc";
            colTipoDoc.Width = 180;
            colTipoDoc.DisplayIndex = 0;

            // Agrego items manualmente

            // Asigno la lista de items que son válidos
            colTipoDoc.DataSource = this.getTiposDocumento();
            // Indico que el valor interno del combo es el valor de la fila elegida y la columna cod_tipo_doc del DataSource que asigné a la columna colTipoDoc
            colTipoDoc.ValueMember = "cod_tipo_doc";
            /* Indico que el valor que se muestra al usuario es el que se corresponde
            con la columna desc_tipo_doc del DataSource que asigné a colTipoDoc
            independientemente de la columna de la cual obtiene su valor */
            colTipoDoc.DisplayMember = "desc_tipo_doc";

            this.dgvUsuarios.Columns.Add(colTipoDoc);

            DataGridViewTextBoxColumn colTel = new DataGridViewTextBoxColumn();
            colTel.Name = "telefono";
            colTel.HeaderText = "Teléfono";
            colTel.DataPropertyName = "telefono";

            DataGridViewTextBoxColumn colEmail = new DataGridViewTextBoxColumn();
            colEmail.Name = "email";
            colEmail.HeaderText = "E-Mail";
            colEmail.DataPropertyName = "email";

            DataGridViewTextBoxColumn colCel = new DataGridViewTextBoxColumn();
            colCel.Name = "celular";
            colCel.HeaderText = "Celular";
            colCel.DataPropertyName = "celular";

            DataGridViewTextBoxColumn colUsuario = new DataGridViewTextBoxColumn();
            colUsuario.Name = "usuario";
            colUsuario.HeaderText = "Usuario";
            colUsuario.DataPropertyName = "usuario";

            DataGridViewTextBoxColumn colClave = new DataGridViewTextBoxColumn();
            colClave.Name = "clave";
            colClave.HeaderText = "Clave";
            colClave.DataPropertyName = "clave";
            colEmail.Width = 250;
            colNroDoc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            colClave.Visible = false;
            /* Como las columnas direccion, nombre, apellido y fecha de nacimiento las creamos
            con el diseñador de formularios no disponemos de una variable para hacer 
            referencia a ellas. Entonces debemos referenciarlas con 
            this.dgvUsuarios.Columns["nombre_columna"] donde el nombre_columna es lo que 
            indicamos en la propiedad Name de las columnas */
            this.dgvUsuarios.Columns["direccion"].Width = 250;
            this.dgvUsuarios.Columns["apellido"].DefaultCellStyle.Font =
            new Font(this.dgvUsuarios.DefaultCellStyle.Font, FontStyle.Bold);
            this.dgvUsuarios.Columns["nombre"].DefaultCellStyle.Font =
            new Font(this.dgvUsuarios.DefaultCellStyle.Font, FontStyle.Bold);
            this.dgvUsuarios.Columns["fecha_nac"].DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleRight;

            this.dgvUsuarios.Columns.Add(colTel);
            this.dgvUsuarios.Columns.Add(colEmail);
            this.dgvUsuarios.Columns.Add(colCel);
            this.dgvUsuarios.Columns.Add(colUsuario);
            this.dgvUsuarios.Columns.Add(colClave);
        }


        public formListaUsuarios()
        {
            InitializeComponent();
            GenerarColumnas();
            this.dgvUsuarios.AutoGenerateColumns = false;
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