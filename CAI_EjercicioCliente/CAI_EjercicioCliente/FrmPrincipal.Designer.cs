namespace CAI_EjercicioCliente
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_Cliente = new System.Windows.Forms.GroupBox();
            this.btn_BorrarCliente = new System.Windows.Forms.Button();
            this.btn_AgregarCuenta = new System.Windows.Forms.Button();
            this.btn_VerCuenta = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_VerCliente = new System.Windows.Forms.Button();
            this.btn_AgregarCliente = new System.Windows.Forms.Button();
            this.gb_Cliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Cliente
            // 
            this.gb_Cliente.Controls.Add(this.btn_BorrarCliente);
            this.gb_Cliente.Controls.Add(this.btn_AgregarCuenta);
            this.gb_Cliente.Controls.Add(this.btn_VerCuenta);
            this.gb_Cliente.Controls.Add(this.listBox1);
            this.gb_Cliente.Controls.Add(this.btn_VerCliente);
            this.gb_Cliente.Controls.Add(this.btn_AgregarCliente);
            this.gb_Cliente.Location = new System.Drawing.Point(12, 27);
            this.gb_Cliente.Name = "gb_Cliente";
            this.gb_Cliente.Size = new System.Drawing.Size(614, 384);
            this.gb_Cliente.TabIndex = 0;
            this.gb_Cliente.TabStop = false;
            // 
            // btn_BorrarCliente
            // 
            this.btn_BorrarCliente.BackColor = System.Drawing.Color.Red;
            this.btn_BorrarCliente.ForeColor = System.Drawing.Color.Black;
            this.btn_BorrarCliente.Location = new System.Drawing.Point(204, 354);
            this.btn_BorrarCliente.Name = "btn_BorrarCliente";
            this.btn_BorrarCliente.Size = new System.Drawing.Size(84, 24);
            this.btn_BorrarCliente.TabIndex = 3;
            this.btn_BorrarCliente.Text = "Borrar";
            this.btn_BorrarCliente.UseVisualStyleBackColor = false;
            // 
            // btn_AgregarCuenta
            // 
            this.btn_AgregarCuenta.Location = new System.Drawing.Point(23, 192);
            this.btn_AgregarCuenta.Name = "btn_AgregarCuenta";
            this.btn_AgregarCuenta.Size = new System.Drawing.Size(234, 49);
            this.btn_AgregarCuenta.TabIndex = 2;
            this.btn_AgregarCuenta.Text = "Agregar Cuenta";
            this.btn_AgregarCuenta.UseVisualStyleBackColor = true;
            this.btn_AgregarCuenta.Click += new System.EventHandler(this.btn_AgregarCuenta_Click);
            // 
            // btn_VerCuenta
            // 
            this.btn_VerCuenta.Location = new System.Drawing.Point(23, 247);
            this.btn_VerCuenta.Name = "btn_VerCuenta";
            this.btn_VerCuenta.Size = new System.Drawing.Size(234, 41);
            this.btn_VerCuenta.TabIndex = 3;
            this.btn_VerCuenta.Text = "Ver Cuenta";
            this.btn_VerCuenta.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(288, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 251);
            this.listBox1.TabIndex = 2;
            // 
            // btn_VerCliente
            // 
            this.btn_VerCliente.Location = new System.Drawing.Point(20, 90);
            this.btn_VerCliente.Name = "btn_VerCliente";
            this.btn_VerCliente.Size = new System.Drawing.Size(237, 41);
            this.btn_VerCliente.TabIndex = 1;
            this.btn_VerCliente.Text = "Ver Cliente";
            this.btn_VerCliente.UseVisualStyleBackColor = true;
            // 
            // btn_AgregarCliente
            // 
            this.btn_AgregarCliente.Location = new System.Drawing.Point(20, 29);
            this.btn_AgregarCliente.Name = "btn_AgregarCliente";
            this.btn_AgregarCliente.Size = new System.Drawing.Size(237, 49);
            this.btn_AgregarCliente.TabIndex = 0;
            this.btn_AgregarCliente.Text = "Agregar Cliente";
            this.btn_AgregarCliente.UseVisualStyleBackColor = true;
            this.btn_AgregarCliente.Click += new System.EventHandler(this.btn_AgregarCliente_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gb_Cliente);
            this.Name = "FrmPrincipal";
            this.Text = "Cliente Cuenta";
            this.gb_Cliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Cliente;
        private System.Windows.Forms.Button btn_VerCuenta;
        private System.Windows.Forms.Button btn_AgregarCuenta;
        private System.Windows.Forms.Button btn_VerCliente;
        private System.Windows.Forms.Button btn_AgregarCliente;
        private System.Windows.Forms.Button btn_BorrarCliente;
        private System.Windows.Forms.ListBox listBox1;
    }
}

