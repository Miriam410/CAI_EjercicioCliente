namespace CAI_EjercicioCliente
{
    partial class FrmAgregarCuenta
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
            this.btn_Enviar = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.lbl_IdCliente = new System.Windows.Forms.Label();
            this.lbl_FechaModificación = new System.Windows.Forms.Label();
            this.lbl_FechaApertura = new System.Windows.Forms.Label();
            this.lbl_Saldo = new System.Windows.Forms.Label();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.lbl_NroCuenta = new System.Windows.Forms.Label();
            this.lbl_Activo = new System.Windows.Forms.Label();
            this.rbn_Si = new System.Windows.Forms.RadioButton();
            this.rbn_No = new System.Windows.Forms.RadioButton();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtFechaModificacion = new System.Windows.Forms.TextBox();
            this.txtFechaApertura = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Enviar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Enviar.Location = new System.Drawing.Point(95, 368);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Size = new System.Drawing.Size(86, 41);
            this.btn_Enviar.TabIndex = 47;
            this.btn_Enviar.Text = "Enviar";
            this.btn_Enviar.UseVisualStyleBackColor = false;
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.Red;
            this.btn_Salir.Location = new System.Drawing.Point(323, 368);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(100, 41);
            this.btn_Salir.TabIndex = 46;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(36, 314);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(16, 13);
            this.lbl_Id.TabIndex = 34;
            this.lbl_Id.Text = "Id";
            // 
            // lbl_IdCliente
            // 
            this.lbl_IdCliente.AutoSize = true;
            this.lbl_IdCliente.Location = new System.Drawing.Point(33, 277);
            this.lbl_IdCliente.Name = "lbl_IdCliente";
            this.lbl_IdCliente.Size = new System.Drawing.Size(51, 13);
            this.lbl_IdCliente.TabIndex = 32;
            this.lbl_IdCliente.Text = "Id Cliente";
            // 
            // lbl_FechaModificación
            // 
            this.lbl_FechaModificación.AutoSize = true;
            this.lbl_FechaModificación.Location = new System.Drawing.Point(33, 207);
            this.lbl_FechaModificación.Name = "lbl_FechaModificación";
            this.lbl_FechaModificación.Size = new System.Drawing.Size(100, 13);
            this.lbl_FechaModificación.TabIndex = 30;
            this.lbl_FechaModificación.Text = "Fecha Modificación";
            // 
            // lbl_FechaApertura
            // 
            this.lbl_FechaApertura.AutoSize = true;
            this.lbl_FechaApertura.Location = new System.Drawing.Point(36, 168);
            this.lbl_FechaApertura.Name = "lbl_FechaApertura";
            this.lbl_FechaApertura.Size = new System.Drawing.Size(80, 13);
            this.lbl_FechaApertura.TabIndex = 28;
            this.lbl_FechaApertura.Text = "Fecha Apertura";
            // 
            // lbl_Saldo
            // 
            this.lbl_Saldo.AutoSize = true;
            this.lbl_Saldo.Location = new System.Drawing.Point(36, 124);
            this.lbl_Saldo.Name = "lbl_Saldo";
            this.lbl_Saldo.Size = new System.Drawing.Size(34, 13);
            this.lbl_Saldo.TabIndex = 27;
            this.lbl_Saldo.Text = "Saldo";
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(36, 80);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(63, 13);
            this.lbl_Descripcion.TabIndex = 25;
            this.lbl_Descripcion.Text = "Descripcion";
            // 
            // lbl_NroCuenta
            // 
            this.lbl_NroCuenta.AutoSize = true;
            this.lbl_NroCuenta.Location = new System.Drawing.Point(36, 40);
            this.lbl_NroCuenta.Name = "lbl_NroCuenta";
            this.lbl_NroCuenta.Size = new System.Drawing.Size(96, 13);
            this.lbl_NroCuenta.TabIndex = 24;
            this.lbl_NroCuenta.Text = "Número de Cuenta";
            // 
            // lbl_Activo
            // 
            this.lbl_Activo.AutoSize = true;
            this.lbl_Activo.Location = new System.Drawing.Point(33, 235);
            this.lbl_Activo.Name = "lbl_Activo";
            this.lbl_Activo.Size = new System.Drawing.Size(37, 13);
            this.lbl_Activo.TabIndex = 48;
            this.lbl_Activo.Text = "Activo";
            // 
            // rbn_Si
            // 
            this.rbn_Si.AutoSize = true;
            this.rbn_Si.Location = new System.Drawing.Point(240, 235);
            this.rbn_Si.Name = "rbn_Si";
            this.rbn_Si.Size = new System.Drawing.Size(34, 17);
            this.rbn_Si.TabIndex = 49;
            this.rbn_Si.TabStop = true;
            this.rbn_Si.Text = "Si";
            this.rbn_Si.UseVisualStyleBackColor = true;
            // 
            // rbn_No
            // 
            this.rbn_No.AutoSize = true;
            this.rbn_No.Location = new System.Drawing.Point(338, 235);
            this.rbn_No.Name = "rbn_No";
            this.rbn_No.Size = new System.Drawing.Size(39, 17);
            this.rbn_No.TabIndex = 50;
            this.rbn_No.TabStop = true;
            this.rbn_No.Text = "No";
            this.rbn_No.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(195, 314);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(157, 20);
            this.txtId.TabIndex = 70;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(195, 274);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(157, 20);
            this.txtIdCliente.TabIndex = 69;
            // 
            // txtFechaModificacion
            // 
            this.txtFechaModificacion.Location = new System.Drawing.Point(195, 208);
            this.txtFechaModificacion.Name = "txtFechaModificacion";
            this.txtFechaModificacion.Size = new System.Drawing.Size(228, 20);
            this.txtFechaModificacion.TabIndex = 68;
            // 
            // txtFechaApertura
            // 
            this.txtFechaApertura.Location = new System.Drawing.Point(195, 169);
            this.txtFechaApertura.Name = "txtFechaApertura";
            this.txtFechaApertura.Size = new System.Drawing.Size(228, 20);
            this.txtFechaApertura.TabIndex = 67;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(195, 121);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(228, 20);
            this.txtSaldo.TabIndex = 66;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(195, 81);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(228, 20);
            this.txtDescripcion.TabIndex = 65;
            // 
            // txtNumeroCuenta
            // 
            this.txtNumeroCuenta.Location = new System.Drawing.Point(195, 37);
            this.txtNumeroCuenta.Name = "txtNumeroCuenta";
            this.txtNumeroCuenta.Size = new System.Drawing.Size(228, 20);
            this.txtNumeroCuenta.TabIndex = 64;
            // 
            // FrmAgregarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.txtFechaModificacion);
            this.Controls.Add(this.txtFechaApertura);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNumeroCuenta);
            this.Controls.Add(this.rbn_No);
            this.Controls.Add(this.rbn_Si);
            this.Controls.Add(this.lbl_Activo);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_IdCliente);
            this.Controls.Add(this.lbl_FechaModificación);
            this.Controls.Add(this.lbl_FechaApertura);
            this.Controls.Add(this.lbl_Saldo);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.lbl_NroCuenta);
            this.Name = "FrmAgregarCuenta";
            this.Text = "AgregarCuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Enviar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label lbl_IdCliente;
        private System.Windows.Forms.Label lbl_FechaModificación;
        private System.Windows.Forms.Label lbl_FechaApertura;
        private System.Windows.Forms.Label lbl_Saldo;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.Label lbl_NroCuenta;
        private System.Windows.Forms.Label lbl_Activo;
        private System.Windows.Forms.RadioButton rbn_Si;
        private System.Windows.Forms.RadioButton rbn_No;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtFechaModificacion;
        private System.Windows.Forms.TextBox txtFechaApertura;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNumeroCuenta;
    }
}