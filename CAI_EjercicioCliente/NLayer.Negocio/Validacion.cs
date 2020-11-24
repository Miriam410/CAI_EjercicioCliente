using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLayer.Entidad;
using NLayer.Dato;

namespace NLayer.Negocio
{
    public static class Validacion
    {
        static bool Flag = true;
        static string msg = "";
        public  static bool ValidarCampo(string dni, string nombre, string apellido, string direccion, string email, string telefono, string fechaNacimiento)
        {
   
            if (!int.TryParse(dni, out int Dni))
            {
                msg += "El dni solo permite numeros";

            }
            else if (Dni < 0 || Dni > 8)
            {
                msg += "El dni debe tener como mìnimo 8 numeros";
            }


            if ((string.IsNullOrEmpty(nombre) || (string.IsNullOrEmpty(apellido)) || (string.IsNullOrEmpty(direccion) ||  (string.IsNullOrEmpty(telefono)))))
            {
                msg += "Se requiere el nombre";
                msg += "Se requiere el apellido";
                msg += "Se requiere el direccion";

                msg += "Se requiere el telefono";
            }

            msg += ValidarFecha(fechaNacimiento, "fecha nacimiento");

         
            if (!string.IsNullOrEmpty(msg))
            {
                msg = "Error de datos";
                Flag = false;
            }
            return Flag;
        }


        public static string ValidarFecha(string fecha, string campo)
        {

            if (!DateTime.TryParse(fecha, out DateTime fechas))
            {
                msg = "El dni solo permite ingresar una fecha";

            }
            else if (fechas > DateTime.Now)
            {
                msg = "La fecha no puede ser superior a hoy";
            }
            else
            {
                msg = "";
            }
            return msg;
        }

        public static  bool ValidarCampoCuenta(string idCliente, string numeroCuenta, string saldo, string descripcion)
        {

            msg += ValidarNumero(idCliente, "id Clienta");

            msg += ValidarNumero(numeroCuenta, "numero cuenta");

            if (!float.TryParse(saldo, out float Saldo))
            {
                msg += "El saldo debe ser numerico";
            }
           
            if (string.IsNullOrEmpty(descripcion))
            {
                msg += "La descripcion es necesaria";
            }

            if (!string.IsNullOrEmpty(msg))
            {
                msg = "Error de datos";
                Flag = false;
            }
            return Flag;
        }

        public static string ValidarNumero(string num, string campo)
        {
            string msg;

            if (!int.TryParse(num, out int numero))
            {
                msg = "El campo" +campo+ "debe ser numerico"+System.Environment.NewLine;

            }
            else if (numero<0)
            {
                msg = "El campo"+campo+ "no puede ser negativo"+System.Environment.NewLine;
            }
            else
            {
                msg = "";
            }
            return msg;
        }

           
    }

  }
