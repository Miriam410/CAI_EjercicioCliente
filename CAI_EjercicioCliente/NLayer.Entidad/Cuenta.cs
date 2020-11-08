using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace NLayer.Entidad
{
    [DataContract]
    public class Cuenta
    {
        private int _numeroCuenta;
        private string _descripcion;
        private float _saldo;
        private DateTime _fechaApertura;
        private DateTime _fechaModificacion;
        private bool _activo;
        private int _idCliente;
        private int _id;

        [DataMember]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [DataMember]
        public int NumeroCuenta
        {
            get { return _numeroCuenta; }
            set { _numeroCuenta = value; }
        }
        [DataMember]
        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        [DataMember]
        public float Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }
        [DataMember]
        public DateTime FechaApertura
        {
            get { return _fechaApertura; }
            set { _fechaApertura = value; }
        }
        [DataMember]
        public DateTime FechaModificacion
        {
            get { return _fechaModificacion; }
            set { _fechaModificacion = value; }
        }
        [DataMember]
        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }
        [DataMember]
        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        public Cuenta()
        {
            
        }
    }

}
