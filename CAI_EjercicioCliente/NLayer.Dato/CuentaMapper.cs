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
    public class CuentaMapper
    {
        public List<Cuenta> TraerTodos(int idCliente)
        {
            string json2 = WebHelper.Get("/api/v1/cuenta");
            List<Cuenta> resultado = MapList(json2);
            return resultado;
        }

        public TransactionResult Insert(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta);
            string result = WebHelper.Post("/api/v1/cuenta", obj);
            TransactionResult resultadoTransaccion = MapResultado(result);
            return resultadoTransaccion;
        }

        
        private List<Cuenta> MapList(string json)
        {
            List<Cuenta> lst = JsonConvert.DeserializeObject<List<Cuenta>>(json);
            return lst;
        }

        private NameValueCollection ReverseMap(Cuenta cuenta)
        {
            NameValueCollection n = new NameValueCollection();
           
            n.Add("IdCliente", cuenta.IdCliente.ToString());
            n.Add("NumeroCuenta", cuenta.NumeroCuenta.ToString());
 
            n.Add("Descripcion",cuenta.Descripcion);
            n.Add("Saldo", cuenta.Saldo.ToString());
            return n;
        }
            
     

        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
    }
}
