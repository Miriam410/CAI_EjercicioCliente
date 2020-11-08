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
         FrmPrincipal owner;
        public FrmAgregarCuenta(FrmPrincipal own)
        {
            InitializeComponent();
            owner = new FrmPrincipal();
            owner = own;
        }
        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            bool Flag = Validacion.ValidarCampo(txtIdCliente.Text, txtNumeroCuenta.Text, txtSaldo.Text, txtDescripcion.Text);
            if (Flag)
            {

                Cuenta ingCuenta = new Cuenta();

                ingCuenta.IdCliente = Convert.ToInt32(txtIdCliente.Text);
                Cliente ingCliente = owner.TraerPorId(Convert.ToInt32(txtIdCliente.Text));
                if (ingCliente == null)
                {
                    MessageBox.Show($"No eciste el cliente con el Id: {(Convert.ToInt32(txtIdCliente.Text))}");
                    return;
                }

                ingCuenta.NumeroCuenta = Convert.ToInt32(txtNumeroCuenta.Text);
                Cuenta CuentaRepetida = owner.TraerCuentaPorNumero(Convert.ToInt32(txtNumeroCuenta.Text));
                if (CuentaRepetida != null)
                {
                    MessageBox.Show("La cuenta ya existe", "Error");
                }

                ingCuenta.Saldo = Convert.ToSingle(txtSaldo.Text);
                ingCuenta.Descripcion = txtDescripcion.Text;

                try
                {

                    owner.IngresarCuenta(ingCuenta);
                    MessageBox.Show("Cuenta ingresada", "Ingreso Exitoso");
                    Volver();
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void Volver()
        {
            this.Owner.Show();
            this.Close();
        }
       
    }
}
