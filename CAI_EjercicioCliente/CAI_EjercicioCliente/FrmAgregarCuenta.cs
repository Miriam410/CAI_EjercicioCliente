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
    public partial class FrmAgregarCuenta : Form
    {
        private ClienteServicio clienteServicio;
        private CuentaServicio cuentaServicio;
        private FrmPrincipal frmPrincipal;
        public FrmAgregarCuenta()
        {
            InitializeComponent();
            clienteServicio = new ClienteServicio();
            cuentaServicio = new CuentaServicio();
        }

        private void FrmAgregarCuenta_Load(object sender, EventArgs e)
        {
            frmPrincipal = new FrmPrincipal();
        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            try
            {
                bool Flag = Validacion.ValidarCampoCuenta(txtIdCliente.Text, txtNumeroCuenta.Text, txtSaldo.Text, txtDescripcion.Text);
                if (Flag)
                {

                    Cuenta ingCuenta = new Cuenta();

                    ingCuenta.IdCliente = Convert.ToInt32(txtIdCliente.Text);
                    Cliente ingCliente = clienteServicio.TraerClientePorId(Convert.ToInt32(txtIdCliente.Text));
                    if (ingCliente == null)
                    {
                        MessageBox.Show($"No eciste el cliente con el Id: {(Convert.ToInt32(txtIdCliente.Text))}");
                        return;
                    }

                    ingCuenta.NumeroCuenta = Convert.ToInt32(txtNumeroCuenta.Text);
                    Cuenta CuentaRepetida = cuentaServicio.TraerCuentaPorNumero(Convert.ToInt32(txtNumeroCuenta.Text));
                    if (CuentaRepetida != null)
                    {
                        MessageBox.Show("La cuenta ya existe", "Error");
                    }

                    ingCuenta.Saldo = Convert.ToSingle(txtSaldo.Text);
                    ingCuenta.Descripcion = txtDescripcion.Text;
                    cuentaServicio.Insert(ingCuenta);
                    MessageBox.Show("Cuenta ingresada", "Ingreso Exitoso");
                    BorrarCampos();
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void BorrarCampos()
        {
            txtIdCliente.Clear();
            txtNumeroCuenta.Clear();
            txtSaldo.Clear();
            txtDescripcion.Clear();
        }
       
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            frmPrincipal.Show();
            this.Close();
        }
    }
}
