using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.Entidad;
using NLayer.Dato;

namespace NLayer.Negocio
{
    public class ClienteServicio
    {
        private ClienteMapper mapper;

        public ClienteServicio()
        {
            mapper = new ClienteMapper();
        }

        public List<Cliente> TraerClientes()
        {
            List<Cliente> result = mapper.TraerTodos();
            return result;
        }

        public Cliente TraerCLientesPorId(int id)
        {
            List<Cliente> result = mapper.TraerTodos();

            Cliente cli = null;
            foreach (Cliente c in result)
            {
                if (c.Id == id)
                {
                    cli = c;
                }
            }
            return cli;
        }

        public int InsertarCliente(string nombre, string apellido, string direccion)
        {
            List<Cliente> result = mapper.TraerTodos();
            Cliente cliente = new Cliente();
            cliente.Apellido = apellido;
            cliente.Nombre = nombre;
            cliente.Direccion = direccion;

            foreach (var item in result)
            {
                if (item.ToString() == cliente.ToString())
                {
                    throw new Exception("El cliente ya existe");
                }
            }
            TransactionResult resultante = mapper.Insert(cliente);
            if (resultante.IsOk)
            {
                return resultante.Id;
            }
            else 
            {
                throw new Exception("Hubo un error en la peticiòn al servidor. Detalle: "+resultante.Error);
            }
        }
    }
}
