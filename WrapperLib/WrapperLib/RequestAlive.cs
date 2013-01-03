using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapperLib
{   
    [Serializable]
    public class RequestAlive :ServerMsg
    {
        public int token
        { get; set; }
        public RequestAlive()
            : base()
        {
            token = 0;
        }
        
    }
}
