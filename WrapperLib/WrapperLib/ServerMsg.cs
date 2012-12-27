using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapperLib
{
    [Serializable]
    class ServerMsg :Message
    {
        int command
        { get; set; }

        string parameters
        { get; set; }
    }
}
