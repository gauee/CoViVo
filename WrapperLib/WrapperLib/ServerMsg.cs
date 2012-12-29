using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapperLib
{
    [Serializable]
    public class ServerMsg :Message
    {
        int command
        { get; set; }

        string parameters
        { get; set; }

        public ServerMsg() : base(){
            command = 0;
            parameters = "";
        }
    }
}
