using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WrapperLib
{
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
        public Message() {
            messageCode = 0;
            messageNumber = 0;
            user = "";
            recipient = "";
        }

        public virtual byte[] Wrap() {
            XmlSerializer serializer = new XmlSerializer(typeof(Message));
            StringBuilder sb = new StringBuilder();
            TextWriter textWriter = new StringWriter(sb);
            serializer.Serialize(textWriter,this);
            System.Text.ASCIIEncoding  encoding=new System.Text.ASCIIEncoding();
            byte[] tab = new byte[sb.Length - 1];
                tab = encoding.GetBytes(sb.ToString());
            textWriter.Close();
            return tab;
        }

        public virtual void Unwrap(byte[] msg) {
            XmlSerializer deserializer = new XmlSerializer(typeof(Message));
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();

            StringBuilder sb = new StringBuilder();
            TextReader textReader = new StringReader(encoding.GetString(msg));
            Message kom;
            kom = (Message)deserializer.Deserialize(textReader);
            
            messageCode = kom.messageCode;
            messageNumber = kom.messageNumber;
            user = kom.user;
            recipient = kom.recipient;
        }

    }
}
