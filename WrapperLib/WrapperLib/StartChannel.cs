using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapperLib
{
    public class StartChannel : ServerMsg
    {
        public string channelName
        { get; set; }

        public string description
        { get; set; }

        public string channelType
        { get; set; }

        public StartChannel() : base()
        {
            channelName = "";
            description = "";
            channelType = "";
        }
    }
}
