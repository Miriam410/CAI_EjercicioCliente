namespace CAI_EjercicioCliente
{
    partial class FrmAgregarCliente
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
            this.lbl_Dni = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Dirección = new System.Windows.Forms.Label();
            this.lbl_FechaNacimiento = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.rbn_No = new System.Windows.Forms.RadioButton();
            this.rbn_Si = new System.Windows.Forms.RadioButton();
            this.lbl_Activo = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Dni
            // 
            this.lbl_Dni.AutoSize = true;
            this.lbl_Dni.Location = new System.Drawing.Point(22, 38);
            this.lbl_Dni.Name = "lbl_Dni";
            this.lbl_Dni.Size = new System.Drawing.Size(23, 13);
            this.lbl_Dni.TabIndex = 0;
            this.lbl_Dni.Text = "Dni";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(22, 78);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.Location = new System.Drawing.Point(316, 78);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(44, 13);
            this.lbl_Apellido.TabIndex = 2;
            this.lbl_Apellido.Text = "Apellido";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(316, 122);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(49, 13);
            this.lbl_Telefono.TabIndex = 5;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(22, 166);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 4;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_Dirección
            // 
            this.lbl_Dirección.AutoSize = true;
            this.lbl_Dirección.Location = new System.Drawing.Point(22, 122);
            this.lbl_Dirección.Name = "lbl_Dirección";
            this.lbl_Dirección.Size = new System.Drawing.Size(52, 13);
            this.lbl_Dirección.TabIndex = 3;
            this.lbl_Dirección.Text = "Dirección";
            // 
            // lbl_FechaNacimiento
            // 
            this.lbl_FechaNacimiento.AutoSize = true;
            this.lbl_FechaNacimiento.Location = new System.Drawing.Point(19, 205);
            this.lbl_FechaNacimiento.Name = "lbl_FechaNacimiento";
            this.lbl_FechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.lbl_FechaNacimiento.TabIndex = 6;
            this.lbl_FechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Red;
            this.btn_Salir.Location = new System.Drawing.Point(429, 287);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(99, 55);
            this.btn_Salir.TabIndex = 22;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Enviar.Location = new System.Drawing.Point(300, 287);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(92, 55);
            this.btn_Enviar.TabIndex = 23;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = false;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // rbn_No
            // 
            this.rbn_No.AutoSize = true;
            this.rbn_No.Location = new System.Drawing.Point(206, 240);
            this.rbn_No.Name = "rbn_No";
            this.rbn_No.Size = new System.Drawing.Size(39, 17);
            this.rbn_No.TabIndex = 53;
            this.rbn_No.TabStop = true;
            this.rbn_No.Text = "No";
            this.rbn_No.UseVisualStyleBackColor = true;
            // 
            // rbn_Si
            // 
            this.rbn_Si.AutoSize = true;
            this.rbn_Si.Location = new System.Drawing.Point(132, 240);
            this.rbn_Si.Name = "rbn_Si";
            this.rbn_Si.Size = new System.Drawing.Size(34, 17);
            this.rbn_Si.TabIndex = 52;
            this.rbn_Si.TabStop = true;
            this.rbn_Si.Text = "Si";
            this.rbn_Si.UseVisualStyleBackColor = true;
            // 
            // lbl_Activo
            // 
            this.lbl_Activo.AutoSize = true;
            this.lbl_Activo.Location = new System.Drawing.Point(22, 240);
            this.lbl_Activo.Name = "lbl_Activo";
            this.lbl_Activo.Size = new System.Drawing.Size(37, 13);
            this.lbl_Activo.TabIndex = 51;
            this.lbl_Activo.Text = "Activo";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(124, 31);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(121, 20);
            this.txtDni.TabIndex = 54;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(124, 75);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 55;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(124, 115);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(121, 20);
            this.txtDireccion.TabIndex = 56;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 163);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 57;
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(124, 202);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(121, 20);
            this.txtFechaNacimiento.TabIndex = 58;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(383, 119);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 60;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(383, 78);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 20);
            this.txtApellido.TabIndex = 59;
            // 
            // FrmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 360);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtFechaNacimiento);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.rbn_No);
            this.Controls.Add(this.rbn_Si);
            this.Controls.Add(this.lbl_Activo);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_FechaNacimiento);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Dirección);
            this.Controls.Add(this.lbl_Apellido);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Dni);
            this.Name = "FrmAgregarCliente";
            this.Text = "AgregarCliente";
            this.Load += new System.EventHandler(this.FrmAgregarCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Dni;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Dirección;
        private System.Windows.Forms.Label lbl_FechaNacimiento;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.RadioButton rbn_No;
        private System.Windows.Forms.RadioButton rbn_Si;
        private System.Windows.Forms.Label lbl_Activo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtApellido;
    }
}