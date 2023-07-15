namespace AcademiaABM
{
    partial class Usuarios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            tlUsuarios = new ToolStripContainer();
            tlAlumnos = new TableLayoutPanel();
            dgvUsuarios = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            usuario = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            habilitado = new DataGridViewCheckBoxColumn();
            btnActualizar = new Button();
            btnSalir = new Button();
            tsUsuarios = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            toolStrip2 = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            tlUsuarios.ContentPanel.SuspendLayout();
            tlUsuarios.TopToolStripPanel.SuspendLayout();
            tlUsuarios.SuspendLayout();
            tlAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            tsUsuarios.SuspendLayout();
            toolStrip2.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tlUsuarios
            // 
            // 
            // tlUsuarios.ContentPanel
            // 
            tlUsuarios.ContentPanel.Controls.Add(tlAlumnos);
            tlUsuarios.ContentPanel.Size = new Size(800, 417);
            tlUsuarios.Dock = DockStyle.Fill;
            tlUsuarios.Location = new Point(0, 0);
            tlUsuarios.Name = "tlUsuarios";
            tlUsuarios.Size = new Size(800, 450);
            tlUsuarios.TabIndex = 0;
            tlUsuarios.Text = "toolStripContainer1";
            // 
            // tlUsuarios.TopToolStripPanel
            // 
            tlUsuarios.TopToolStripPanel.Controls.Add(toolStrip1);
            tlUsuarios.TopToolStripPanel.Controls.Add(toolStrip2);
            tlUsuarios.TopToolStripPanel.Controls.Add(tsUsuarios);
            // 
            // tlAlumnos
            // 
            tlAlumnos.ColumnCount = 2;
            tlAlumnos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlAlumnos.ColumnStyles.Add(new ColumnStyle());
            tlAlumnos.Controls.Add(dgvUsuarios, 0, 0);
            tlAlumnos.Controls.Add(btnActualizar, 0, 1);
            tlAlumnos.Controls.Add(btnSalir, 1, 1);
            tlAlumnos.Dock = DockStyle.Fill;
            tlAlumnos.Location = new Point(0, 0);
            tlAlumnos.Name = "tlAlumnos";
            tlAlumnos.RowCount = 2;
            tlAlumnos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlAlumnos.RowStyles.Add(new RowStyle());
            tlAlumnos.Size = new Size(800, 417);
            tlAlumnos.TabIndex = 0;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { id, nombre, apellido, usuario, email, habilitado });
            tlAlumnos.SetColumnSpan(dgvUsuarios, 2);
            dgvUsuarios.Dock = DockStyle.Fill;
            dgvUsuarios.Location = new Point(3, 3);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.RowTemplate.Height = 33;
            dgvUsuarios.Size = new Size(794, 371);
            dgvUsuarios.TabIndex = 0;
            // 
            // id
            // 
            id.DataPropertyName = "ID";
            id.HeaderText = "ID";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 150;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "Nombre";
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 8;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 150;
            // 
            // apellido
            // 
            apellido.DataPropertyName = "Apellido";
            apellido.HeaderText = "Apellido";
            apellido.MinimumWidth = 8;
            apellido.Name = "apellido";
            apellido.ReadOnly = true;
            apellido.Width = 150;
            // 
            // usuario
            // 
            usuario.DataPropertyName = "NombreUsuario";
            usuario.HeaderText = "Usuario";
            usuario.MinimumWidth = 8;
            usuario.Name = "usuario";
            usuario.ReadOnly = true;
            usuario.Width = 150;
            // 
            // email
            // 
            email.DataPropertyName = "EMail";
            email.HeaderText = "EMail";
            email.MinimumWidth = 8;
            email.Name = "email";
            email.ReadOnly = true;
            email.Width = 150;
            // 
            // habilitado
            // 
            habilitado.DataPropertyName = "Habilitado";
            habilitado.HeaderText = "Habilitado";
            habilitado.MinimumWidth = 8;
            habilitado.Name = "habilitado";
            habilitado.ReadOnly = true;
            habilitado.Resizable = DataGridViewTriState.True;
            habilitado.SortMode = DataGridViewColumnSortMode.Automatic;
            habilitado.Width = 150;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.Location = new Point(567, 380);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(112, 34);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(685, 380);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(112, 34);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // tsUsuarios
            // 
            tsUsuarios.Dock = DockStyle.None;
            tsUsuarios.ImageScalingSize = new Size(24, 24);
            tsUsuarios.Items.AddRange(new ToolStripItem[] { tsbNuevo });
            tsUsuarios.Location = new Point(4, 0);
            tsUsuarios.Name = "tsUsuarios";
            tsUsuarios.Size = new Size(52, 33);
            tsUsuarios.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            tsbNuevo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbNuevo.Image = (Image)resources.GetObject("tsbNuevo.Image");
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(34, 28);
            tsbNuevo.ToolTipText = "Nuevo";
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.None;
            toolStrip2.ImageScalingSize = new Size(24, 24);
            toolStrip2.Items.AddRange(new ToolStripItem[] { toolStripButton2 });
            toolStrip2.Location = new Point(56, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(52, 33);
            toolStrip2.TabIndex = 2;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(34, 28);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.ToolTipText = "Eliminar";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(24, 24);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(108, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(52, 33);
            toolStrip1.TabIndex = 1;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(34, 28);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.ToolTipText = "Editar";
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tlUsuarios);
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            tlUsuarios.ContentPanel.ResumeLayout(false);
            tlUsuarios.TopToolStripPanel.ResumeLayout(false);
            tlUsuarios.TopToolStripPanel.PerformLayout();
            tlUsuarios.ResumeLayout(false);
            tlUsuarios.PerformLayout();
            tlAlumnos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            tsUsuarios.ResumeLayout(false);
            tsUsuarios.PerformLayout();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer tlUsuarios;
        private ToolStrip tsUsuarios;
        private TableLayoutPanel tlAlumnos;
        private DataGridView dgvUsuarios;
        private Button btnActualizar;
        private Button btnSalir;
        private ToolStripButton tsbNuevo;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStrip toolStrip2;
        private ToolStripButton toolStripButton2;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn usuario;
        private DataGridViewTextBoxColumn email;
        private DataGridViewCheckBoxColumn habilitado;
    }
}