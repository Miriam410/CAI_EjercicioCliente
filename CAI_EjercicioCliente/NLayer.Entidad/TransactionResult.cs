using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace NLayer.Entidad
{
 
    public class TransactionResult
    {
        private bool _isOk;
        private int _id;
        private string _error;

    
        public bool IsOk
        {
            get { return _isOk; }
            set{ _isOk = value; }
        }

 
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

    
        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }
    }
}
