using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapperLib
{
    [Serializable]
    public class JoinChannel : ServerMsg
    {
        public string channelName
        { get; set; }

        public JoinChannel() : base()
        {
            channelName = "";
        }
    }
}
