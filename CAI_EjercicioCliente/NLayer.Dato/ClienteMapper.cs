using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.Entidad;
using System.Collections.Specialized;
using Newtonsoft.Json;
using System.Configuration;

namespace NLayer.Dato
{
    public class ClienteMapper
    {
        public List<Cliente> TraerTodos()
        {
            string json = WebHelper.Get("/api/v1/cliente");
            List<Cliente> resultado = MapList(json);
            return resultado;
        }

        public TransactionResult Insert(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string result = WebHelper.Post("/api/v1/cliente", obj);
            TransactionResult resultadoTransaccion = MapResultado(result);
            return resultadoTransaccion;
        }

        private List<Cliente> MapList(string json)
        {
            List<Cliente> lst = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return lst;
        }

        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Nombre",cliente.Nombre);
            n.Add("Apellido",cliente.Apellido);
            n.Add("Direccion",cliente.Direccion);
            n.Add("Usuario",ConfigurationManager.AppSettings["Legajo"]);
            n.Add("Email", cliente.Email);
            n.Add("Telefono",cliente.Telefono.ToString());
            n.Add("FechaNacimiento", cliente.FechaNacimiento.ToString());
            n.Add("Fechaalta", cliente.FechaAlta.ToString());
            return n;
        }

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }


    }

}
