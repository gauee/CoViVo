using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapperLib
{
    [Serializable]
    public class ServerMsg : Message
    {
        public int command
        { get; set; }

        public string parameters
        { get; set; }

        public ServerMsg() : base(){
            command = 0;
            parameters = "";
        }
    }
}
