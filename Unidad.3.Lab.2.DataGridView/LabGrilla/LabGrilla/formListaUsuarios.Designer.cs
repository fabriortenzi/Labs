namespace LabGrilla
{
    partial class formListaUsuarios
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvUsuarios = new DataGridView();
            apellido = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            fecha_nac = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnGuardar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dataGridViewCellStyle1.BackColor = Color.MediumTurquoise;
            dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { apellido, nombre, fecha_nac, direccion });
            dgvUsuarios.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvUsuarios.Location = new Point(12, 37);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 62;
            dgvUsuarios.RowTemplate.Height = 33;
            dgvUsuarios.Size = new Size(776, 361);
            dgvUsuarios.TabIndex = 0;
            // 
            // apellido
            // 
            apellido.DataPropertyName = "apellido";
            apellido.HeaderText = "Apellido";
            apellido.MinimumWidth = 8;
            apellido.Name = "apellido";
            apellido.Width = 150;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "nombre";
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 8;
            nombre.Name = "nombre";
            nombre.Width = 150;
            // 
            // fecha_nac
            // 
            fecha_nac.DataPropertyName = "fecha_nac";
            fecha_nac.HeaderText = "Fecha de nacimiento";
            fecha_nac.MinimumWidth = 8;
            fecha_nac.Name = "fecha_nac";
            fecha_nac.Width = 220;
            // 
            // direccion
            // 
            direccion.DataPropertyName = "direccion";
            direccion.HeaderText = "Direccion";
            direccion.MinimumWidth = 8;
            direccion.Name = "direccion";
            direccion.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 1;
            label1.Text = "Lista de Usuarios:";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGuardar.Location = new Point(676, 404);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // formListaUsuarios
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGuardar);
            Controls.Add(label1);
            Controls.Add(dgvUsuarios);
            Name = "formListaUsuarios";
            Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Label label1;
        private Button btnGuardar;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn fecha_nac;
        private DataGridViewTextBoxColumn direccion;
    }
}