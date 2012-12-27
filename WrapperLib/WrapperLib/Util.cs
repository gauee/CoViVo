using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WrapperLib
{
    class Util
    {
        public virtual byte[] Wrap(Message kom)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Message));
            StringBuilder sb = new StringBuilder();
            TextWriter textWriter = new StringWriter(sb);
            serializer.Serialize(textWriter, kom);
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            byte[] tab = new byte[sb.Length - 1];
            tab = encoding.GetBytes(sb.ToString());
            textWriter.Close();
            return tab;
        }

        public static Message Unwrap(byte[] msg)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Message));
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();

            StringBuilder sb = new StringBuilder();
            TextReader textReader = new StringReader(encoding.GetString(msg));
            Message kom;
            kom = (Message)deserializer.Deserialize(textReader);
            return kom;
        }
    }
}
