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
    
    public partial class FrmPrincipal : Form
    {
        private ClienteServicio clienteS;
        private CuentaServicio cuentaS;
        private FrmAgregarCliente AgregarClienteFrom;
        private FrmAgregarCuenta AgregarCuentaForm;

        public FrmPrincipal()
        {
            InitializeComponent();
            clienteS = new ClienteServicio();
            cuentaS = new CuentaServicio();
            AgregarClienteFrom = new FrmAgregarCliente();
            AgregarCuentaForm = new FrmAgregarCuenta();
        }

   
        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarClienteFrom.Owner = this;
            AgregarClienteFrom.Show();
            ActualizarClientes();
            this.Hide();
        }

        private void btn_AgregarCuenta_Click(object sender, EventArgs e)
        {
            AgregarCuentaForm.Owner= this;
            AgregarCuentaForm.Show();
            ActualizarCuenta();
            this.Hide();
        }

        public Cliente TraerPorId(int id)
        {
            Cliente retorno = null;
            retorno = clienteS.TraerClientePorId(id);
            return retorno;
        }

        public Cuenta TraerPorCuentaNumero(int numero)
        {
            Cuenta retorno = null;
            retorno = cuentaS.TraerCuentaPorNumero(numero);
            return retorno;
        }

        public Cuenta TraerCuentaPorId(int id)
        {
            Cuenta retorno = null;
            retorno = cuentaS.TraerCuentaPorId(id);
            return retorno;
        }

        public void IngresarCliente(Cliente ingCliente)
        {
            TransactionResult respuesta = clienteS.Insert(ingCliente);
            if (!respuesta.IsOk)
            {
                throw new ArgumentException("Error de ingreso");
            }
        }

        public void IngresarCuenta(Cuenta ingCuenta)
        {
            TransactionResult respuesta = cuentaS.Insert(ingCuenta);
            if (!respuesta.IsOk)
            {
                throw new ArgumentException("Error de ingreso");
            }
        }

        public void ActualizarClientes()
        {
            List<Cliente> listCliente;
            listCliente = clienteS.TraerTodos();
        }

        public void ActualizarCuenta()
        {
            List<Cuenta> listCuenta;
            listCuenta = cuentaS.TraerTodos();
        }

    }
}
