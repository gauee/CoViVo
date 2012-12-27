using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WrapperLib
{
    [Serializable]
    class Error : Message
    {
        public string errorMsg
        { get; set; }

        Error() : base() 
        {
            errorMsg = "";
        }

    }
}
