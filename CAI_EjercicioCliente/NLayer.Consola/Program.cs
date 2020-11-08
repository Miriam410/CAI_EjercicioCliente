using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.Entidad;
using NLayer.Negocio;

namespace NLayer.Consola
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                CuentaServicio servicio = new CuentaServicio();
                Cuenta c = servicio.AbrirCuenta("Caja ahorro", 17);
                Console.WriteLine("Alta cuenta" +c);

                servicio.ModificarSaldo(c.Id,390);
                Console.WriteLine("Saldo Modificado");

                c = servicio.Traer(17);
                Console.WriteLine("El nuevo estado cuenta:"+c);
              
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
