using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapperLib
{
    [Serializable]
    public class Autenticate :ServerMsg
    {
        public string password
        { get; set; }

        public Autenticate()
            : base()
        {
            password = "";
        }
    }
}
