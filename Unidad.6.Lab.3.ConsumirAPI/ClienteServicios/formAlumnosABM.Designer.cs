namespace ClienteServicios
{
    partial class formAlumnosABM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvAlumnos = new DataGridView();
            btnListar = new Button();
            btnCrear = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(97, 34);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.ReadOnly = true;
            dgvAlumnos.RowHeadersWidth = 62;
            dgvAlumnos.RowTemplate.Height = 33;
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new Size(814, 363);
            dgvAlumnos.TabIndex = 0;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(97, 434);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(161, 45);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(318, 434);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(161, 45);
            btnCrear.TabIndex = 2;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(532, 434);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(161, 45);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(750, 434);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(161, 45);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // formAlumnosABM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 528);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnCrear);
            Controls.Add(btnListar);
            Controls.Add(dgvAlumnos);
            Name = "formAlumnosABM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alumnos ABM";
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAlumnos;
        private Button btnListar;
        private Button btnCrear;
        private Button btnModificar;
        private Button btnEliminar;
    }
}