namespace ClienteServicios
{
    partial class formAlta
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtDNI = new TextBox();
            txtAyN = new TextBox();
            txtEmail = new TextBox();
            txtProm = new TextBox();
            dtpFechNac = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 79);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 147);
            label2.Name = "label2";
            label2.Size = new Size(163, 25);
            label2.TabIndex = 1;
            label2.Text = "Apellido y Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 227);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 308);
            label4.Name = "label4";
            label4.Size = new Size(177, 25);
            label4.TabIndex = 3;
            label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 387);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 4;
            label5.Text = "Promedio";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(442, 487);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(159, 47);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(195, 487);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(159, 47);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(399, 76);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(257, 31);
            txtDNI.TabIndex = 7;
            // 
            // txtAyN
            // 
            txtAyN.Location = new Point(399, 144);
            txtAyN.Name = "txtAyN";
            txtAyN.Size = new Size(257, 31);
            txtAyN.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(399, 224);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(257, 31);
            txtEmail.TabIndex = 9;
            // 
            // txtProm
            // 
            txtProm.Location = new Point(399, 384);
            txtProm.Name = "txtProm";
            txtProm.Size = new Size(257, 31);
            txtProm.TabIndex = 10;
            // 
            // dtpFechNac
            // 
            dtpFechNac.Location = new Point(399, 303);
            dtpFechNac.Name = "dtpFechNac";
            dtpFechNac.Size = new Size(300, 31);
            dtpFechNac.TabIndex = 11;
            // 
            // formAlta
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(800, 580);
            Controls.Add(dtpFechNac);
            Controls.Add(txtProm);
            Controls.Add(txtEmail);
            Controls.Add(txtAyN);
            Controls.Add(txtDNI);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "formAlta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtDNI;
        private TextBox txtAyN;
        private TextBox txtEmail;
        private TextBox txtProm;
        private DateTimePicker dtpFechNac;
    }
}