using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapperLib
{
    [Serializable]
    public class ChannelList : ServerMsg
    {
        public string[] channelList
        { get; set; }

        public ChannelList()
            : base()
        {

        }
    }
}
