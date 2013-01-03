using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapperLib
{
    [Serializable]
    public class LeaveChannel : ServerMsg
    {
        public string channelName
        { get; set; }

        public LeaveChannel() : base()
        {
            channelName = "";
        }
    }
}
