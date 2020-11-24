using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.Entidad;
using NLayer.Dato;

namespace NLayer.Negocio
{
    public class CuentaServicio
    {
        private CuentaMapper mapper;
    
        public CuentaServicio()
        {
            mapper = new CuentaMapper();
           
        }

        public List<Cuenta> TraerTodos()
        {
            List<Cuenta> result = mapper.TraerTodos();
            return result;
        }
        public Cuenta TraerCuentaPorId(int id)
        {
            List<Cuenta> result = mapper.TraerTodos();
            Cuenta retorno= null;
            foreach (Cuenta cuenta in result)
            {
                if (cuenta.Id == id)
                {
                    retorno = cuenta;
                }
            }
            return retorno;
        }

        public Cuenta TraerCuentaPorNumero(int numero)
        {
            List<Cuenta> result = mapper.TraerTodos();
            Cuenta retorno = null;
            foreach (Cuenta cuenta in result)
            {
                if (cuenta.NumeroCuenta == numero)
                {
                    retorno = cuenta;
                }
            }
            return retorno;
        }
        public TransactionResult Insert(Cuenta cuenta)
        {
            List<Cuenta> result = mapper.TraerTodos();

            foreach (Cuenta item in result)
            {
                if (item.Id == cuenta.Id)
                {
                    throw new Exception("La cuenta ya existe");
                }
            }
            TransactionResult resultante = mapper.Insert(cuenta);
            if (resultante.IsOk)
            {
                return resultante;
            }
            else
            {
                throw new Exception("Hubo un error en la peticiòn al servidor. Detalle: " + resultante.Error);
            }
        }
    }
}
