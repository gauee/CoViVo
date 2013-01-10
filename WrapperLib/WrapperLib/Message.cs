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
    [XmlInclude(typeof(Audio))]
    [XmlInclude(typeof(Video))]
    [XmlInclude(typeof(Text))]
    [XmlInclude(typeof(ServerMsg))]
    [XmlInclude(typeof(Error))]
    [XmlInclude(typeof(JoinChannel))]
    [XmlInclude(typeof(ChannelList))]
    [XmlInclude(typeof(RequestChannelList))]
    [XmlInclude(typeof(Autenticate))]
    [XmlInclude(typeof(LeaveChannel))]
    [XmlInclude(typeof(StartChannel))]
    [XmlInclude(typeof(RequestAlive))]
    [XmlInclude(typeof(Alive))]
    [XmlInclude(typeof(JoinServer))]

    public abstract class Message
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
