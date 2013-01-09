using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapperLib
{

    [Serializable]
    public class Audio : Message
    {
        public byte[] audio
        { get; set; }

        public Audio()
            : base()
        {

        }

    }
}
