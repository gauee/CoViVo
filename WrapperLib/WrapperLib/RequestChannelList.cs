using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WrapperLib
{   
    [Serializable]
    public class RequestChannelList : ServerMsg
    {
        public string criteria
        { get; set; }

        public RequestChannelList() : base() {
            criteria = "";
        }
    }
}
