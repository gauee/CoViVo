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
    [XmlInclude(typeof(AudioVideoText))]
    [XmlInclude(typeof(ServerMsg))]
    [XmlInclude(typeof(Error))]
    abstract class Message
    {
        public int messageCode
        { get; set; }

        public int messageNumber
        { get; set; }

        public string user
        { get; set; }

        public string recipient
        { get; set; }
        public Message()
        {
            messageCode = 0;
            messageNumber = 0;
            user = "";
            recipient = "";
        }

    }
}
