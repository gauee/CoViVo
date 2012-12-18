using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WrapperLib
{
    class AudioVideoText : Message
    {
        public byte[] audio
        { get; set; }

        public byte[] video
        { get; set; }

        public byte[] text
        { get; set; }

        AudioVideoText() : base()
        {
            
        }

        public byte[] Wrap()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AudioVideoText));
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
            XmlSerializer deserializer = new XmlSerializer(typeof(AudioVideoText));
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();

            StringBuilder sb = new StringBuilder();
            TextReader textReader = new StringReader(encoding.GetString(msg));
            AudioVideoText avt;
            avt = (AudioVideoText)deserializer.Deserialize(textReader);
            messageCode = avt.messageCode;
            messageNumber = avt.messageNumber;
            user = avt.user;
            recipient = avt.recipient;
            audio = avt.audio;
            video = avt.video;
            text = avt.text;

        }
    }
}
