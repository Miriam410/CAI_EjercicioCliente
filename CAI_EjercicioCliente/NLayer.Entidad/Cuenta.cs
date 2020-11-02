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
        private int _nroCuenta;
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

        public int NroCuenta
        {
            get { return _nroCuenta; }
            set { _nroCuenta = value; }
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public float Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public DateTime FechaApertura
        {
            get { return _fechaApertura; }
            set { FechaApertura = value; }
        }

        public DateTime FechaModificacion
        {
            get { return _fechaModificacion; }
            set { _fechaModificacion = value; }
        }

        public bool Activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        public int IdCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        public override string ToString()
        {
            return string.Format("El cliente{0} con numero de cuenta{1} tiene un saldo de {2}", this._idCliente,this._nroCuenta,this._saldo);
        }
    }

}
