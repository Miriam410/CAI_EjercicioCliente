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
        FrmPrincipal frmPrincipal;
        ClienteServicio clienteServ;
        private List<Cliente> cliente;

        public FrmAgregarCliente()
        {
            InitializeComponent();
            clienteServ = new ClienteServicio();
            this.cliente = this.clienteServ.TraerTodos();

        }
      
        private void FrmAgregarCliente_Load(object sender, EventArgs e)
        {
            frmPrincipal = new FrmPrincipal();
        }
        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            
            try
            {
                bool Flag = Validacion.ValidarCampo(txtDni.Text, txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtEmail.Text, txtTelefono.Text, txtFechaNacimiento.Text);
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
                   

                    List<Cliente> lists = clienteServ.TraerTodos();
                    clienteServ.Insert(ingCliente);
                    MessageBox.Show("CLiente ingresado", "Ingreso Exitoso");
                    BorrarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void BorrarCampos()
        {
            txtDni.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtFechaNacimiento.Text = string.Empty;
        }
        
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            frmPrincipal.Show();
        }


    }
}
