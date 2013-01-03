using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapperLib
{

    [Serializable]
    public class Video : Message
    {
        public byte[] video
        { get; set; }

        public Video()
            : base()
        {

        }

    }
}
