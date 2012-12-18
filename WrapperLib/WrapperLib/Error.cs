using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WrapperLib
{
    class Error : Message
    {
        public string errorMsg
        { get; set; }

        Error() : base() 
        {
            errorMsg = "";
        }


        public byte[] Wrap()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Error));
            StringBuilder sb = new StringBuilder();
            TextWriter textWriter = new StringWriter(sb);
            serializer.Serialize(textWriter, this);
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            byte[] tab = new byte[sb.Length - 1];
            tab = encoding.GetBytes(sb.ToString());
            textWriter.Close();
            return tab;
        }

        public void Unwrap(byte[] msg)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Error));
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();

            StringBuilder sb = new StringBuilder();
            TextReader textReader = new StringReader(encoding.GetString(msg));
            Error err;
            err = (Error)deserializer.Deserialize(textReader);

            messageCode = err.messageCode;
            messageNumber = err.messageNumber;
            user = err.user;
            recipient = err.recipient;
            errorMsg = err.errorMsg;
        }
    }
}
