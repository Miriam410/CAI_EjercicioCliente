using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLayer.Entidad;
using NLayer.Negocio;



namespace CAI_EjercicioCliente
{
    public partial class FrmAgregarCliente : Form
    {
        FrmPrincipal owner;
        public FrmAgregarCliente(FrmPrincipal own)
        {
            InitializeComponent();
            owner = new FrmPrincipal();
            owner = own;

            bool Flag= Validacion.ValidarCampo(txtDni.Text,txtNombre.Text,txtApellido.Text,txtDireccion.Text,txtEmail.Text,txtTelefono.Text,txtFechaNacimiento.Text,txtFechaAlta);
            if (Flag)
            {
                Cliente ingCliente = new Cliente();
                ingCliente.Dni = Convert.ToInt32(txtDni.Text);
                ingCliente.Nombre = txtNombre.Text;
                ingCliente.Apellido = txtApellido.Text;
                ingCliente.Direccion = txtDireccion.Text;
                ingCliente.Email = txtEmail.Text;
                ingCliente.Telefono = txtTelefono.Text;
                ingCliente.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
                ingCliente.FechaAlta = Convert.ToDateTime(txtFechaAlta.Text);
            }
            try
            {
                owner.IngresarCliente(ingCliente);
                MessageBox.Show("CLiente ingresado", "Ingreso Exitoso");
                Volver();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void Volver()
        {
            this.Owner.Show();
            this.Close();
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            ValidarCampo();
            owner.ActualizarClientes();
            Volver();
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }


    }
}
