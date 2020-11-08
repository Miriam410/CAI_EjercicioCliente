using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using NLayer.Entidad;


namespace NLayer.Entidad
{
    [DataContract]
    public class Cliente
    {
        private int _dni;
        private string _nombre;
        private string _apellido;
        private string _direeccion;
        private string _email;
        private string _telefono;
        private DateTime _fechaNacimiento;
        private DateTime _fechaAlta;
        private bool _activo;
        private string _usuario;
        private string _host;
        private int _id;

        [DataMember]
        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        [DataMember]
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        [DataMember]
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        [DataMember]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [DataMember]
        public string Direccion
        {
            get { return _direeccion; }
            set { _direeccion = value; }
        }
        [DataMember]
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        [DataMember]
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        [DataMember]
        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        [DataMember]
        public DateTime FechaAlta
        {
            get { return _fechaAlta; }
            set { _fechaAlta = value; }
        }
  
        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }
     
        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        
        public string Host
        {
            get { return _host; }
            set { _host = value; }
        }
        public Cliente()
        {
           
        }
    }

}
