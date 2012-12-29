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
    public class AudioVideoText : Message
    {
        public byte[] audio
        { get; set; }

        public byte[] video
        { get; set; }

        public byte[] text
        { get; set; }

        public AudioVideoText() : base()
        {
           
        }

    }
}
