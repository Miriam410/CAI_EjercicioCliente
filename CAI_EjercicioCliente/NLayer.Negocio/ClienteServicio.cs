using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.Entidad;
using NLayer.Dato;

namespace NLayer.Negocio
{
    public  class ClienteServicio
    {
        private ClienteMapper mapper;

        public ClienteServicio()
        {
            mapper = new ClienteMapper();
        }

        public List<Cliente> TraerTodos()
        {
            List<Cliente> result = mapper.TraerTodos();
            return result;
        }

        public Cliente TraerClientePorId(int id)
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

        public TransactionResult Insert(Cliente cliente)
        {
            List<Cliente> result = mapper.TraerTodos();
            
            foreach (Cliente item in result)
            {
                if (item.Id == cliente.Id)
                {
                    throw new Exception("El cliente ya existe");
                }
            }
            TransactionResult resultante = mapper.Insert(cliente);
            if (resultante.IsOk)
            {
                return resultante;
            }
            else 
            {
                throw new Exception("Hubo un error en la peticiòn al servidor. Detalle: "+resultante.Error);
            }
        }
        
    }
}
